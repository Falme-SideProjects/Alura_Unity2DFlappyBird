using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour {

    private Rigidbody2D fisica;
	private Diretor diretor;

	[SerializeField]
	private float forca = 10f;
	private Vector3 posicaoInicial;

	private bool deveImpulsionar;

	private Animator anim;

    void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		posicaoInicial = this.transform.position;
	}

	private void Start()
	{
		this.diretor = GameObject.FindObjectOfType<Diretor>();
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
			this.deveImpulsionar = true;

		}

		anim.SetFloat("VelocidadeY", this.fisica.velocity.y);
	}

	private void FixedUpdate()
	{
		if(this.deveImpulsionar)
			this.impulsionar();
	}

	public void Reiniciar()
	{
		this.transform.position = this.posicaoInicial;
		this.fisica.simulated = true;
	}


	private void impulsionar()
    {
		this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
		this.deveImpulsionar = false;

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		this.fisica.simulated = false;
		this.diretor.FinalizaJogo();
	}
}
