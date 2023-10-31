using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camscript_learnthree : MonoBehaviour
{
    public static float speed = 2f;
    public Rigidbody2D rb;
    public float targettime = 3f;
    public float realtime = 0f;
    public bool timeactive = false;

    // Start is called before the first frame update
    void Start()
    {
        timeactive = true;
    }

    // Update is called once per frame
    void Update()
    {
        PlayAgain();
        if (timeactive)
        {
            realtime += Time.deltaTime;
        }
        if (realtime > targettime)
        {
            timeactive = false;
                rb.velocity = Vector2.right*speed;
        }   
    }

  
    void PlayAgain()
    {
        if (Input.GetKeyDown(KeyCode.Space) && PlayerMovement_learnthree.die)
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
            PlayerMovement_learnthree.die = false;
        }
    }
}
