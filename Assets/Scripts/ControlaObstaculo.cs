using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class ControlaObstaculo : MonoBehaviour
{

	public Controlador controlador;
	public bool pontuou = false;

	void Start()
	{
		 controlador = GameObject.FindObjectOfType<Controlador>();
	}

	// Update is called once per frame
	void Update () {

		Mover();
		Desaparecer();
		Pontuar();
	}

	private void Pontuar()
	{
		if (gameObject.transform.position.x <= 0 && pontuou == false)
		{
			controlador.Pontuar();
			pontuou = true;
		}
	}

	private void Mover()
	{
		gameObject.transform.Translate(Vector3.left * controlador.VelocidadeObstatulos*Time.deltaTime);
	}

	private void Desaparecer()
	{
		if (gameObject.transform.position.x <= -18)
		{
			 
			gameObject.SetActive(false);


		}
	}
}
