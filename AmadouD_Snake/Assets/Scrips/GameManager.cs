using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI foodScroreText;
    public int foodScrore = 0; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foodScroreText.text = "Score: " + foodScrore; 
    }
    public void FoodEaten()
    {
        foodScrore++; 
    }
}
