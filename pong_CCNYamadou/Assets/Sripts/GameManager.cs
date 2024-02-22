using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI player1ScroreText;
    public TextMeshProUGUI player2ScroreText;
    private int player1Score=0;
    private int player2Score=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        palyer1ScroreText.text = "P1:" + player1Score;
        palyer2ScroreText.text = "P1:" + player2Score;

    }
    public void Player1Scrored()
    {
        player1Score++;
    }
    public void PlayerScrored() 
    { 
        player2Score++;
    }
    
    
}
