using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeDificuldade : MonoBehaviour {

	[SerializeField]
	private float dificuldadeMaxima;
	private float tempoDeJogo;
	public float Dificuldade { get; private set; }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.tempoDeJogo += Time.deltaTime;
		this.Dificuldade = this.tempoDeJogo / dificuldadeMaxima;
		this.Dificuldade = Mathf.Min(1, this.Dificuldade);
		
	}

	public void Reiniciar()
	{
		this.tempoDeJogo = this.Dificuldade = 0;
	}
}
