using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
	public GameObject player;
	public GameObject myPrefab;
	private GameObject toDestroy;
	private bool paused = false;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetMouseButtonDown(2)){
			if(paused){
				if(Input.GetKeyDown(KeyCode.Escape) || Input.GetMouseButtonDown(2)){
					SceneManager.LoadScene(0);
				}
			}
			if(!paused){
				toDestroy = Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
				player.GetComponent<CharacterController>().enabled = false;
				//pauseManager.SetActive(true);
				paused = true;
			}
		}
		
		if(Input.GetKeyDown(KeyCode.Space)){
			if(paused){
				Destroy(toDestroy);
				player.GetComponent<CharacterController>().enabled = true;
				//pauseManager.SetActive(false);
				paused = false;
			}
		}
    }
}
