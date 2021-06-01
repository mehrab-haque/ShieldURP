using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
	
	public GameObject Shield;
	private bool isShield=false;
	
    // Start is called before the first frame update
    void Start()
    {
        Shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0)){
        	isShield=!isShield;
        	Shield.SetActive(isShield);
        } 
    }
}
