using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidadeDaBola; // Define a velocidade da bola como um número decimal
    public Rigidbody2D rb; // Referencia o componente Rigidbody2D para física no jogo
    private Vector2 teclasApertadas; // Acessa os eixos X e Y
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void movimentarBola() {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // Obtém a direção do movimento com base nas teclas pressionadas
    }
}
