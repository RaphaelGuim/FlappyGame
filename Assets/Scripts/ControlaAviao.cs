using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAviao : MonoBehaviour {

	Controlador controlador;
	Rigidbody2D rb;
	public float Forca;
	private float tempoInicio = 2;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.simulated = false;
		controlador = GameObject.FindObjectOfType<Controlador>();
	}
	 
	private void Update () {

		if (Input.GetButtonDown("Fire1"))
		{
			Impulsionar();
			rb.simulated = true;
		}
		tempoInicio -= Time.deltaTime;

		if (tempoInicio < 0)
		{
			rb.simulated = true;
		}
	}

	private void Impulsionar()
	{
		rb.velocity = Vector3.zero;
		rb.AddForce(Vector2.up*Forca, ForceMode2D.Impulse);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		
		controlador.GameOver();
	}


}
