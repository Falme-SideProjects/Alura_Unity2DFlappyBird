using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour {

	private Aviao aviao;
	private Pontuacao pontuacao;
	private MaoPiscando maoPiscando;
	private InterfaceGameOver interfaceGameOver;
	private ControleDeDificuldade controleDeDificuldade;

	private void Start()
	{
		this.aviao = GameObject.FindObjectOfType<Aviao>();
		this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
		this.maoPiscando = GameObject.FindObjectOfType<MaoPiscando>();
		this.interfaceGameOver = GameObject.FindObjectOfType<InterfaceGameOver>();
		this.controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
	}

	public void FinalizaJogo()
	{
		Time.timeScale = 0;
		this.pontuacao.SalvarPontuacao();
		this.interfaceGameOver.MostrarInterface();
	}

	public void ReiniciarJogo()
	{
		Time.timeScale = 1;

		this.interfaceGameOver.EsconderInterface();
		this.aviao.Reiniciar();
		this.destruirObstaculos();
		this.pontuacao.Reiniciar();
		this.maoPiscando.Reiniciar();
		this.controleDeDificuldade.Reiniciar();
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
