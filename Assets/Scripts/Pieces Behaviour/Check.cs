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

    private bool xPlus1ZPlus2;
    private bool xPlus2ZPlus1;
    private bool xPlus2ZReduce1;
    private bool xPlus1ZReduce2;
    private bool xReduce1ZPlus2;
    private bool xReduce2ZPlus1;
    private bool xReduce2ZReduce1;
    private bool xReduce1ZReduce2;



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
            if (!ReferenceController.Instance.CheckEmpty(contX, contZ) && ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
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
            if (!ReferenceController.Instance.CheckEmpty(contX, contZ) && ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite
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

        // X + 1, Z + 2
        contX = gameObject.GetComponent<PieceController>().myX + 1;
        contZ = gameObject.GetComponent<PieceController>().myZ + 2;

        if (gameObject.GetComponent<PieceController>().myX <= 6 && gameObject.GetComponent<PieceController>().myZ <= 5
            && !ReferenceController.Instance.CheckEmpty(contX, contZ)
            && ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Knight"
            && (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
            || ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite))
        {
            ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
            xPlus1ZPlus2 = true;
        }
        else
        {
            xPlus1ZPlus2 = false;
        }

        // X + 2, Z + 1
        contX = gameObject.GetComponent<PieceController>().myX + 2;
        contZ = gameObject.GetComponent<PieceController>().myZ + 1;

        if (gameObject.GetComponent<PieceController>().myX <= 5 && gameObject.GetComponent<PieceController>().myZ <= 6
            && !ReferenceController.Instance.CheckEmpty(contX, contZ)
            && ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Knight"
            && (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
            || ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite))
        {
            ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
            xPlus2ZPlus1 = true;
        }
        else
        {
            xPlus2ZPlus1 = false;
        }

        // X + 2, Z - 1
        contX = gameObject.GetComponent<PieceController>().myX + 2;
        contZ = gameObject.GetComponent<PieceController>().myZ - 1;

        if (gameObject.GetComponent<PieceController>().myX <= 5 && gameObject.GetComponent<PieceController>().myZ >= 1
            && !ReferenceController.Instance.CheckEmpty(contX, contZ)
            && ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Knight"
            && (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
            || ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite))
        {
            ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
            xPlus2ZReduce1 = true;
        }
        else
        {
            xPlus2ZReduce1 = false;
        }

        // X + 1, Z - 2
        contX = gameObject.GetComponent<PieceController>().myX + 1;
        contZ = gameObject.GetComponent<PieceController>().myZ - 2;

        if (gameObject.GetComponent<PieceController>().myX <= 6 && gameObject.GetComponent<PieceController>().myZ >= 2
            && !ReferenceController.Instance.CheckEmpty(contX, contZ)
            && ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Knight"
            && (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
            || ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite))
        {
            ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
            xPlus1ZReduce2 = true;
        }
        else
        {
            xPlus1ZReduce2 = false;
        }

        // X - 1, Z + 2
        contX = gameObject.GetComponent<PieceController>().myX - 1;
        contZ = gameObject.GetComponent<PieceController>().myZ + 2;

        if (gameObject.GetComponent<PieceController>().myX >= 1 && gameObject.GetComponent<PieceController>().myZ <= 5
            && !ReferenceController.Instance.CheckEmpty(contX, contZ)
            && ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Knight"
            && (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
            || ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite))
        {
            ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
            xReduce1ZPlus2 = true;
        }
        else
        {
            xReduce1ZPlus2 = false;
        }

        // X - 2, Z + 1
        contX = gameObject.GetComponent<PieceController>().myX - 2;
        contZ = gameObject.GetComponent<PieceController>().myZ + 1;

        if (gameObject.GetComponent<PieceController>().myX >= 2 && gameObject.GetComponent<PieceController>().myZ <= 6
            && !ReferenceController.Instance.CheckEmpty(contX, contZ)
            && ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Knight"
            && (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
            || ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite))
        {
            ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
            xReduce2ZPlus1 = true;
        }
        else
        {
            xReduce2ZPlus1 = false;
        }

        // X - 2, Z - 1
        contX = gameObject.GetComponent<PieceController>().myX - 2;
        contZ = gameObject.GetComponent<PieceController>().myZ - 1;

        if (gameObject.GetComponent<PieceController>().myX >= 2 && gameObject.GetComponent<PieceController>().myZ >= 1
            && !ReferenceController.Instance.CheckEmpty(contX, contZ)
            && ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Knight"
            && (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
            || ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite))
        {
            ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
            xReduce2ZReduce1 = true;
        }
        else
        {
            xReduce2ZReduce1 = false;
        }

        // X - 1, Z - 2
        contX = gameObject.GetComponent<PieceController>().myX - 1;
        contZ = gameObject.GetComponent<PieceController>().myZ - 2;

        if (gameObject.GetComponent<PieceController>().myX >= 1 && gameObject.GetComponent<PieceController>().myZ >= 2
            && !ReferenceController.Instance.CheckEmpty(contX, contZ)
            && ReferenceController.Instance.CheckTypePiece(contX, contZ) == "Knight"
            && (!ReferenceController.Instance.CheckColorPiece(contX, contZ) && GetComponent<PieceController>().isWhite
            || ReferenceController.Instance.CheckColorPiece(contX, contZ) && !GetComponent<PieceController>().isWhite))
        {
            ReferenceController.Instance.PaintKingCheck(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
            xReduce1ZReduce2 = true;
        }
        else
        {
            xReduce1ZReduce2 = false;
        }

        if (!xPlusZPlus && !xReduceZPlus && !xPlusZReduce && !xReduceZReduce
            && !xPlus && !zPlus && !xReduce && !zReduce
            && !xPlus1ZPlus2 && !xPlus2ZPlus1 && !xPlus2ZReduce1 && !xPlus1ZReduce2 && !xReduce1ZPlus2 && !xReduce2ZPlus1 && !xReduce2ZReduce1 && !xReduce1ZReduce2)

        {
            ReferenceController.Instance.ReturnColorKing(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ);
        }

    }
}
