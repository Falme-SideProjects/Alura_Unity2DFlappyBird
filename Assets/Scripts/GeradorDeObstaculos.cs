using UnityEngine;
using System.Collections;

public class GeradorDeObstaculos : MonoBehaviour
{
	[SerializeField]
	private float tempoParaGerarFacil;
	[SerializeField]
	private float tempoParaGerarDificil;

	private float cronometro;
	[SerializeField]
	private GameObject obstaculos;
	private ControleDeDificuldade controleDeDificuldade;


	// Use this for initialization
	void Awake()
	{
		cronometro = tempoParaGerarFacil;
	}

	private void Start()
	{
		controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
	}

	// Update is called once per frame
	void Update()
	{
		cronometro -= Time.deltaTime;
		if(cronometro <= 0)
		{
			Instantiate(obstaculos, transform.position, Quaternion.identity);
			cronometro = Mathf.Lerp(this.tempoParaGerarFacil, this.tempoParaGerarDificil, this.controleDeDificuldade.Dificuldade);
		}
	}
}
