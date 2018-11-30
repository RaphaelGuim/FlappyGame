using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaChao : ControlaCenario
{
	protected override void Mover()
	{
		gameObject.transform.Translate(Vector3.left * controlador.VelocidadeObstatulos*Time.deltaTime);
	}
}
