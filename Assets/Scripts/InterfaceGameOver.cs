using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour {

	[SerializeField]
	private GameObject imagemGameOver;
	[SerializeField]
	private Image imagemMedalha;
	[SerializeField]
	private Sprite medalhaBronze, medalhaPrata, medalhaOuro;
	[SerializeField]
	private Text textoRecorde;
	private int recorde;
	private Pontuacao pontuacao;

	private void Start()
	{
		this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
	}
	public void MostrarInterface()
	{
		this.AtualizaInterfaceGrafica();
		imagemGameOver.SetActive(true);
	}

	public void EsconderInterface()
	{
		imagemGameOver.SetActive(false);

	}

	public void AtualizaInterfaceGrafica()
	{
		recorde = PlayerPrefs.GetInt("recorde");
		textoRecorde.text = recorde.ToString();

		this.AtualizaMedalhas();
	}

	private void AtualizaMedalhas()
	{
		if(this.pontuacao.pontos > this.recorde - 2)
		{
			imagemMedalha.sprite = medalhaOuro;
		}
		else if(this.pontuacao.pontos > this.recorde / 2)
		{
			imagemMedalha.sprite = medalhaPrata;
		}
		else
		{
			imagemMedalha.sprite = medalhaBronze;
		}
	}
}
