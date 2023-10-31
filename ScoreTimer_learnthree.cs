using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimer_learnthree : MonoBehaviour
{
    public Text skortest;
    public static float scorefloat;
    public static bool timebool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timebool) {
            scorefloat += Time.deltaTime;
            skortest.text = "score" + Mathf.Round(scorefloat).ToString();
        }
        
    }
   
}
