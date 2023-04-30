using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnBehaviour : MonoBehaviour
{
    private bool isFirstMovement;
    private int whiteOrBlackPawn = 1;


    void Start()
    {
        isFirstMovement = true;
    }

    void Update()
    {
        if (GetComponent<PieceController>().iAmSelected && GetComponent<PieceController>().isPainting)
        {
            PaintPawnMove();
        }
    }

    private void PaintPawnMove()
    {
        if (GetComponent<PieceController>().isWhite)
        {
            whiteOrBlackPawn = 1;
        }
        else
        {
            whiteOrBlackPawn = -1;
        }

        if (GetComponent<PieceController>().firstMove)
        {
            isFirstMovement = false;
        }

        if (!isFirstMovement)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn);
            }
        }
        if (isFirstMovement)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn);

                if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 2 * whiteOrBlackPawn))
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 2 * whiteOrBlackPawn);
                }
            }
        }

        if (gameObject.GetComponent<PieceController>().myX != 0 &&
      !ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn))
        {
            if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn)
                && GetComponent<PieceController>().isWhite)
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn);
            }
            else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn)
                && !GetComponent<PieceController>().isWhite)
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn);
            }
        }
        if (gameObject.GetComponent<PieceController>().myX != 7 &&
            !ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn))
        {
            if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn)
                && GetComponent<PieceController>().isWhite)
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn);
            }
            else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn)
                && !GetComponent<PieceController>().isWhite)
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1 * whiteOrBlackPawn);
            }
        }

    }
}

