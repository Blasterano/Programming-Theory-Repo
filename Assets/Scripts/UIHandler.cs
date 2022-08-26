using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public TMP_InputField nameText;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void EnterName()
    {
        DataManager.instance.playerName = nameText.text;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
