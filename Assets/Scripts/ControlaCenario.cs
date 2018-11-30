using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class ControlaCenario : MonoBehaviour {

	protected Controlador controlador;
	 
	// Use this for initialization
	void Start () {
		controlador = GameObject.FindObjectOfType<Controlador>();
	}
	
	// Update is called once per frame
	void Update () {	 

		Mover();
		Carrossel();
		 
	}

 

	private void Carrossel()
	{
		if (gameObject.transform.position.x <= -19)
		{
			gameObject.transform.position = new Vector3(35, transform.position.y, transform.position.z);
			 
		}
	}

	protected abstract void Mover();
	 
}
