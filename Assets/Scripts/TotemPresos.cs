using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotemPresos : MonoBehaviour
{
    [SerializeField] GameObject prisioneiro;
    [SerializeField] GameObject Balao;
    [SerializeField] GameObject final;
    public bool taemcontato;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (taemcontato == true && Input.GetKeyDown(KeyCode.E))
        {
            ativarAnim();
        }
    }
    public void ativarAnim()
    {
        anim.SetTrigger("Solto");
        final.SetActive(true);

    }

    private void OnTriggerEnter2D(Collider2D eu)
    {
        if (eu.gameObject.CompareTag("Player"))
        {
            Balao.SetActive(true);
            taemcontato = true;
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
