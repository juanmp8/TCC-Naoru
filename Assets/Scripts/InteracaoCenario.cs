using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoCenario : MonoBehaviour
{
    [SerializeField] GameObject Animal;
    [SerializeField] GameObject Balao;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ativarAnim()
    {
        anim.SetTrigger("Interacao");
    }

    private void OnTriggerEnter2D(Collider2D eu)
    {
        if (eu.gameObject.CompareTag("Player"))
        {
            Balao.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D eu)
    {
        if (eu.gameObject.CompareTag("Player"))
        {
            Balao.SetActive(false);
        }

    }


}
