using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour
{
	[SerializeField]
	private VariavelCompartilhadaFloat velocidade;
	[SerializeField]
	private float variacaoDaPosicaoY;
	private Vector3 posicaoDoAviao;
	private Pontuacao pontuacao;
	private bool pontuou = false;

	// Update is called once per frame

	private void Awake()
	{
		transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
	}

	private void Start()
	{
		this.posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
		this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
	}

	private void Update()
	{
		transform.Translate(Vector3.left * this.velocidade.valor * Time.deltaTime);

		if(!this.pontuou && this.transform.position.x < this.posicaoDoAviao.x)
		{
			this.pontuou = true;
			this.pontuacao.AdicionarPontos();
			
		}
	}

	private void OnTriggerEnter2D(Collider2D outro)
	{
		this.Destruir();
	}

	public void Destruir()
	{
		Destroy(this.gameObject);
	}
}
