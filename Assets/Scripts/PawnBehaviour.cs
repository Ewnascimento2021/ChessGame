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
        PawnMove();
    }



    private void PawnMove()
    {
        // White Pieces

        if (GetComponent<Piece>().isWhite)
        {
            whiteOrBlackPawn = 1;
        }
        else
        {
            whiteOrBlackPawn = -1;
        }

        if (gameObject.GetComponent<Piece>().iAmSelected)
        {
            if (!isFirstMovement)
            {
                Debug.Log("Piece White");
                if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn))
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn);
                }
            }
            if (isFirstMovement)
            {
                if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 2 * whiteOrBlackPawn))
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn);
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 2 * whiteOrBlackPawn);

                    isFirstMovement = false;
                }
            }

            if (gameObject.GetComponent<Piece>().myX != 0 &&
          !ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<Piece>().myX - 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<Piece>().myX - 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn)
                    && GetComponent<Piece>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX - 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<Piece>().myX - 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn)
                    && !GetComponent<Piece>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX - 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn);
                }
            }
            if (gameObject.GetComponent<Piece>().myX != 7 &&
                !ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<Piece>().myX + 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<Piece>().myX + 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn)
                    && GetComponent<Piece>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX + 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<Piece>().myX + 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn)
                    && !GetComponent<Piece>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX + 1, gameObject.GetComponent<Piece>().myZ + 1 * whiteOrBlackPawn);
                }
            }
        }
    }
}

