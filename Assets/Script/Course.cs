using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course : MonoBehaviour
{
    public Transform[] points; // array com os pontos a serem percorridos
    public float speed = 1.0f; // velocidade da movimentação
    public Color passedColor; // cor dos pontos após a ultrapassagem
    private int currentPointIndex = 0; // índice do ponto atual
    private bool forward = true; // direção da movimentação

    void Update()
    {
        // calcula a direção da movimentação
        Vector3 direction = points[currentPointIndex].position - transform.position;
        direction.Normalize();

        // move o objeto na direção do ponto atual
        transform.position += direction * speed * Time.deltaTime;

        // verifica se o objeto ultrapassou o ponto atual
        float distance = Vector3.Distance(transform.position, points[currentPointIndex].position);
        if (distance < 0.1f)
        {
            // muda a cor do ponto atual após a ultrapassagem
            points[currentPointIndex].GetComponent<Renderer>().material.color = passedColor;

            // move para o próximo ponto ou para o ponto anterior
            if (forward)
            {
                currentPointIndex++;
                if (currentPointIndex >= points.Length)
                {
                    // caso tenha chegado ao último ponto, volta para o penúltimo e para a movimentação
                    currentPointIndex = points.Length - 2;
                    forward = false;
                }


            }
        }

    }
}

