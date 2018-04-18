using UnityEngine;
using System.Collections;

public class GeradorDeObstaculos : MonoBehaviour
{
	[SerializeField]
	private float tempoParaGerar;
	private float cronometro;
	[SerializeField]
	private GameObject obstaculos;


	// Use this for initialization
	void Awake()
	{
		cronometro = tempoParaGerar;
	}

	// Update is called once per frame
	void Update()
	{
		cronometro -= Time.deltaTime;
		if(cronometro <= 0)
		{
			Instantiate(obstaculos, transform.position, Quaternion.identity);
			cronometro = tempoParaGerar;
		}
	}
}
