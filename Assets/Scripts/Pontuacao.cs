using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {

	[SerializeField]
	private Text textoPontos;
	private int pontos = 0;
	private AudioSource audioPontuacao;

	private void Awake()
	{
		this.audioPontuacao = GetComponent<AudioSource>();
	}

	public void AdicionarPontos()
	{
		this.pontos++;
		AtualizarPontos();
		this.audioPontuacao.Play();
	}

	public void Reiniciar()
	{
		this.pontos = 0;
		AtualizarPontos();
	}


	private void AtualizarPontos()
	{

		this.textoPontos.text = this.pontos.ToString();
	}
}
