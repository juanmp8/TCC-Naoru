using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrTrocaFase : MonoBehaviour
{
    [SerializeField] string cena;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="Player")
        {
           SceneManager.LoadScene(cena);
        }
    }
    public void PulaScene()
    {
        SceneManager.LoadScene(cena);
    }


}
