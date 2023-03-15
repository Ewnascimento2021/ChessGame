using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingBehaviour : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<PieceController>().iAmSelected)
        {
            KingIsMoving();
        }
        if (GetComponent<PieceController>().firstMove)
        {
            ReferenceController.Instance.KingMoved = true;
        }

        // RookLeft
        else if (ReferenceController.Instance.KingMoved == false && ReferenceController.Instance.RookMoved1 == false && GetComponent<PieceController>().isWhite
            && GetComponent<PieceController>().iAmSelected
            && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ)
            && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ)
            && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 3, gameObject.GetComponent<PieceController>().myZ))
        {
            ReferenceController.Instance.PaintRookColor(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ);
        }

        if (gameObject.GetComponent<PieceController>().myOldX == 4 && gameObject.GetComponent<PieceController>().myOldZ == 0 
            && gameObject.GetComponent<PieceController>().myX == 2 && gameObject.GetComponent<PieceController>().myZ == 0)
        {
            ReferenceController.Instance.Rooked = true;
        }

        // RookRight
        else if (ReferenceController.Instance.KingMoved == false && ReferenceController.Instance.RookMoved2 == false && GetComponent<PieceController>().isWhite
           && GetComponent<PieceController>().iAmSelected
           && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ)
           && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ))
        {
            ReferenceController.Instance.PaintRookColor(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ);
        }

        if (gameObject.GetComponent<PieceController>().myOldX == 4 && gameObject.GetComponent<PieceController>().myOldZ == 0
            && gameObject.GetComponent<PieceController>().myX == 6 && gameObject.GetComponent<PieceController>().myZ == 0)
        {
            ReferenceController.Instance.Rooked = true;
        }




    }

    private void KingIsMoving()
    {
        // X ++ and Z ++
        if (gameObject.GetComponent<PieceController>().myX < 7 && gameObject.GetComponent<PieceController>().myZ < 7)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1);
                }
            }
        }
        // X -- and Z --
        if (gameObject.GetComponent<PieceController>().myX > 0 && gameObject.GetComponent<PieceController>().myZ > 0)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1);
                }
            }
        }
        // X ++ and Z --
        if (gameObject.GetComponent<PieceController>().myX < 7 && gameObject.GetComponent<PieceController>().myZ > 0)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1);
                }
            }
        }
        // X -- and Z ++
        if (gameObject.GetComponent<PieceController>().myX > 0 && gameObject.GetComponent<PieceController>().myZ < 7)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1);
                }
            }
        }
        // Z++
        if (gameObject.GetComponent<PieceController>().myZ < 7)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1);
                }
            }
        }
        // Z--
        if (gameObject.GetComponent<PieceController>().myZ > 0)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1);
                }
            }
        }
        // X++
        if (gameObject.GetComponent<PieceController>().myX < 7)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ);
                }
            }
        }
        // X--
        if (gameObject.GetComponent<PieceController>().myX > 0)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ);
                }
            }
        }
    }

    private void CanRook()
    {

    }
}

