using System.Collections;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    Vector2 direction;

    void Start()
    {
        StartCoroutine(InitialMove());
    }

    IEnumerator InitialMove()
    {
        yield return new WaitForSeconds(2);
        RandomDirection();
    }

    void RandomDirection()
    {
        transform.position = Vector2.zero;

        int dirX = Random.Range(-1, 2);
        int dirY = Random.Range(-1, 2);

        if (dirX == 0 || dirY == 0)
        {
            RandomDirection();
        }
        else
        {
            direction = new Vector2(dirX, dirY);

            Move();
        }
    }

    void Move()
    {
        GetComponent<Rigidbody2D>().velocity = direction.normalized * speed;
    }

    void OnBecameInvisible()
    {
        StartCoroutine(InitialMove());
    }
}
