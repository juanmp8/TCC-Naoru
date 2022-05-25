using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrArbusto : MonoBehaviour
{
    [SerializeField] GameObject[] inimigos;  
    private void OnTriggerEnter2D(Collider2D who)
    {
        if (who.gameObject.CompareTag("Player"))
        {
            foreach (var inimigo in inimigos)
            {
                inimigo.GetComponent<NewEnemy>().stopEnemy();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D who)
    {

        if (who.gameObject.CompareTag("Player"))
        {
            foreach (var inimigo in inimigos)
            {
                inimigo.GetComponent<NewEnemy>().ExitBush();
            }
        }

    }   
}
  

