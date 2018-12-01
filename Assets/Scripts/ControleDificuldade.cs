using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDificuldade : MonoBehaviour {

	public float TempoDificuldadeMaxima;
	private float contadorTempo;	 
	public float dificuldade;
	// Use this for initialization
	void Start () {
		contadorTempo = 0;
		dificuldade = 0;
	}
	
	// Update is called once per frame
	void Update () {
		contadorTempo += Time.deltaTime;
		dificuldade = contadorTempo / TempoDificuldadeMaxima;
		dificuldade = Mathf.Min(1, dificuldade);


	}
}
