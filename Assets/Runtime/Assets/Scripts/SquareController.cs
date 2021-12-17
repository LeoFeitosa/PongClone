using UnityEngine;

public class SquareController : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    Vector2 direction;

    void Start()
    {
        InitialMove();
    }

    void InitialMove()
    {
        transform.position = Vector2.zero;

        int dirX = Random.Range(-1, 2);
        int dirY = Random.Range(-1, 2);
        Debug.Log("dirX " + dirX);
        Debug.Log("dirY " + dirY);

        if (dirX == 0 || dirY == 0)
        {
            InitialMove();
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
        InitialMove();
    }
}
