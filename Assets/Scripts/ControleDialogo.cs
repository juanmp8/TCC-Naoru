using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDialogo : MonoBehaviour
{

    [Header("Componentes")]
    public GameObject dialogueObj;
    public Image profile;
    public Text speechText;
    public Text actorNameText;

    [Header("Configurações")]
    public float typingSpeed;
    private string[] sentences;
    public int index;

    [SerializeField] GameObject cutscene;
    [SerializeField] GameObject cutscene2;
    [SerializeField] GameObject painel;

    [SerializeField] GameObject Naoruimg;
    [SerializeField] GameObject Tioimg;
    [SerializeField] GameObject tiotxt;
    [SerializeField] GameObject naorutxt;

    [SerializeField] GameObject Tio;
    [SerializeField] GameObject Pai;
    [SerializeField] GameObject Prisioneiro;


    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
            proximaFrase();
       }

        if (Tio)
        {
            Trocarfoto();
            TrocarfotoT();

        }

        if (Pai)
        {
            TrocarFotoNauP();
            TrocarFotoPai();
        }

        if (Prisioneiro)
        {
            NaoruFtPrisioneiro();
            TrocarFotoPrisioneiro();
        }
        
        if (cutscene)
        {
            chamar1();
        }

        if (cutscene2)
        {
            chamar2();
        }
    }
    public void Speech(Sprite p, string[] txt, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        sentences = txt;
        actorNameText.text = actorName;
        StartCoroutine(TypeSentences());
    }

    IEnumerator TypeSentences()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }

    public void proximaFrase()
    {
        if (speechText.text == sentences[index])
        {
            if (index < sentences.Length - 1)
            {
                index++;
                speechText.text = "";
                StartCoroutine(TypeSentences());
            }
            else
            {
                speechText.text = "";
                index = 0;
                dialogueObj.SetActive(false);
            }
        }
    }

    public void chamar1()
    {
        if (index == 15)
        {
            painel.SetActive(false);
            cutscene.SetActive(true);
        }
    }

    public void chamar2()
    {
        if (index == 9)
        {
            painel.SetActive(false);
            cutscene2.SetActive(true);
        }
    }

    public void Trocarfoto()
    {
        if (index == 1 || index == 3 || index == 5 || index == 6 || index == 8 || index == 9 || index == 12)
        {
            Naoruimg.SetActive(true);
            Tioimg.SetActive(false);
            naorutxt.SetActive(true);
            tiotxt.SetActive(false);
        }
    }

    public void TrocarfotoT()
    {
        if (index == 0 || index == 2 || index == 4 || index == 7 || index == 10 || index == 11 || index == 13 || index == 14)
        {
            Naoruimg.SetActive(false);
            Tioimg.SetActive(true);
            naorutxt.SetActive(false);
            tiotxt.SetActive(true);
        }
    }

    public void TrocarFotoNauP()
    {
        if (index == 1 || index == 5 || index == 6 || index == 8)
        {
            Naoruimg.SetActive(true);
            Tioimg.SetActive(false);
            naorutxt.SetActive(true);
            tiotxt.SetActive(false);
        }
    }
    public void TrocarFotoPai()
    {
        if (index == 0 || index == 2 || index == 3 || index == 4 || index == 7 )
        {
            Naoruimg.SetActive(false);
            Tioimg.SetActive(true);
            naorutxt.SetActive(false);
            tiotxt.SetActive(true);
        }
    }

    public void TrocarFotoPrisioneiro()
    {
        if (index == 2)
        {
            Naoruimg.SetActive(false);
            Tioimg.SetActive(true);
            naorutxt.SetActive(false);
            tiotxt.SetActive(true);
        }
    }

    public void NaoruFtPrisioneiro()
    {
        if (index == 0 || index == 1)
        {
            Naoruimg.SetActive(true);
            Tioimg.SetActive(false);
            naorutxt.SetActive(true);
            tiotxt.SetActive(false);
        }
    }


}
