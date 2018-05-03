using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoPiscando : MonoBehaviour {

	private SpriteRenderer imagem;

	private void Awake()
	{
		this.imagem = this.GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	private void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			this.desaparecer();
		}
	}

	private void desaparecer()
	{
		this.imagem.enabled = false;
	}

	public void Reiniciar()
	{
		this.imagem.enabled = true;
	}
}
