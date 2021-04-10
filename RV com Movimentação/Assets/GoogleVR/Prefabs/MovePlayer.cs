using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    float speed = 10;
    bool isForward = false;
    bool isBack = false;
    bool isLeft = false;
    bool isRight = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isForward)
        {
            transform.Translate(0, 0, (speed * Time.deltaTime));
        }
        if (isBack)
        {
            transform.Translate(0, 0, (- speed * Time.deltaTime));
        }
        if (isLeft)
        {
            transform.Translate((-speed * Time.deltaTime), 0, 0);
        }
        if (isRight)
        {
            transform.Translate((speed * Time.deltaTime), 0, 0);
        }
    }

    void EnableMoveController(bool frente = false, bool tras = false, bool esquerda = false, bool direita = false)
    {
        if(frente)
            isForward = frente;
        if (tras)
            isBack = tras;
        if (esquerda)
            isLeft = esquerda;
        if (direita)
            isRight = direita;
    }

    public void DisableMoveController()
    {
            isForward = false;
            isBack = false;
            isLeft = false;
            isRight = false;
    }

    public void Forward()
    {
        EnableMoveController(true);
    }

    public void Back()
    {
        EnableMoveController(false,true);
    }

    public void Left()
    {
        EnableMoveController(false, false, true);
    }

    public void Right()
    {
        EnableMoveController(false, false, false, true);
    }
}
