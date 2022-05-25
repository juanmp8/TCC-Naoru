using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrMenu : MonoBehaviour
{

    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject Video;

    private void Start()
    {
        Invoke("CarregarMenu", 16f);
    }
    public void CarregarCena(string Cena)
    {
        SceneManager.LoadScene(Cena);
    }

    public void CarregarMenu()
    {
        Menu.SetActive(true);
        Canvas.SetActive(true);
        Destroy(Video);
    }

}
