using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectCell : MonoBehaviour
{
    public bool isCorrect = false;
	public bool isColliding = false;
    // Update is called once per frame
    void Update()
    {
		
    }
	void OnTriggerEnter(){
		isColliding = true;
		Debug.Log ("parent is:" + transform.parent.name);
		if(isCorrect == false){	
			Debug.Log("MORTO");
			//Si chiama l'animazione di morte
			Loosing parentScript = this.transform.parent.GetComponent<Loosing>();
			parentScript.Death();
		}
		if(isCorrect == true){	
			Debug.Log("Bravissimo");
		}
	}
}
