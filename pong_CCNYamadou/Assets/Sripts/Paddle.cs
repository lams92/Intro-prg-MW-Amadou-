using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rbPaddle;
    public bool isPlayer1;
    public float paddleSpeed = 0.05f;
    void Start()
    {
       //Debug.Log("Paddle Script ! Yay!") 
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
           
            Player1Control();
        } 
        else
        {
           
            Player2Control();
        }
 
    }
    void Player1Control()
    {
        //Debug.Log("is player 1")
        Vector3 newPos = transform.position;
       if (newPos.y <= 4.1f && newPos.y >= -4.1f)
        {
            //Player Movement controls 
            if (Input.GetKey(KeyCode.W))
            {
                //Debug.Log("W key pressed")
                newPos.y += paddleSpeed;

            }
            else if (Input.GetKey(KeyCode.S))
            {
                //Debug.Log("S key pressed")
                newPos.y -= paddleSpeed;
            }
            transform.position = newPos;

        }
        if (newPos.y >= 4.1f)
        {
            newPos.y = 4;
            transform.position = newPos;
        }
        else if (newPos.y<= - 4.1f)
        {
            newPos.y = -4; 
            transform.position = newPos;
        }

       

    } 


    void Player2Control()
    {
        //Debug.Log("is player 2")
        {
         
            Vector3 newPos = transform.position;
            if (newPos.y <= 4.1f && newPos.y >= -4.1f)
            {
                //Player Movement controls 
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    //Debug.Log("Up key pressed")
                    newPos.y += paddleSpeed;

                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    //Debug.Log("down key pressed")
                    newPos.y -= paddleSpeed;
                }
                transform.position = newPos;

            }
            if (newPos.y >= 4.1f)
            {
                newPos.y = 4;
                transform.position = newPos;
            }
            else if (newPos.y <= -4.1f)
            {
                newPos.y = -4;
                transform.position = newPos;
            }



        }
    }
}
