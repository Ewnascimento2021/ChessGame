using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{

    private bool xPlusZPlus;
    private bool xReduceZPlus;
    private bool xPlusZReduce;
    private bool xReduceZReduce;

    private bool xPlus;
    private bool zPlus;
    private bool xReduce;
    private bool zReduce;




    // Update is called once per frame
    void Update()
    {
        CheckTheCheck();
    }

    private void CheckTheCheck()
    {
        // X ++ and Z ++


        int contX = gameObject.GetComponent<PieceController>().myX + 1;
        int contZ = gameObject.GetComponent<PieceController>().myZ + 1;

        if (contX < 8 && contZ < 8)
        {
            if (!ReferenceController.Instance.CheckEmpty(contX, contZ) && !ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                    && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Pawn"))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                return;
            }
        }
        while (contX < 8 && contZ < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                contX++;
                contZ++;
                continue;
            }

            if (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Bishop" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")
                || (ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
                 && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Bishop" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                xPlusZPlus = true;
            }
            else
            {
                xPlusZPlus = false;
            }
            break;
        }


        // X -- and Z ++


        contX = gameObject.GetComponent<PieceController>().myX - 1;
        contZ = gameObject.GetComponent<PieceController>().myZ + 1;

        if (contX >= 0 && contZ < 8)
        {
            if (!ReferenceController.Instance.CheckEmpty(contX, contZ) && !ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                    && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Pawn"))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                return;
            }
        }
        while (contX >= 0 && contZ < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                contX--;
                contZ++;
                continue;
            }

            if (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Bishop" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")
                || (ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
                 && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Bishop" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                xReduceZPlus = true;
            }
            else
            {
                xReduceZPlus = false;
            }
            break;
        }

        // X ++ and Z --


        contX = gameObject.GetComponent<PieceController>().myX + 1;
        contZ = gameObject.GetComponent<PieceController>().myZ - 1;

        if (contX < 8 && contZ >= 0)
        {
            if (!ReferenceController.Instance.CheckEmpty(contX, contZ) && !ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                    && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Pawn"))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                return;
            }
        }
        while (contX < 8 && contZ >= 0)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                contX++;
                contZ--;
                continue;
            }

            if (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Bishop" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")
                || (ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
                 && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Bishop" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);

                xPlusZReduce = true;
            }
            else
            {
                xPlusZReduce = false;
            }
            break;
        }

        // X -- and Z --


        contX = gameObject.GetComponent<PieceController>().myX - 1;
        contZ = gameObject.GetComponent<PieceController>().myZ - 1;

        if (contX >= 0 && contZ >= 0)
        {
            if (!ReferenceController.Instance.CheckEmpty(contX, contZ) && !ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                    && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Pawn"))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                return;
            }
        }
        while (contX >= 0 && contZ >= 0)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                contX--;
                contZ--;
                continue;
            }

            if (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Bishop" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")
                || (ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
                 && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Bishop" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                xReduceZReduce = true;
            }

            else
            {
                xReduceZReduce = false;
            }
            break;
        }


        // Z++
        contX = gameObject.GetComponent<PieceController>().myX;
        contZ = gameObject.GetComponent<PieceController>().myZ + 1;

        while (contZ < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                contZ++;
                continue;
            }
            if (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                 && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Rook" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")
                 || (ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
                  && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Rook" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                zPlus = true;
            }

            else
            {
                zPlus = false;
            }
            break;
        }

        // Z--
        contX = gameObject.GetComponent<PieceController>().myX;
        contZ = gameObject.GetComponent<PieceController>().myZ - 1;

        while (contZ >= 0)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                contZ--;
                continue;
            }
            if (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                 && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Rook" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")
                 || (ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
                  && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Rook" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                zReduce = true;
            }

            else
            {
                zReduce = false;
            }
            break;
        }

        // X++
        contX = gameObject.GetComponent<PieceController>().myX + 1;
        contZ = gameObject.GetComponent<PieceController>().myZ;

        while (contX < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                contX++;
                continue;
            }
            if (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                 && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Rook" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")
                 || (ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
                  && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Rook" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                xPlus = true;
            }

            else
            {
                xPlus = false;
            }
            break;
        }

        // X--
        contX = gameObject.GetComponent<PieceController>().myX - 1;
        contZ = gameObject.GetComponent<PieceController>().myZ;

        while (contX >= 0)
        {
            if (ReferenceController.Instance.CheckEmpty(contX, contZ))
            {
                contX--;
                continue;
            }
            if (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
                 && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Rook" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")
                 || (ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
                  && (ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Rook" || ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Queen")))
            {
                ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
                xReduce = true;
            }

            else
            {
                xReduce = false;
            }
            break;
        }
    }

}
