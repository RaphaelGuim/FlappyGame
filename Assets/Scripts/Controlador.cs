using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour {

	public float VelocidadeObstatulos = 0.07f;
	public float VelocidadeFundo = 0.07f / 5;
	private int Pontuacao = 0;
	public Text text;
	public GameObject gameOver;
	public GameObject gameOverTexto;
	public float acrescimoVelocidade =  0.01f;
	public Text aviso;
	public bool fim = false;
	public AudioSource audioPonto;
	public Text TextoPontos;
	private int recorde;
	[SerializeField]
	private Image medalha;
	[SerializeField]
	private Sprite medalhaOuro;
	[SerializeField]
	private Sprite medalhaPrata;
	[SerializeField]
	private Sprite medalhaBronze;


	// Use this for initialization
	void Start () {
		recorde = PlayerPrefs.GetInt("recorde");
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
		Medalhas();
		SalvarPontuacao();
		Time.timeScale = 0;
	}

	public void Reiniciar()
	{
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);		
		Time.timeScale = 1;
		
	}

	public void SalvarPontuacao()
	{
		 

		if ( recorde < Pontuacao)
		{
			PlayerPrefs.SetInt("recorde", Pontuacao);
		}

		TextoPontos.text = PlayerPrefs.GetInt("recorde").ToString();
		 
		
	}
	private void Medalhas()
	{
		if(Pontuacao > recorde){
			medalha.sprite = medalhaOuro;

		}
		else if (Pontuacao >= recorde/2)
		{
			medalha.sprite = medalhaPrata;
		}
		else
		{
			medalha.sprite = medalhaBronze;
		}
	}
}
