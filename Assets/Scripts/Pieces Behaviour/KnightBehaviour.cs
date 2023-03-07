using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightBehaviour : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<PieceController>().iAmSelected)
        {
            KnightIsMoving();
        }
    }

    private void KnightIsMoving()
    {
        // X + 1, Z + 2
        if (gameObject.GetComponent<PieceController>().myX <= 6 && gameObject.GetComponent<PieceController>().myZ <= 5)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 2))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 2);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 2))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 2)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 2);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 2)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 2);
                }
            }
        }
        // X + 2, Z + 1
        if (gameObject.GetComponent<PieceController>().myX <= 5 && gameObject.GetComponent<PieceController>().myZ <= 6)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ + 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ + 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ + 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ + 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ + 1);
                }
            }
        }
        // X + 2, Z - 1
        if (gameObject.GetComponent<PieceController>().myX <= 5 && gameObject.GetComponent<PieceController>().myZ >= 1)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ - 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ - 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ - 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ - 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ - 1);
                }
            }
        }
        // X + 1, Z - 2
        if (gameObject.GetComponent<PieceController>().myX <= 6 && gameObject.GetComponent<PieceController>().myZ >= 2)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 2))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 2);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 2))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 2)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 2);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 2)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 2);
                }
            }
        }
        // X - 1, Z + 2
        if (gameObject.GetComponent<PieceController>().myX >= 1 && gameObject.GetComponent<PieceController>().myZ <= 5)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 2))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 2);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 2))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 2)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 2);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 2)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 2);
                }
            }
        }
        // X - 2, Z + 1
        if (gameObject.GetComponent<PieceController>().myX >= 3 && gameObject.GetComponent<PieceController>().myZ <= 6)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ + 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ + 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ + 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ + 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ + 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ + 1);
                }
            }
        }
        // X - 2, Z - 1
        if (gameObject.GetComponent<PieceController>().myX >= 3 && gameObject.GetComponent<PieceController>().myZ >= 1)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ - 1);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ - 1))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ - 1)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ - 1);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ - 1)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ - 1);
                }
            }
        }
        // X - 1, Z - 2
        if (gameObject.GetComponent<PieceController>().myX >= 1 && gameObject.GetComponent<PieceController>().myZ >= 3)
        {
            if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 2))
            {
                ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 2);
            }

            if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 2))
            {
                if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 2)
                && GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 2);
                }
                else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 2)
                && !GetComponent<PieceController>().isWhite)
                {
                    ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 2);
                }
            }
        }
    }
}
