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
            Check8();
        }
        if (GetComponent<PieceController>().firstMove && GetComponent<PieceController>().isWhite)
        {
            ReferenceController.Instance.KingWhiteMoved = true;
        }
        else if (GetComponent<PieceController>().firstMove && !GetComponent<PieceController>().isWhite)
        {
            ReferenceController.Instance.KingBlackMoved = true;
        }


        // RookLeftWhite
        else if (ReferenceController.Instance.KingWhiteMoved == false && ReferenceController.Instance.RookMoved1 == false && GetComponent<PieceController>().isWhite
        && ReferenceController.Instance.BlackOrWhite
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
            ReferenceController.Instance.KingWhiteMoved = true;
            ReferenceController.Instance.Rooked1 = true;
        }

        // RookRighWhite
        else if (ReferenceController.Instance.KingWhiteMoved == false && ReferenceController.Instance.RookMoved2 == false && GetComponent<PieceController>().isWhite
            && ReferenceController.Instance.BlackOrWhite
            && GetComponent<PieceController>().iAmSelected
            && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ)
            && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ))
        {
            ReferenceController.Instance.PaintRookColor(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ);
        }

        if (gameObject.GetComponent<PieceController>().myOldX == 4 && gameObject.GetComponent<PieceController>().myOldZ == 0
            && gameObject.GetComponent<PieceController>().myX == 6 && gameObject.GetComponent<PieceController>().myZ == 0)
        {
            ReferenceController.Instance.KingWhiteMoved = true;
            ReferenceController.Instance.Rooked2 = true;
        }

        // RookLeftBlack
        else if (ReferenceController.Instance.KingBlackMoved == false && ReferenceController.Instance.RookMoved3 == false && !GetComponent<PieceController>().isWhite
           && !ReferenceController.Instance.BlackOrWhite
           && GetComponent<PieceController>().iAmSelected
           && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ)
           && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ)
           && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 3, gameObject.GetComponent<PieceController>().myZ))
        {
            ReferenceController.Instance.PaintRookColor(gameObject.GetComponent<PieceController>().myX - 2, gameObject.GetComponent<PieceController>().myZ);
        }

        if (gameObject.GetComponent<PieceController>().myOldX == 4 && gameObject.GetComponent<PieceController>().myOldZ == 7
            && gameObject.GetComponent<PieceController>().myX == 2 && gameObject.GetComponent<PieceController>().myZ == 7)
        {
            ReferenceController.Instance.KingBlackMoved = true;
            ReferenceController.Instance.Rooked3 = true;
        }

        // RookRighBlack
        else if (ReferenceController.Instance.KingBlackMoved == false && ReferenceController.Instance.RookMoved4 == false && !GetComponent<PieceController>().isWhite
            && !ReferenceController.Instance.BlackOrWhite
            && GetComponent<PieceController>().iAmSelected
            && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ)
            && ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ))
        {
            ReferenceController.Instance.PaintRookColor(gameObject.GetComponent<PieceController>().myX + 2, gameObject.GetComponent<PieceController>().myZ);
        }

        if (gameObject.GetComponent<PieceController>().myOldX == 4 && gameObject.GetComponent<PieceController>().myOldZ == 7
            && gameObject.GetComponent<PieceController>().myX == 6 && gameObject.GetComponent<PieceController>().myZ == 7)
        {
            ReferenceController.Instance.KingBlackMoved = true;
            ReferenceController.Instance.Rooked4 = true;
        }



    }


    private void HouseOpen(int checkX, int checkZ)
    {
        if (CheckKnight(checkX, checkZ) && CheckAsterisk(checkX, checkZ))
        {
            ReferenceController.Instance.PaintColor(checkX, checkZ);
        }
    }
    private void Check8()
    {
        if (gameObject.GetComponent<PieceController>().myZ + 1 < 8)
        {
            HouseOpen(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1);
        }
        if (gameObject.GetComponent<PieceController>().myX + 1 < 8 && gameObject.GetComponent<PieceController>().myZ + 1 < 8)
        {
            HouseOpen(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1);
        }
        if (gameObject.GetComponent<PieceController>().myX + 1 < 8)
        {
            HouseOpen(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ);
        }
        if (gameObject.GetComponent<PieceController>().myX + 1 < 8 && gameObject.GetComponent<PieceController>().myZ - 1 >= 0)
        {
            HouseOpen(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1);
        }
        if (gameObject.GetComponent<PieceController>().myZ - 1 >= 0)
        {
            HouseOpen(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1);
        }
        if (gameObject.GetComponent<PieceController>().myX - 1 >= 0 && gameObject.GetComponent<PieceController>().myZ - 1 >= 0)
        {
            HouseOpen(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1);
        }
        if (gameObject.GetComponent<PieceController>().myX - 1 >= 0)
        {
            HouseOpen(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ);
        }
        if (gameObject.GetComponent<PieceController>().myX - 1 >= 0 && gameObject.GetComponent<PieceController>().myZ + 1 < 8)
        {
            HouseOpen(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1);
        }
    }
    private bool CheckKnight(int checkX, int checkZ)
    {
        if (CheckL(checkX, checkZ, 1, 2)
        && CheckL(checkX, checkZ, 2, 1)
        && CheckL(checkX, checkZ, 2, -1)
        && CheckL(checkX, checkZ, 1, -2)
        && CheckL(checkX, checkZ, -1, -2)
        && CheckL(checkX, checkZ, -2, -1)
        && CheckL(checkX, checkZ, -2, 1)
        && CheckL(checkX, checkZ, -1, 2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private bool CheckL(int checkX, int checkZ, int lookX, int lookZ)
    {
        if (checkX + lookX >= 0 && checkX + lookX < 8 && checkZ + lookZ >= 0 && checkZ + lookZ < 8)
        {
            if ((ReferenceController.Instance.CheckTypePiece(checkX + lookX, checkZ + lookZ) == "Knight")
            && (GetComponent<PieceController>().isWhite != ReferenceController.Instance.CheckColorPiece(checkX + lookX, checkZ + lookZ)))
            {
                return false;
            }
        }
        return true;
    }
    private bool CheckAsterisk(int checkX, int checkZ)
    {
        if (CheckSide(checkX, checkZ, 0, 1)
        && CheckSide(checkX, checkZ, 1, 1)
        && CheckSide(checkX, checkZ, 1, 0)
        && CheckSide(checkX, checkZ, 1, -1)
        && CheckSide(checkX, checkZ, 0, -1)
        && CheckSide(checkX, checkZ, -1, -1)
        && CheckSide(checkX, checkZ, -1, 0)
        && CheckSide(checkX, checkZ, -1, 1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private bool CheckSide(int checkX, int checkZ, int sumX, int sumZ)
    {
        int otherX;
        int otherZ;
        int cont = 0;

        while (checkX + sumX * cont > -1 && checkX + sumX * cont < 8 && checkZ + sumZ * cont > -1 && checkZ + sumZ * cont < 8)
        {
            if (ReferenceController.Instance.CheckEmpty(checkX + sumX * cont, checkZ + sumZ * cont))
            {
                cont++;
                continue;
            }
            else
            {
                otherX = checkX + sumX * cont;
                otherZ = checkZ + sumZ * cont;



                if (GetComponent<PieceController>().isWhite != ReferenceController.Instance.CheckColorPiece(otherX, otherZ))
                {
                    if (sumX == 0 || sumZ == 0)
                    {
                        if (cont == 1)
                        {
                            if (ReferenceController.Instance.CheckTypePiece(otherX, otherZ) == "King")
                            {
                                return false;
                            }
                        }
                        if (ReferenceController.Instance.CheckTypePiece(otherX, otherZ) == "Rook" || ReferenceController.Instance.CheckTypePiece(otherX, otherZ) == "Queen")
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (cont == 1)
                        {
                            if (ReferenceController.Instance.CheckTypePiece(otherX, otherZ) == "Pawn")
                            {
                                if (GetComponent<PieceController>().isWhite && sumZ > 0)
                                {
                                    return false;
                                }
                                else if (!GetComponent<PieceController>().isWhite && sumZ < 0)
                                {
                                    return false;
                                }
                            }
                            else if (ReferenceController.Instance.CheckTypePiece(otherX, otherZ) == "King")
                            {
                                return false;
                            }
                        }
                        if (ReferenceController.Instance.CheckTypePiece(otherX, otherZ) == "Bishop" || ReferenceController.Instance.CheckTypePiece(otherX, otherZ) == "Queen")
                        {
                            return false;
                        }
                    }
                }
                else if (ReferenceController.Instance.CheckTypePiece(otherX, otherZ) == "King")
                {
                    cont++;
                    continue;
                }
                break;
            }
        }
        if (cont > 0)
        {
            return true;
        }
        return false;
    }




































    //private void KingIsMoving()
    //{




    //// X ++ and Z ++
    //if (gameObject.GetComponent<PieceController>().myX < 7 && gameObject.GetComponent<PieceController>().myZ < 7 && ReferenceController.Instance.AutoCheckXPlusZPlus == false)
    //{
    //    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1))
    //    {
    //        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1);
    //    }

    //    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1))
    //    {
    //        if (!ReferenceController.Instance.
    //        (gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1)
    //        && GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1);
    //        }
    //        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1)
    //        && !GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ + 1);
    //        }
    //    }
    //}
    //// X -- and Z --
    //if (gameObject.GetComponent<PieceController>().myX > 0 && gameObject.GetComponent<PieceController>().myZ > 0)
    //{
    //    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1))
    //    {
    //        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1);
    //    }

    //    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1))
    //    {
    //        if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1)
    //        && GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1);
    //        }
    //        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1)
    //        && !GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ - 1);
    //        }
    //    }
    //}
    //// X ++ and Z --
    //if (gameObject.GetComponent<PieceController>().myX < 7 && gameObject.GetComponent<PieceController>().myZ > 0)
    //{
    //    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1))
    //    {
    //        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1);
    //    }

    //    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1))
    //    {
    //        if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1)
    //        && GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1);
    //        }
    //        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1)
    //        && !GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ - 1);
    //        }
    //    }
    //}
    //// X -- and Z ++
    //if (gameObject.GetComponent<PieceController>().myX > 0 && gameObject.GetComponent<PieceController>().myZ < 7)
    //{
    //    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1))
    //    {
    //        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1);
    //    }

    //    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1))
    //    {
    //        if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1)
    //        && GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1);
    //        }
    //        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1)
    //        && !GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ + 1);
    //        }
    //    }
    //}
    //// Z++
    //if (gameObject.GetComponent<PieceController>().myZ < 7)
    //{
    //    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1))
    //    {
    //        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1);
    //    }

    //    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1))
    //    {
    //        if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1)
    //        && GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1);
    //        }
    //        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1)
    //        && !GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ + 1);
    //        }
    //    }
    //}
    //// Z--
    //if (gameObject.GetComponent<PieceController>().myZ > 0)
    //{
    //    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1))
    //    {
    //        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1);
    //    }

    //    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1))
    //    {
    //        if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1)
    //        && GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1);
    //        }
    //        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1)
    //        && !GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX, gameObject.GetComponent<PieceController>().myZ - 1);
    //        }
    //    }
    //}
    //// X++
    //if (gameObject.GetComponent<PieceController>().myX < 7)
    //{
    //    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ))
    //    {
    //        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ);
    //    }

    //    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ))
    //    {
    //        if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ)
    //        && GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ);
    //        }
    //        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ)
    //        && !GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX + 1, gameObject.GetComponent<PieceController>().myZ);
    //        }
    //    }
    //}
    //// X--
    //if (gameObject.GetComponent<PieceController>().myX > 0)
    //{
    //    if (ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ))
    //    {
    //        ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ);
    //    }

    //    if (!ReferenceController.Instance.CheckEmpty(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ))
    //    {
    //        if (!ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ)
    //        && GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ);
    //        }
    //        else if (ReferenceController.Instance.CheckColorPiece(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ)
    //        && !GetComponent<PieceController>().isWhite)
    //        {
    //            ReferenceController.Instance.PaintColor(gameObject.GetComponent<PieceController>().myX - 1, gameObject.GetComponent<PieceController>().myZ);
    //        }
    //    }
    //}


}

