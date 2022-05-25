using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scrConquistas : MonoBehaviour
{
    [SerializeField] GameObject Painel1;
    [SerializeField] GameObject Painel2;
    [SerializeField] GameObject Painel3;
    [SerializeField] GameObject Painel4;


    public void btn_Trofeu1()
    {
        Painel1.SetActive(true);
        Painel2.SetActive(false);
        Painel3.SetActive(false);
        Painel4.SetActive(false);
    }

    public void btn_Trofeu2()
    {
        Painel1.SetActive(false);
        Painel2.SetActive(true);
        Painel3.SetActive(false);
        Painel4.SetActive(false);
    }

    public void btn_Trofeu3()
    {
        Painel1.SetActive(false);
        Painel2.SetActive(false);
        Painel3.SetActive(true);
        Painel4.SetActive(false);
    }

    public void btn_Trofeu4()
    {
        Painel1.SetActive(false);
        Painel2.SetActive(false);
        Painel3.SetActive(false);
        Painel4.SetActive(true);
    }
}
