using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject creditsScreen;
    
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    
    public void CreditsButton()
    {
        winScreen.SetActive(false);
        creditsScreen.SetActive(true);
    }

    public void BackButton()
    {
        winScreen.SetActive(true);
        creditsScreen.SetActive(false);
    }
}
