using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
	public Text timeText;
	public Animator anim;
	
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
				DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
				//Si chiama l'animazione di morte
				anim.SetBool("Death", true);
				//Reload del livello
				StartCoroutine(waitUntilDeath());
            }
        }
    }
	
	void DisplayTime(float timeToDisplay)
    {
		timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
		
		timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
	
	IEnumerator waitUntilDeath(){
		yield return new WaitForSeconds(1);
		Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
	}
}
