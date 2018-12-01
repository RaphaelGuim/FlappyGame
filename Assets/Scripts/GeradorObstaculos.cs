using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour {

	public GameObject obstaculo;
	[SerializeField]
	private float contadorTempo = 0;
	public float TempoGeracaoMaximo = 7;
	public float TempoGeracaoMinimo = 5;
	private ArrayList   obstaculos;
	private ControleDificuldade controleDificuldade;
	[SerializeField]
	private float max;
	[SerializeField]
	private float min;
	// Use this for initialization
	void Awake () {
		obstaculos = new ArrayList();
		controleDificuldade = GameObject.FindObjectOfType<ControleDificuldade>();


	}
	
	// Update is called once per frame
	void Update () {

		contadorTempo -= Time.deltaTime;
		 max = Mathf.Lerp(TempoGeracaoMaximo, 2, controleDificuldade.dificuldade);
		 min = Mathf.Lerp(TempoGeracaoMinimo, 0.5f, controleDificuldade.dificuldade);
		if (contadorTempo < 0)
		{
			GerarObstaculo();
			contadorTempo = Random.Range(min, max);
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
