using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayer1Goal;
    public GameManager myManager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OntriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            //Debug.Log("ball in trigger")
            if (!isPlayer1Goal)
            {
                myManager.Player2Scrored();

            }
            else
            {
                myManager.Player1Srored();
            }
        }
    }
}
