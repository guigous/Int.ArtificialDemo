using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course : MonoBehaviour
{
    public Transform[] points; // array com os pontos a serem percorridos
    public float speed = 1.0f; // velocidade da movimenta��o
    public Color passedColor; // cor dos pontos ap�s a ultrapassagem
    private int currentPointIndex = 0; // �ndice do ponto atual
    private bool forward = true; // dire��o da movimenta��o

    void Update()
    {
        // calcula a dire��o da movimenta��o
        Vector3 direction = points[currentPointIndex].position - transform.position;
        direction.Normalize();

        // move o objeto na dire��o do ponto atual
        transform.position += direction * speed * Time.deltaTime;

        // verifica se o objeto ultrapassou o ponto atual
        float distance = Vector3.Distance(transform.position, points[currentPointIndex].position);
        if (distance < 0.1f)
        {
            // muda a cor do ponto atual ap�s a ultrapassagem
            points[currentPointIndex].GetComponent<Renderer>().material.color = passedColor;

            // move para o pr�ximo ponto ou para o ponto anterior
            if (forward)
            {
                currentPointIndex++;
                if (currentPointIndex >= points.Length)
                {
                    // caso tenha chegado ao �ltimo ponto, volta para o pen�ltimo e para a movimenta��o
                    currentPointIndex = points.Length - 2;
                    forward = false;
                }


            }
        }

    }
}

