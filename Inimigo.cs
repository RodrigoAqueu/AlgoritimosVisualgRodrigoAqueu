using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocidade;
    public bool direita;
    public SpriteRenderer inverteSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimentaInimigo();
    }
    public void movimentaInimigo()
    {
        if (direita == true)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            inverteSprite.flipX = true;
        }
        else
        {
            transform.Translate(Vector2.left * velocidade * Time.deltaTime);
            inverteSprite.flipX = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sentido"))
        {
            direita = !direita;
        }
    }


}
