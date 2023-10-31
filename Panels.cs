using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Panels : MonoBehaviour
{
    public Text level2;
    public float realtime = 0f;
    public float targettime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (PlayerMovement_learnthree.panelss)
        {

          
            level2.text = "LEVEL2";
         
           

        }

    }
    public void buttons()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);

            PlayerMovement_learnthree.panelss = false;
        
    }

}
