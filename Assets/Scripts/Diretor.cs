using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour {

	[SerializeField]
	private GameObject imagemGameOver;
	private Aviao aviao;
	private Pontuacao pontuacao;

	private void Start()
	{
		this.aviao = GameObject.FindObjectOfType<Aviao>();
		this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
	}

	public void FinalizaJogo()
	{
		Time.timeScale = 0;
		imagemGameOver.SetActive(true);
	}

	public void ReiniciarJogo()
	{
		Time.timeScale = 1;
		imagemGameOver.SetActive(false);
		this.aviao.Reiniciar();
		this.destruirObstaculos();
		this.pontuacao.Reiniciar();
	}

	private void destruirObstaculos()
	{
		Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
		foreach(Obstaculo obstaculo in obstaculos)
		{
			obstaculo.Destruir();
		}
	}
}
