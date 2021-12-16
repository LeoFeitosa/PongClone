using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersInputController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    public enum Player
    {
        Player1, Player2
    };
    public Player playerType;

    void Update()
    {
        if (Player.Player1 == playerType)
        {
            InputPlayer1();
        }
        else
        {
            InputPlayer2();
        }
    }

    public void InputPlayer1()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Direction(1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Direction(-1);
        }
    }

    void InputPlayer2()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Direction(1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Direction(-1);
        }
    }

    void Direction(int vertical)
    {
        transform.Translate((Vector2.up * vertical) * Time.deltaTime * speed);
    }
}
