using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool isAlive = true;
    public GameManager gameManager;
    public GameObject bloodEffect;
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator anim;
    public static bool isEnter = false;

    // Mobile Key Value //
    int up_Value;
    int down_Value;
    int left_Value;
    int right_Value;
    bool up_down;
    bool down_down;
    bool left_down;
    bool right_down;
    bool up_Up;
    bool down_Up;
    bool left_Up;
    bool right_Up;



    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //PC
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (GameManager.isMobile == true)
        {
            movement.x = right_Value + left_Value;
            movement.y = up_Value + down_Value;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameManager.pause();
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enter"))
        {
            isEnter = true;
        }

        if (other.CompareTag("score enter"))
        {
            Score.score++;
        }
        if (other.CompareTag("monster") || other.CompareTag("enemy"))
        {
            isAlive = false;
            gameManager.gameOver();
            GameObject effect = Instantiate(bloodEffect, transform.position, Quaternion.identity);
            Time.timeScale = 0;
        }
    }

    public void ButtonDown(string type)
    {
        switch (type)
        {
            case "U":
                up_Value = 1;
                up_down = true;
                break;
            case "D":
                down_Value = -1;
                down_down = true;
                break;
            case "L":
                left_Value = -1;
                left_down = true;
                break;
            case "R":
                right_Value = 1;
                right_down = true;
                break;
        }
    }

    public void ButtonUp(string type)
    {
        switch (type)
        {
            case "U":
                up_Value = 0;
                up_Up = true;
                break;
            case "D":
                down_Value = 0;
                down_Up = true;
                break;
            case "L":
                left_Value = 0;
                left_Up = true;
                break;
            case "R":
                right_Value = 0;
                right_Up = true;
                break;
        }
    }
}