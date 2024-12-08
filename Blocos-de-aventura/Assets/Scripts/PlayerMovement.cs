using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidadeDaBola; // Define a velocidade da bola como um número decimal (float)
    public Rigidbody2D rb2D; // Referencia o componente Rigidbody2D (rb2D) para física no jogo 
    private Vector2 teclasApertadas; // Acessa os eixos X e Y
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The game started!"); // Exibe uma mensagem no console quando o jogo começa
    }

     private void movimentarBola() {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // Obtém a direção do movimento com base nas teclas pressionadas
        rb2D.velocity = teclasApertadas.normalized * velocidadeDaBola; // Define a velocidade do jogador com base na direção e velocidade especificadas
    }

    // Update is called once per frame
    void Update()
    {
        movimentarBola();
    }

}
