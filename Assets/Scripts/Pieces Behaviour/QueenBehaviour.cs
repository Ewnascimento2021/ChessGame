using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenBehaviour : MonoBehaviour
{

    void Update()
    {
        if (GetComponent<PieceController>().iAmSelected)
        {
            QueenIsMoving();
        }
    }

    private void QueenIsMoving()
    {
        // X ++ and Z ++

        int contX = gameObject.GetComponent<PieceController>().myX + 1;
        int contZ = gameObject.GetComponent<PieceController>().myZ + 1;

        while (contX < 8 && contZ < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                ReferenceController.Instance.PaintColor(contX, contZ);
            }

            if (!ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                if (!ReferenceController.Instance.CheckColorPiece(contX, contZ)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(contX, contZ);
                }
                else if (ReferenceController.Instance.CheckColorPiece(contX, contZ)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(contX, contZ);
                }
                break;
            }
            contX++;
            contZ++;
        }

        // X -- and Z --

        contX = gameObject.GetComponent<PieceController>().myX - 1;
        contZ = gameObject.GetComponent<PieceController>().myZ - 1;

        while (contX >= 0 && contZ >= 0)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                ReferenceController.Instance.PaintColor(contX, contZ);
            }

            if (!ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                if (!ReferenceController.Instance.CheckColorPiece(contX, contZ)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(contX, contZ);
                }
                else if (ReferenceController.Instance.CheckColorPiece(contX, contZ)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(contX, contZ);
                }
                break;
            }
            contX--;
            contZ--;
        }


        // X ++ and Z --

        contX = gameObject.GetComponent<PieceController>().myX + 1;
        contZ = gameObject.GetComponent<PieceController>().myZ - 1;

        while (contX < 8 && contZ >= 0)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                ReferenceController.Instance.PaintColor(contX, contZ);
            }

            if (!ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                if (!ReferenceController.Instance.CheckColorPiece(contX, contZ)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(contX, contZ);
                }
                else if (ReferenceController.Instance.CheckColorPiece(contX, contZ)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(contX, contZ);
                }
                break;
            }
            contX++;
            contZ--;
        }

        // X -- and Z ++

        contX = gameObject.GetComponent<PieceController>().myX - 1;
        contZ = gameObject.GetComponent<PieceController>().myZ + 1;

        while (contX >= 0 && contZ < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                ReferenceController.Instance.PaintColor(contX, contZ);
            }

            if (!ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                if (!ReferenceController.Instance.CheckColorPiece(contX, contZ)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(contX, contZ);
                }
                else if (ReferenceController.Instance.CheckColorPiece(contX, contZ)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(contX, contZ);
                }
                break;
            }
            contX--;
            contZ++;
        }

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
