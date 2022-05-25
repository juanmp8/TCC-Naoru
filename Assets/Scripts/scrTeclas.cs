using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrTeclas : MonoBehaviour
{
    [SerializeField] GameObject Tecla;

    
 
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    

    private void PressW()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("WPressionada", true);
        }
    }

    private void LevW()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("WPressionada", false);
        }
    }

    private void PressA()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("APressionada", true);
        }
    }

    private void LevA()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("APressionada", false);
        }
    }

    private void PressS()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("SPressionada", true);
        }
    }

    private void LevS()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("SPressionada", false);
        }
    }

    private void PressD()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("DPressionada", true);
        }
    }

    private void LevD()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("DPressionada", false);
        }
    }

    private void PressUp()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("UpPressionada", true);
        }
    }

    private void LevUp()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetBool("UpPressionada", false);
        }
    }

    private void PressDown()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("DownPressionada", true);
        }
    }

    private void LevDown()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("DownPressionada", false);
        }
    }

    private void PressRight()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("RightPressionada", true);
        }
    }

    private void LevRight()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("RightPressionada", false);
        }
    }

    private void PressLeft()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("LeftPressionada", true);
        }
    }

    private void LevLeft()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("LeftPressionada", false);
        }
    }

    private void PressShift()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool("ShiftPressionada", true);
        }
    }

    private void LevShift()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("ShiftPressionada", false);
        }
    }

    private void PressE()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("EPressionada", true);
        }
    }

    private void LevE()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.SetBool("EPressionada", false);
        }
    }

    private void PressQ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetBool("QPressionada", true);
        }
    }

    private void LevQ()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            anim.SetBool("QPressionada", false);
        }
    }

    private void Update()
    {

        PressW();
        LevW();
        PressA();
        LevA();
        PressS();
        LevS();
        PressD();
        LevD();
        PressUp();
        LevUp();
        PressDown();
        LevDown();
        PressRight();
        LevRight();
        PressLeft();
        LevLeft();
        PressShift();
        LevShift();
        PressE();
        LevE();
        PressQ();
        LevQ();
    }


}
