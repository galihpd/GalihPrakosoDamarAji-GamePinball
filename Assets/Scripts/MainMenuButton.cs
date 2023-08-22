using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    // Update is called once per frame
    public void MulaiGame()
    {
        SceneManager.LoadScene("GamePinball-Main"); // Replace "MainMenu" with the actual scene name   
    }
}
