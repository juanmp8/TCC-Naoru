using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class scrPlayer : MonoBehaviour
{
    
    private Rigidbody2D rbPlayer;
    Animator anim;
    float horizontalInput;
    float verticalInput;
    public float velocidade;
    
    private bool andando;

    private Vector3 moveDirecao;

    public GameObject presos;
    public int VidaP = 5;
    [SerializeField] GameObject painelint;
    [SerializeField] string cena;
    [SerializeField] GameObject Death;
    [SerializeField] GameObject inimigo;
    [SerializeField] GameObject inimigo1;
    [SerializeField] GameObject inimigo2;
    [SerializeField] GameObject inimigo3;
    [SerializeField] GameObject inimigo4;
    [SerializeField] GameObject inimigo5;
    [SerializeField] GameObject inimigo6;
    [SerializeField] GameObject inimigo7;
    [SerializeField] GameObject inimigo8;
    [SerializeField] GameObject interagir;
    [SerializeField] GameObject interagir2;
    AudioSource spear;
    bool podemover = true;
    bool taemcontato = false;
    bool taemcontato2 = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rbPlayer = GetComponent<Rigidbody2D>();
        spear = GetComponent<AudioSource>();
       
    }

    public void ataque()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            anim.SetTrigger("Ataque");
            spear.Play();
        }
       
    }
    
    public void interacao()
    {
        if (taemcontato == true && Input.GetKeyDown(KeyCode.E))
        {

            interagir.GetComponent<InteracaoCenario>().ativarAnim();
            


        }

    }
    public void tirar()
    {
        painelint.SetActive(false);
    }

    public void interacao2()
    {
        if (taemcontato2 == true && Input.GetKeyDown(KeyCode.E))
        {

           
            interagir2.GetComponent<InteracaoCenario>().ativarAnim();
            


        }

    }
    private void Update()
    {
        interacao();
        interacao2();
        


        if (podemover)
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
            verticalInput = Input.GetAxisRaw("Vertical");
        }
        

        if (horizontalInput != 0 || verticalInput!=0)
        {
            anim.SetFloat("Horizontal", horizontalInput);
            anim.SetFloat("Vertical", verticalInput);
            if (!andando)
            {
                andando = true;
                anim.SetBool("Andando", andando);
            }
        }
        else
        {
            if (andando)
            {
                andando = false;
                anim.SetBool("Andando", andando);
                StopMove();
            }
        }

        moveDirecao = new Vector3(horizontalInput, verticalInput).normalized;

        if (podemover)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                velocidade = velocidade + 40f;
                anim.SetTrigger("Correndo");
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                velocidade = velocidade - 40f;
                anim.SetTrigger("PararCorrer");
            }
        }
        


        ataque();

        if (VidaP <= 0)
        {
            Death.SetActive(true);
            gameObject.SetActive(false);
            Time.timeScale = 0f;
        }
    }

    private void StopMove()
    {
    
        rbPlayer.velocity = Vector3.zero;
    }

    public void PararPlayer()
    {
        podemover = false;
        rbPlayer.velocity = Vector2.zero;
        velocidade = 0f;

        anim.SetBool("Andando", false);
        anim.SetTrigger("PararCorrer");
    }



    private void FixedUpdate()
    {
        rbPlayer.velocity = moveDirecao * velocidade * Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.CompareTag("Presos"))
        {
            taemcontato = true;
        }

        if (quem.gameObject.CompareTag("Sapo"))
        {
            taemcontato2 = true;
        }

        if (quem.gameObject.CompareTag("Arara"))
        {
            taemcontato = true;
        }

        if (quem.gameObject.CompareTag("Tucano"))
        {
            taemcontato = true;
        }

        if (quem.gameObject.CompareTag("Enemy"))
        {
            inimigo.GetComponent<NewEnemy>().Vida = inimigo.GetComponent<NewEnemy>().Vida - 1;


        }
        if (quem.gameObject.CompareTag("Enemy1"))
        {

            inimigo1.GetComponent<NewEnemy>().Vida = inimigo1.GetComponent<NewEnemy>().Vida - 1;


        }
        if (quem.gameObject.CompareTag("Enemy2"))
        {

            inimigo2.GetComponent<NewEnemy>().Vida = inimigo2.GetComponent<NewEnemy>().Vida - 1;

        }
        if (quem.gameObject.CompareTag("Enemy3"))
        {

            inimigo3.GetComponent<NewEnemy>().Vida = inimigo3.GetComponent<NewEnemy>().Vida - 1;

        }
        if (quem.gameObject.CompareTag("Enemy4"))
        {

            inimigo4.GetComponent<NewEnemy>().Vida = inimigo4.GetComponent<NewEnemy>().Vida - 1;

        }
        if (quem.gameObject.CompareTag("Enemy5"))
        {

            inimigo5.GetComponent<NewEnemy>().Vida = inimigo5.GetComponent<NewEnemy>().Vida - 1;

        }
        if (quem.gameObject.CompareTag("Enemy6"))
        {

            inimigo6.GetComponent<NewEnemy>().Vida = inimigo6.GetComponent<NewEnemy>().Vida - 1;

        }
        if (quem.gameObject.CompareTag("Enemy7"))
        {

            inimigo7.GetComponent<NewEnemy>().Vida = inimigo7.GetComponent<NewEnemy>().Vida - 1;


        }
        if (quem.gameObject.CompareTag("Enemy8"))
        {

            inimigo8.GetComponent<NewEnemy>().Vida = inimigo8.GetComponent<NewEnemy>().Vida - 1;

        }

    }

    private void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.gameObject.CompareTag("Sapo"))
        {
            taemcontato2 = false;
        }

        if (quem.gameObject.CompareTag("Arara"))
        {
            taemcontato = false;
        }

        if (quem.gameObject.CompareTag("Tucano"))
        {
            taemcontato = false;
        }
    }

}
