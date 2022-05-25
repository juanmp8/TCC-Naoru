using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scrPause : MonoBehaviour
{
    public GameObject PauseMenu;
    public string cena;

    public void pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(cena);
    }
}
