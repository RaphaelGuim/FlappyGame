using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class ControlaCenario : MonoBehaviour {

	protected Controlador g;
	 
	// Use this for initialization
	void Start () {
		controlador = GameObject.FindObjectOfType<Controlador>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Carrossel();
		Mover();
		 
		 
	}

 

	private void Carrossel()
	{
		 
		if (gameObject.transform.position.x <= -32)
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x+64, transform.position.y, transform.position.z);
			 
		}
	}

	protected abstract void Mover();
	 
}
