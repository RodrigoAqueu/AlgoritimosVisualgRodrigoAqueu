using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;


    public Text multiText;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
    }
     public void NoteHit()
     {
         Debug.Log("Hit On Time");

         if(currentMultiplier - 1 < multiplierThresholds.Length)
         {
             multiplierTracker++;

            if(multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
             {
                 multiplierTracker = 0;
                 currentMultiplier++;
             }
         }
    
         currentScore += scorePerNote * currentMultiplier;
         scoreText.text = "Score: " + currentScore;
         multiText.text = "Multiplier: x" + currentMultiplier;
     }

     public void NoteMiss()
     {
         Debug.Log("Missed Note");

         currentMultiplier = 1;
         multiplierTracker = 0;

         multiText.text = "Multiplier: x" + currentMultiplier;

     }


}
