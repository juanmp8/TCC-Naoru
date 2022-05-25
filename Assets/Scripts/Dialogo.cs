using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;

    private ControleDialogo dc;

    public LayerMask playerLayer;
    public float radious;

    bool onradius;
    [SerializeField] GameObject balao;
    [SerializeField] GameObject player;
    private int numberclick = 1;

    private void Start()
    {
        dc = FindObjectOfType<ControleDialogo>();
    }

    private void FixedUpdate()
    {
        Interact();
    }

    private void Update()
    {
        if (onradius && Input.GetKeyDown(KeyCode.E) && numberclick == 1)
        {
            numberclick--;
            player.GetComponent<scrPlayer>().PararPlayer();
            dc.Speech(profile, speechTxt, actorName);
        }

        if (onradius)
        {
            balao.SetActive(true);
        }
        else
        {
            balao.SetActive(false);
        }
    }

    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);

        if (hit != null)
        {
            onradius = true;
        }
        else
        {
            onradius = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, radious);
    }
}
