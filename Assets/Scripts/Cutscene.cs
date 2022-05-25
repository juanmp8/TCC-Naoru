using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    [SerializeField] GameObject cutscene;
    private void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.CompareTag("Player"))
        {
            cutscene.SetActive(true);
        }
    }
}
