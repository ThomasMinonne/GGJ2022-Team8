using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoulPause : MonoBehaviour
{
	private bool paused = false;
	public GameObject pauseManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetMouseButtonDown(2)){
			if(paused){
				if(Input.GetKeyDown(KeyCode.Escape) || Input.GetMouseButtonDown(2)){
					SceneManager.LoadScene(0);
				}
			}
			if(!paused){
				pauseManager.SetActive(true);
				paused = true;
			}
		}
		
		if(Input.GetKeyDown(KeyCode.Space)){
			if(paused){
				pauseManager.SetActive(false);
				paused = false;
			}
		}
	}
}
