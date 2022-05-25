using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaiNaoru : MonoBehaviour
{

    [SerializeField] GameObject cutscene;

    private void Start()
    {
        cutscene.SetActive(true);
    }
    //bool proximo = false;
    //Animator anim;
    //[SerializeField] GameObject canvas;
    //[SerializeField] GameObject[] text;
    //int n = 0;

    //private void Start()
    //{
    //    anim = GetComponent<Animator>();
    //}
    //void Update()
    //{
    //    anim.SetBool("Proximo", proximo);
    //    if (proximo && Input.GetKeyDown(KeyCode.Space))
    //    {
    //        text[n].SetActive(false);
    //        n++;
    //        text[n].SetActive(true);
    //    }
    //}


    //private void OnTriggerEnter2D(Collider2D quem)
    //{
    //    if (quem.gameObject.CompareTag("Player"))
    //    {
    //        proximo = true;
    //        anim.SetBool("Proximo", proximo);
    //        canvas.SetActive(true);
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D quem)
    //{
    //    if (quem.gameObject.CompareTag("Player"))
    //    {
    //        proximo = false;
    //        anim.SetBool("proximo", proximo);
    //        canvas.SetActive(false);
    //    }
    //}
}
