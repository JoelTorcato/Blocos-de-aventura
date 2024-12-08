using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Comandos de carregamento de fase

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Game over!"); // Envia uma mensagem para o console
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recarrega a cena atual no Unity
    }
}
