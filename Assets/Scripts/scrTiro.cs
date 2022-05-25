using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrTiro : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D eu)
    {
        if (eu.gameObject.CompareTag("Player"))
        {
            
            player.GetComponent<scrPlayer>().VidaP = player.GetComponent<scrPlayer>().VidaP - 1;
           
        }
    }
    
   
}
