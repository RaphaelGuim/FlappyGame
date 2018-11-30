using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour {

	public GameObject obstaculo;
	[SerializeField]
	private float contadorTempo = 0;
	public float TempoGeracaoMaximo = 1;
	public float TempoGeracaoMinimo = 2;
	private ArrayList   obstaculos;
	// Use this for initialization
	void Awake () {
		obstaculos = new ArrayList();
		 
		
	}
	
	// Update is called once per frame
	void Update () {

		contadorTempo -= Time.deltaTime;
		if (contadorTempo < 0)
		{
			GerarObstaculo();
			contadorTempo = Random.Range(TempoGeracaoMinimo, TempoGeracaoMaximo);
		}
	}

	private  void GerarObstaculo()
	{
		GameObject obj = BuscaInativo();

		obj.transform.position = new Vector3(transform.position.x, Random.Range(-1.4f, 1.4f), 0);
		obj.SetActive(true);
		obj.GetComponent<ControlaObstaculo>().pontuou = false;


	}

	private GameObject BuscaInativo()
	{
		for (int i = 0; i < obstaculos.Count; i++)
		{
			GameObject obj = obstaculos[i] as GameObject;

			if (!obj.activeSelf)
			{
				return obj;
			}
		}
		return CriarNovoObstaculoNalista();
	}

	private GameObject CriarNovoObstaculoNalista()
	{
		GameObject obj = Instantiate(obstaculo);
		obj.SetActive(false);
		obstaculos.Add(obj);
		return obj;
	}
}
