using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCenarioMove : MonoBehaviour
{
  

    private Vector2 posicaoInicial;
    private float tamanhoRealDaImagem;

    private void Awake()
    {
        posicaoInicial = transform.position;
        float tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.y;
        float escala = this.transform.localScale.x;
        this.tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }
    void Update()
    {
        
        transform.position = posicaoInicial;
    }
}
