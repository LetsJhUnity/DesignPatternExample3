using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Position
{ 
    UP,DOWN, LEFT, RIGHT
}

public class PlayerAnimeController : MonoBehaviour
{
    public float move_speed;
    Rigidbody2D rbody2D;
    Animator animator;

    public Sprite[] sprites_idle;
    public Position position;

    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        position = Position.DOWN;
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rbody2D.velocity = new Vector2(h * move_speed, v * move_speed);

        if (v == 1.0f)
        {
            animator.Play("moveU");
            position = Position.UP;
        }
        else if (v == -1.0f)
        {
            animator.Play("moveD");
            position = Position.DOWN;
        }
        else if (h == -1.0f)
        {
            animator.Play("moveL");
            position = Position.LEFT;
        }
        else if (h == 1.0f)
        {
            animator.Play("moveR");
            position = Position.RIGHT;
        }
        else
        {

            switch (position)
            {
                case Position.UP:
                    animator.Play("IdleU");
                    break;
                case Position.DOWN:
                    animator.Play("IdleD");
                    break;
                case Position.LEFT:
                    animator.Play("IdleL");
                    break;
                case Position.RIGHT:
                    animator.Play("IdleR");
                    break;
            }
        }
    }

}
