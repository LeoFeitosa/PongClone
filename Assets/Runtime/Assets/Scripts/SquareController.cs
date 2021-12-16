using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    Vector2 direction = Vector2.left;

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            direction *= -1;
        }
    }
}
