using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ScoreManager : MonoBehaviour
{
 
    public static int ScoreValue = 0;
    Text score;
    public Text WinText;





    
    
    // Start is called before the first frame update
    void Start()
    {
        
        score = GetComponent<Text>();

        WinText.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        score.text = "Collected Items:" + ScoreValue;

        Win();


    }

    private void Win()
    {
        if (ScoreValue == 10)
        {
            WinText.enabled = true;
        }
    }

}   





