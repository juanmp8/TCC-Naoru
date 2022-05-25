using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    [SerializeField] GameObject painel2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            painel2.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.CompareTag("Player"))
        {
            painel2.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.gameObject.CompareTag("Player"))
        {
            painel2.SetActive(false);
        }
    }
}
