using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPlayBody : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey){ 
			int index = Random.Range(2,19);
			SceneManager.LoadScene(index);
		}
    }
}
