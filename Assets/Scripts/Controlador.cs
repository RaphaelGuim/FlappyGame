using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour {

	public float VelocidadeObstatulos = 0.07f;
	public float VelocidadeFundo = 0.07f / 5;
	public int Pontuacao = 0;
	public Text text;
	public GameObject gameOver;
	public GameObject gameOverTexto;
	public float acrescimoVelocidade =  0.01f;
	public Text aviso;
	public bool fim = false;
	public AudioSource audioPonto;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pontuar()
	{
		Pontuacao++;
		text.text = Pontuacao.ToString();		 
		audioPonto.Play();
	}

	public void GameOver()
	{
		 
		gameOver.SetActive(true);
		gameOverTexto.SetActive(true);
		Time.timeScale = 0;
	}

	public void Reiniciar()
	{
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
		Time.timeScale = 1;
	}
}
