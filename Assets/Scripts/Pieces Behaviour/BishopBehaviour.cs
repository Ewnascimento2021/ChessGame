using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopBehaviour : MonoBehaviour
{

    void Update()
    {
        if (GetComponent<PieceController>().iAmSelected)
        {
            BishopIsMoving();
        }
    }

    private void BishopIsMoving()
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



    }
}
