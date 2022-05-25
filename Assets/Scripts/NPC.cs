using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    bool proximo = false;
    Animator anim;
    [SerializeField] GameObject canvas;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        anim.SetBool("Proximo", proximo);
    }

   
    private void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.CompareTag("Player"))
        {
            proximo = true;
            anim.SetBool("Proximo", proximo);
            canvas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.gameObject.CompareTag("Player"))
        {
            proximo = false;
            anim.SetBool("proximo", proximo);
            canvas.SetActive(false);
        }
    }

}
