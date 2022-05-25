using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject painel;
   
    private void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.gameObject.CompareTag("Player"))
        {
            painel.SetActive(false);
        }
    }
}
