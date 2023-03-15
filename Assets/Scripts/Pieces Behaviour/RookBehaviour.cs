using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RookBehaviour : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<PieceController>().firstMove
            && gameObject.GetComponent<PieceController>().myOldX == 0
            && gameObject.GetComponent<PieceController>().myOldZ == 0)
        {
            ReferenceController.Instance.RookMoved1 = true;
        }
        if (GetComponent<PieceController>().firstMove
            && gameObject.GetComponent<PieceController>().myOldX == 7
            && gameObject.GetComponent<PieceController>().myOldZ == 0)

        {
            ReferenceController.Instance.RookMoved2 = true;
        }
        if (GetComponent<PieceController>().firstMove
            && gameObject.GetComponent<PieceController>().myOldX == 0
            && gameObject.GetComponent<PieceController>().myOldZ == 7)
        {
            ReferenceController.Instance.RookMoved3 = true;
        }
        if (GetComponent<PieceController>().firstMove
            && gameObject.GetComponent<PieceController>().myOldX == 7
            && gameObject.GetComponent<PieceController>().myOldZ == 7)
        {
            ReferenceController.Instance.RookMoved4 = true;
        }


        if (GetComponent<PieceController>().iAmSelected)
        {
            RookIsMoving();
        }

        else if (gameObject.GetComponent<PieceController>().myX == 0 && gameObject.GetComponent<PieceController>().myZ == 0 && ReferenceController.Instance.Rooked == true
            && ReferenceController.Instance.RookMoved1 == false)
        {
            transform.position = new Vector3(gameObject.GetComponent<PieceController>().myX + 4, transform.position.y, transform.position.z);

            GetComponent<PieceController>().myX = gameObject.GetComponent<PieceController>().myX + 3;

            ReferenceController.Instance.RookMoved1 = true;
        }

        else if (gameObject.GetComponent<PieceController>().myX == 7 && gameObject.GetComponent<PieceController>().myZ == 0 && ReferenceController.Instance.Rooked == true
            && ReferenceController.Instance.RookMoved2 == false)
        {
            transform.position = new Vector3(gameObject.GetComponent<PieceController>().myX - 1, transform.position.y, transform.position.z);

            GetComponent<PieceController>().myX = gameObject.GetComponent<PieceController>().myX - 2;

            ReferenceController.Instance.RookMoved2 = true;

        }

    }

    private void RookIsMoving()
    {

        // Z++
        int cont = gameObject.GetComponent<PieceController>().myZ + 1;

        while (cont < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, cont))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, cont))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, cont)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, cont)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
                }
                break;
            }
            cont++;
        }

        // Z--

        cont = gameObject.GetComponent<PieceController>().myZ - 1;

        while (cont >= 0)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, cont))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, cont))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, cont)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, cont)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
                }
                break;
            }
            cont--;
        }


        // X++

        cont = gameObject.GetComponent<PieceController>().myX + 1;

        while (cont < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(cont, gameObject.GetComponent<PieceController>().myZ))
            {
                ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
            }

            if (!ReferenceController.Instance.CheckEmpty(cont, gameObject.GetComponent<PieceController>().myZ))
            {
                if (!ReferenceController.Instance.CheckColorPiece(cont, gameObject.GetComponent<PieceController>().myZ)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
                }
                else if (ReferenceController.Instance.CheckColorPiece(cont, gameObject.GetComponent<PieceController>().myZ)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
                }
                break;
            }
            cont++;
        }

        // X--

        cont = gameObject.GetComponent<PieceController>().myX - 1;

        while (cont >= 0)
        {
            if (ReferenceController.Instance.CheckEmpty(cont, gameObject.GetComponent<PieceController>().myZ))
            {
                ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
            }

            if (!ReferenceController.Instance.CheckEmpty(cont, gameObject.GetComponent<PieceController>().myZ))
            {
                if (!ReferenceController.Instance.CheckColorPiece(cont, gameObject.GetComponent<PieceController>().myZ)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
                }
                else if (ReferenceController.Instance.CheckColorPiece(cont, gameObject.GetComponent<PieceController>().myZ)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
                }
                break;
            }
            cont--;
        }
    }
}
