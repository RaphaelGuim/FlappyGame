using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaFundo : ControlaCenario {


	protected override void Mover()
	{
		gameObject.transform.Translate(Vector3.left * controlador.VelocidadeFundo*Time.deltaTime);
	}
}
