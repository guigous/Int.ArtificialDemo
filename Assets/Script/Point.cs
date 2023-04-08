using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    
    public float radius = 2.0f; // raio do movimento circular
    public float speed = 1.0f; // velocidade da movimentação
    private float angle = 0.0f; // ângulo atual da movimentação

    void Update()
    {
        // calcula a posição X e Y do objeto usando a função Mathf.Sin e Mathf.Cos
        float x = radius * Mathf.Cos(angle);
        float z = radius * Mathf.Sin(angle);

        // move o objeto para a nova posição
        transform.position = new Vector3(x, transform.position.y, z);

        // incrementa o ângulo para continuar o movimento circular
        angle += speed * Time.deltaTime;
    }
}
    

