using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class PlayerMovement_learnthree : MonoBehaviour
{
    public float speed = 3f;
    public float horizontalspeed;
    public float verticalspeed;
    public Rigidbody2D rb;
    public static bool die = false;
    public Transform secondlevvelocal;
    public GameObject cam;
    public Text level2;
    public GameObject panel;
    public static bool panelss = false;


    // Start is called before the first frame update
    void Start()
    {
        panelss = false;
    }

    // Update is called once per frame
    
           public float hareketHizi = 5.0f; // Nesne hareket h�z�
    private bool yukariHareket = false; // Yukar� hareket durumu

    void Update()
    {
        rb.velocity = Vector2.right * speed;
        // Mouse sol t�klama alg�lama
        if (Input.GetMouseButtonDown(0))
        {
            // E�er nesne yukar�da de�ilse, yukar� hareket ba�lat
            if (!yukariHareket)
            {
                yukariHareket = true;
            }
            // E�er nesne yukar�da ise, a�a�� hareket ba�lat
            else
            {
                yukariHareket = false;
            }
        }

        // Nesneyi yukar� veya a�a�� hareket ettir
        if (yukariHareket)
        {
            transform.Translate(Vector3.up * hareketHizi * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * hareketHizi * Time.deltaTime);
        }
        //horizontalspeed = Input.GetAxis("Horizontal");
        //verticalspeed = Input.GetAxis("Vertical");
        //rb.velocity = new Vector2(horizontalspeed * speed, verticalspeed * speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            gameObject.SetActive(false);
            Time.timeScale = 0;
            die = true;
        }
        if (collision.gameObject.tag == "nextlevel")
        {
            gameObject.transform.position = secondlevvelocal.position;
            cam.transform.position = secondlevvelocal.position;
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z - 3);
            
            //yar�n furkana sor
            Camscript_learnthree.speed += 2f;
            level2.text = "level2";
            panel.gameObject.SetActive(true);
            panelss = true;
            Time.timeScale = 0;




        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "enemy")
        { 
            gameObject.SetActive(false);
            Time.timeScale = 0;
            die = true;
        }
    }


}
