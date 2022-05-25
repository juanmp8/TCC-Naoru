using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrManager : MonoBehaviour
{
    public GameObject saida;
    public GameObject saida2;
    public GameObject[] inimigos;
    public int qntinimigos;

    private void Start()
    {
        qntinimigos = inimigos.Length;
    }
    public void inimigomorto()
    {
        qntinimigos--;
    }
    private void FixedUpdate()
    {
        if (qntinimigos <= 0)
        {
            saida.SetActive(true);
            saida2.SetActive(true);
        }
    }
}
