using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAviao : MonoBehaviour {

	Controlador controlador;
	Rigidbody2D rb;
	public float Forca;
	private bool impulsione = false;
	private float tempoInicio = 2;
	private Animator animator;

	private void Start()
	{
		animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		rb.simulated = false;
		controlador = GameObject.FindObjectOfType<Controlador>();
	}
	 
	private void Update () {

		animator.SetFloat("VelocidadeY", rb.velocity.y);

		if (Input.GetButtonDown("Fire1"))
		{
			impulsione = true;
			rb.simulated = true;
		}
		 
		tempoInicio -= Time.deltaTime;

		if (tempoInicio < 0)
		{
			rb.simulated = true;
		}
	}
	private void FixedUpdate()
	{
		if (impulsione)
		{
			Impulsionar();
		}
	}

	private void Impulsionar()
	{
		if (impulsione)
		{
			rb.velocity = Vector3.zero;
			rb.AddForce(Vector2.up * Forca, ForceMode2D.Impulse);
			impulsione = false;
		}
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		
		controlador.GameOver();
	}


}
