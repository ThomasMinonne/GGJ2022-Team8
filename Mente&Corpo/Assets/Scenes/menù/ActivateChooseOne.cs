using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateChooseOne : MonoBehaviour
{
    public GameObject choosenOne;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey) choosenOne.SetActive(true);
    }
}
