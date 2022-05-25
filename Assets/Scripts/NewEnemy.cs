using UnityEngine;

public class NewEnemy : MonoBehaviour
{
    public float speed;
    public float checkRadius;
    public float ataqueRaio;

    public bool shouldRotate;

    public LayerMask LayerPlayer;

    private Transform target;
    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 movimento;
    public Vector3 direcao;
    public Vector3 direcaoPatrulha;
    private Vector2 movimentoPatrulha;
    AudioSource gun;
    [SerializeField] bool taNoRangePerseguicao = false;
    [SerializeField] bool taNoRangeAtaque = false;

    public int Vida = 2;
   

    [SerializeField] GameObject inimigo;
    [SerializeField] Transform[] pontos;
    [SerializeField] int indicepontos = 1;
    [SerializeField] Transform Destino;
    [SerializeField] GameObject player;
    [SerializeField] bool tanoArbusto = false;
    [SerializeField] GameObject sceneManager;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;
        Destino = pontos[indicepontos];
        gun = GetComponent<AudioSource>();
    }

    private void Update()
    {
        anim.SetBool("Andando", taNoRangePerseguicao);
        if (tanoArbusto)
        {
            taNoRangeAtaque = false;
            taNoRangePerseguicao = false;
        }
        if (taNoRangeAtaque || taNoRangePerseguicao)
        {
            if (tanoArbusto == false)
            {
                direcao = target.position - transform.position;
                float angle = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg;
                direcao.Normalize();
                movimento = direcao;
                if (shouldRotate)
                {
                    anim.SetFloat("X", direcao.x);
                    anim.SetFloat("Y", direcao.y);
                }
            }
           
        }
        else
        {
            inimigo.transform.position = Vector2.MoveTowards(inimigo.transform.position, Destino.position, speed * Time.deltaTime);
           
                anim.SetFloat("X", direcaoPatrulha.x);
                anim.SetFloat("Y", direcaoPatrulha.y);
        }

        if (inimigo.transform.position == Destino.position)
        {
            indicepontos++;
            direcaoPatrulha = direcaoPatrulha * -1;

            if (indicepontos == pontos.Length)
            {
                indicepontos = 0;
            }

            Destino = pontos[indicepontos];
        }

        if (Vida <= 0)
        {
            anim.SetBool("Morreu", true);
            Invoke("morte", 0.5f);
        }

        

    }

    private void FixedUpdate()
    {
        if (taNoRangePerseguicao && !taNoRangeAtaque)
        {
            MoveCharacter(movimento);
        }
      

        if (taNoRangeAtaque)
        {
            anim.SetTrigger("Atirar");
            rb.velocity = Vector2.zero;
            gun.Play();
        }

    }

    private void MoveCharacter(Vector2 direcao)
    {
        rb.MovePosition((Vector2)transform.position + (direcao * speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D eu)
    {
        if (eu.gameObject.CompareTag("Player"))
        {
            taNoRangePerseguicao = true;
            taNoRangeAtaque = true;
            


        }
       
    }
    private void OnTriggerExit2D(Collider2D eu)
    {
        if (eu.gameObject.CompareTag("Player"))
        {
            taNoRangePerseguicao = true;
            taNoRangeAtaque = false;


        }

    }

    public void stopEnemy()
    {
        taNoRangeAtaque = false;
        taNoRangePerseguicao = false;
        tanoArbusto = true;
    }
    public void ExitBush()
    {
        tanoArbusto = false;
    }
    public void morte()
    {
        sceneManager.GetComponent<scrManager>().inimigomorto();
        Destroy(gameObject);
    }

   
}


