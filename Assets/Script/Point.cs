using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    
    public float radius = 2.0f; // raio do movimento circular
    public float speed = 1.0f; // velocidade da movimenta��o
    private float angle = 0.0f; // �ngulo atual da movimenta��o

    void Update()
    {
        // calcula a posi��o X e Y do objeto usando a fun��o Mathf.Sin e Mathf.Cos
        float x = radius * Mathf.Cos(angle);
        float z = radius * Mathf.Sin(angle);

        // move o objeto para a nova posi��o
        transform.position = new Vector3(x, transform.position.y, z);

        // incrementa o �ngulo para continuar o movimento circular
        angle += speed * Time.deltaTime;
    }
}
    

