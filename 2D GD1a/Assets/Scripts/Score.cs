using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score, key;

    public int scoreValue;

    public bool winText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This displays "Score" and adds your score value
        score.text = "Score: " + scoreValue;

        if (scoreValue > 3)
        {
            winText = true;
        }

        if (winText)
        {
            score.text = "You Win!";
        }

       
        

    }
}
