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
    }
}


//// Z++
//int cont = gameObject.GetComponent<PieceController>().myZ + 1;

//while (cont < 8)
//{
//    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, cont))
//    {
//        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
//    }

//    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, cont))
//    {
//        if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, cont)
//        && GetComponent<PieceController>().isWhite)
//        {
//            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
//        }
//        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, cont)
//        && !GetComponent<PieceController>().isWhite)
//        {
//            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
//        }
//        break;
//    }
//    cont++;
//}

//// Z--

//cont = gameObject.GetComponent<PieceController>().myZ - 1;

//while (cont >= 0)
//{
//    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, cont))
//    {
//        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
//    }

//    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, cont))
//    {
//        if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, cont)
//        && GetComponent<PieceController>().isWhite)
//        {
//            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
//        }
//        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, cont)
//        && !GetComponent<PieceController>().isWhite)
//        {
//            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, cont);
//        }
//        break;
//    }
//    cont--;
//}


//// X++

//cont = gameObject.GetComponent<PieceController>().myX + 1;

//while (cont < 8)
//{
//    if (ReferenceController.Instance.CheckEmpty(cont, gameObject.GetComponent<PieceController>().myZ))
//    {
//        ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
//    }

//    if (!ReferenceController.Instance.CheckEmpty(cont, gameObject.GetComponent<PieceController>().myZ))
//    {
//        if (!ReferenceController.Instance.CheckColorPiece(cont, gameObject.GetComponent<PieceController>().myZ)
//        && GetComponent<PieceController>().isWhite)
//        {
//            ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
//        }
//        else if (ReferenceController.Instance.CheckColorPiece(cont, gameObject.GetComponent<PieceController>().myZ)
//        && !GetComponent<PieceController>().isWhite)
//        {
//            ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
//        }
//        break;
//    }
//    cont++;
//}

//// X--

//cont = gameObject.GetComponent<PieceController>().myX - 1;

//while (cont >= 0)
//{
//    if (ReferenceController.Instance.CheckEmpty(cont, gameObject.GetComponent<PieceController>().myZ))
//    {
//        ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
//    }

//    if (!ReferenceController.Instance.CheckEmpty(cont, gameObject.GetComponent<PieceController>().myZ))
//    {
//        if (!ReferenceController.Instance.CheckColorPiece(cont, gameObject.GetComponent<PieceController>().myZ)
//        && GetComponent<PieceController>().isWhite)
//        {
//            ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
//        }
//        else if (ReferenceController.Instance.CheckColorPiece(cont, gameObject.GetComponent<PieceController>().myZ)
//        && !GetComponent<PieceController>().isWhite)
//        {
//            ReferenceController.Instance.PaintColor(cont, gameObject.GetComponent<PieceController>().myZ);
//        }
//        break;
//    }
//    cont--;
//}
//    }
//}
//}
