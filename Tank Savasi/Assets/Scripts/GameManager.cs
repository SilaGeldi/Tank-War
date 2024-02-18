using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver,heart0, heart1, heart2, heart3;
    public GameObject winGame, enemy0, enemy1, enemy2, enemy3, enemy4,enemy5;
    public static int health,enemies;
   
    // Start is called before the first frame update
    void Start()
    {
;       health = 3;
        heart0.gameObject.SetActive(true);
        heart1.gameObject.SetActive(true); 
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);

        enemies = 5;
        enemy0.gameObject.SetActive(true);
        enemy1.gameObject.SetActive(true); 
        enemy2.gameObject.SetActive(true);
        enemy3.gameObject.SetActive(true);
        enemy4.gameObject.SetActive(true);
        enemy5.gameObject.SetActive(true);
        winGame.gameObject.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
       
   
        switch (health )
        {
            case 3:
       
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
               
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                PauseGame();
                gameOver.gameObject.SetActive(true);
                
                break;

                
        }

        switch(enemies )
        {
            case 5:
                enemy0.gameObject.SetActive(true);
                enemy1.gameObject.SetActive(true);
                enemy2.gameObject.SetActive(true);
                enemy3.gameObject.SetActive(true);
                enemy4.gameObject.SetActive(true);
                enemy5.gameObject.SetActive(true);
                break;
            case 4:
                enemy0.gameObject.SetActive(true);
                enemy1.gameObject.SetActive(false);
                enemy2.gameObject.SetActive(true);
                enemy3.gameObject.SetActive(true);
                enemy4.gameObject.SetActive(true);
                enemy5.gameObject.SetActive(true);
                break;
            case 3:
                enemy0.gameObject.SetActive(true);
                enemy1.gameObject.SetActive(false);
                enemy2.gameObject.SetActive(false);
                enemy3.gameObject.SetActive(true);
                enemy4.gameObject.SetActive(true);
                enemy5.gameObject.SetActive(true);
                break;
            case 2:
                enemy0.gameObject.SetActive(true);
                enemy1.gameObject.SetActive(false);
                enemy2.gameObject.SetActive(false);
                enemy3.gameObject.SetActive(false);
                enemy4.gameObject.SetActive(true);
                enemy5.gameObject.SetActive(true);
                break;
            case 1:
                enemy0.gameObject.SetActive(true);
                enemy1.gameObject.SetActive(false);
                enemy2.gameObject.SetActive(false);
                enemy3.gameObject.SetActive(false);
                enemy4.gameObject.SetActive(false);
                enemy5.gameObject.SetActive(true);
                break;
            case 0:
                enemy0.gameObject.SetActive(true);
                enemy1.gameObject.SetActive(false);
                enemy2.gameObject.SetActive(false);
                enemy3.gameObject.SetActive(false);
                enemy4.gameObject.SetActive(false);
                enemy5.gameObject.SetActive(false);
                PauseGame();
                winGame.gameObject.SetActive(true);

                break;
        }
    }
    
    public void WinGame()
    {
        winGame.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    
}
