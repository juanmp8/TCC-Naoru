using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TempoCena : MonoBehaviour
{
    [SerializeField] string cena;
   

    private void Start()
    {
        Invoke("chamarCena", 4f);
    }

    public void chamarCena()
    {
        
        SceneManager.LoadScene(cena);
    }



}
