using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnBehaviour : MonoBehaviour
{
    public bool firstMovementDone;

    void Start()
    {

    }

    void Update()
    {
        PawnMove();
    }

    private void PawnMove()
    {
        if (gameObject.GetComponent<Piece>().iAmSelected && !firstMovementDone)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 1);
            }
        }
    }

}
