using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loosing : MonoBehaviour
{
	public GameObject myPrefab;
	public GameObject player;
	public GameObject timer;
	private bool finished = false;
	
    void Update(){
		if(finished){
			if(Input.GetKeyDown(KeyCode.Escape)){
				SceneManager.LoadScene(0);
			}
			else if(Input.GetKeyDown(KeyCode.Space)){
				int index = Random.Range(1,4);
				SceneManager.LoadScene(index);
			}
		}
	}
	public void Death(){
		player.GetComponent<CharacterController>().enabled = false;
		timer.GetComponent<Timer>().timerIsRunning = false;
		Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
		StartCoroutine(waitUntilDeath());
	}
	
	IEnumerator waitUntilDeath(){
		yield return new WaitForSeconds(3);
		finished = true;
	}
}
