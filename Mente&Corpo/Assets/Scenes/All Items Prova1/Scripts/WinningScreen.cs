using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningScreen : MonoBehaviour
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
				int index = Random.Range(2, 19);
				SceneManager.LoadScene(index);
			}
		}
	}
	void OnTriggerEnter(){
		player.GetComponent<CharacterController>().enabled = false;
		timer.GetComponent<Timer>().timerIsRunning = false;
		Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
		StartCoroutine(waitUntilWin());
	}
	
	IEnumerator waitUntilWin(){
		yield return new WaitForSeconds(3);
		finished = true;
	}
}
