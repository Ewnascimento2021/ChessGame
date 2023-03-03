using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RookBehaviour : MonoBehaviour
{
    private int whiteOrBlackPawn = 1;


    void Start()
    {

    }

    void Update()
    {
        if (GetComponent<PieceController>().iAmSelected)
        {
            RookIsMoving();
        }
    }

    private void RookIsMoving()
    {
        if (GetComponent<PieceController>().isWhite)
        {
            whiteOrBlackPawn = 1;
        }
        else
        {
            whiteOrBlackPawn = -1;
        }

        // Z++

        int cont = 0;
        while (gameObject.GetComponent<PieceController>().myZ + cont < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + cont * whiteOrBlackPawn))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + cont * whiteOrBlackPawn);
            }
            cont++;

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + cont * whiteOrBlackPawn))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + cont * whiteOrBlackPawn)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + cont * whiteOrBlackPawn);
                }
                break;
            }
        }


        cont = 0;
        while (gameObject.GetComponent<PieceController>().myZ + cont < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - cont * whiteOrBlackPawn))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - cont * whiteOrBlackPawn);
            }
            cont++;

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - cont * whiteOrBlackPawn))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - cont * whiteOrBlackPawn)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - cont * whiteOrBlackPawn);
                }
                break;
            }
        }




    }
}
