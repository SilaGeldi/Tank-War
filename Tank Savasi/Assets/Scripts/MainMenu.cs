using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f; // Zaman ölçeðini normal hýzýna geri döndür
        SceneManager.LoadScene(SceneManager .GetActiveScene ().buildIndex );
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

    

}
