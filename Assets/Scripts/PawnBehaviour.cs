using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnBehaviour : MonoBehaviour
{
    public bool isFirstMovement;

    void Start()
    {

    }

    void Update()
    {
        PawnMove();
    }



    private void PawnMove()
    {
        if (gameObject.GetComponent<Piece>().iAmSelected)
        {
            if (!isFirstMovement)
            {
                if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 1))
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 1);
                }
            }
            if (isFirstMovement)
            {
                if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 2))
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 1);
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX, gameObject.GetComponent<Piece>().myZ + 2);

                    isFirstMovement = false;
                }
            }

            if (gameObject.GetComponent<Piece>().myX != 0 &&
          !ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<Piece>().myX - 1, gameObject.GetComponent<Piece>().myZ + 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<Piece>().myX - 1, gameObject.GetComponent<Piece>().myZ + 1))
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX - 1, gameObject.GetComponent<Piece>().myZ + 1);
                }
            }
            if (gameObject.GetComponent<Piece>().myX != 7 &&
                !ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<Piece>().myX + 1, gameObject.GetComponent<Piece>().myZ + 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<Piece>().myX + 1, gameObject.GetComponent<Piece>().myZ + 1))
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<Piece>().myX + 1, gameObject.GetComponent<Piece>().myZ + 1);
                }
            }
        }
    }
}
