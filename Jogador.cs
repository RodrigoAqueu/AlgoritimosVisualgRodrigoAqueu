using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade;
    public Rigidbody2D corpoJogador;
    public SpriteRenderer inverteSprite;
    public bool tocaChao;
    public Transform verificaChao;
    public float raioVerifica;
    public LayerMask layerChao;
    public float pulo;
    public AudioSource somPulo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            puloJogador ();
        }
    }
    void FixedUpdate()
    {
        movimentoJogador();
    }

    public void movimentoJogador()
    {
        float inputEixos = Input.GetAxisRaw("Horizontal");

        corpoJogador.velocity = new Vector2(inputEixos * velocidade, corpoJogador.velocity.y);

        if (inputEixos > 0)
        {
            inverteSprite.flipX = false;
        }

        if (inputEixos < 0)
        {
            inverteSprite.flipX = true;
        }

    }

    public void puloJogador()
    {
        corpoJogador.velocity = Vector2.up * pulo;
        tocaChao = Physics2D.OverlapCircle(verificaChao.position, raioVerifica, layerChao);

        if (Input.GetKey(KeyCode.Space) && tocaChao == true)
        {
            somPulo.Play();

            corpoJogador.velocity += Vector2.up * pulo;
        }
    }

}
