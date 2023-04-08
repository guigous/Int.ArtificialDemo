using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public float attackDistance = 2f;
    public float attackDamage = 10f;
    public float health = 50;
    public float explosionForce = 100f;

    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.LookAt(playerTransform.position);
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, playerTransform.position) < attackDistance)
        {
            Attack();
        }
    }

    void Attack()
    {
        Debug.Log("Enemy attacked player!");
        // Implemente a lógica de ataque aqui
    }

    public void TakeDamage(int damage, Vector3 hitDirection)
    {
        health -= damage;
        if (health <= 0)
        {
            Die(hitDirection);
        }
    }

    private void Die(Vector3 hitDirection)
    {
        // Aplica a força de explosão
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(hitDirection * explosionForce, ForceMode.Impulse);

        // Remove o inimigo depois de 1 segundo
        Destroy(gameObject, 1f);
    }
}



