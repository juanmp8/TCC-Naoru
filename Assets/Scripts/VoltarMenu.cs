using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VoltarMenu : MonoBehaviour
{
    public void CarregarCena(string Cena)
    {
        SceneManager.LoadScene(Cena);
        Time.timeScale = 1f;
    }
   
    public void Quitar()
    {
        Application.Quit();
    }
}
