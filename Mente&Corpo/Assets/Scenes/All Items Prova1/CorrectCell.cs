using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectCell : MonoBehaviour
{
    public bool isCorrect = false;
	public bool isColliding = false;
	public bool winningCell = false;
	public Animator anim;
	
    // Update is called once per frame
    void Update()
    {
		
    }
	void OnTriggerEnter(){
		isColliding = true;
		if(isCorrect == false){	
			Debug.Log("MORTO");
			//Si chiama l'animazione di morte
			anim.SetBool("Death", true);
			StartCoroutine(waitUntilDeath());
		}
		if(isCorrect == true){	
			Debug.Log("Bravissimo");
		}
	}
	
	IEnumerator waitUntilDeath(){
		yield return new WaitForSeconds(1);
		Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
	}
}
