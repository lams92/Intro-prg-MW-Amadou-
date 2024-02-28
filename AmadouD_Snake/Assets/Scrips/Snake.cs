using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 dir = Vector3.right;
    

    void Start()
    {
        InvokeRepeating("MoveSnake", 0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDirection();
    }
    void MoveSnake()
    {
        transform.Translate(dir);
    }
    private void ChangeDirection()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            dir = Vector3.right;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            dir = Vector3.down;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            dir = Vector3.up;
        }
   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            //Debug.Log("food eaten");
            Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.tag == "Walls")
        {
            
        }



    }
}
