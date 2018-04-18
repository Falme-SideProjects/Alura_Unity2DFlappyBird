using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour
{
	[SerializeField]
	private float velocidade = 0.5f;
	[SerializeField]
	private float variacaoDaPosicaoY;

	// Update is called once per frame

	private void Awake()
	{
		transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
	}

	private void Update()
	{
		transform.Translate(Vector3.left * this.velocidade);
	}

	private void OnTriggerEnter2D(Collider2D outro)
	{
		this.Destruir();
	}

	private void Destruir()
	{
		Destroy(this.gameObject);
	}
}
