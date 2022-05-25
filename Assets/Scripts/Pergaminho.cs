using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pergaminho : MonoBehaviour
{
    [SerializeField] GameObject pergaminho;
    [SerializeField] GameObject pergaminhodirecao;
    private bool taemcontato;

    private void Update()
    {
        if ( taemcontato && Input.GetKeyDown(KeyCode.E))
        {
            pergaminho.SetActive(false);
            pergaminhodirecao.SetActive(true);
            Invoke("tirarPergaminho", 3f);
        }
    }

    private void OnTriggerEnter2D(Collider2D eu)
    {
        if (eu.gameObject.CompareTag("Player"))
        {

            taemcontato = true;

        }
    }

    private void tirarPergaminho()
    {
        pergaminhodirecao.SetActive(false);
    }
    private void OnCollisionExit2D(Collision2D eu)
    {
        if (eu.gameObject.CompareTag("Player"))
        {

            taemcontato = false;

        }
    }
}
