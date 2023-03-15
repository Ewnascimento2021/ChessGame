using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class ReferenceController : MonoBehaviour
{
    static ReferenceController instance;
    public static ReferenceController Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<ReferenceController>();
            return instance;
        }
    }

    public GameObject[,] board;
    public float housePosX;
    public float housePosZ;
    public Material selectedColor;
    public Material whiteColor;
    public Material blackColor;
    public Material redColor;
    public Material blueColor;
    public Material yellowColor;
    public Material chessMaterial;




    private void Start()
    {
        blackOrWhite = true;
    }


    private bool isPieceSelected;
    public bool IsPieceSelected { get => isPieceSelected; set => isPieceSelected = value; }


    private bool isHouseSelected;
    public bool IsHouseSelected { get => isHouseSelected; set => isHouseSelected = value; }


    private bool blackOrWhite;
    public bool BlackOrWhite { get => blackOrWhite; set => blackOrWhite = value; }


    private bool kingMoved;
    public bool KingMoved { get => kingMoved; set => kingMoved = value; }


    private bool rookMoved1;
    public bool RookMoved1 { get => rookMoved1; set => rookMoved1 = value; }


    private bool rookMoved2;
    public bool RookMoved2 { get => rookMoved2; set => rookMoved2 = value; }


    private bool rookMoved3;
    public bool RookMoved3 { get => rookMoved3; set => rookMoved3 = value; }


    private bool rookMoved4;
    public bool RookMoved4 { get => rookMoved4; set => rookMoved4 = value; }


    private bool rooked;
    public bool Rooked { get => rooked; set => rooked = value; }






    public bool CheckEmpty(int x, int z)
    {
        if (board[x, z].GetComponent<HousesBehaviour>().myPiece == null)
        {
            return true;
        }
        return false;
    }

    public bool CheckColorPiece(int x, int z)
    {
        if (board[x, z].GetComponent<HousesBehaviour>().colorPiece == "WhitePiece")
        {
            return true;
        }
        return false;
    }


    public void PaintColor(int x, int z)
    {
        board[x, z].GetComponent<MeshRenderer>().material = selectedColor;
        board[x, z].GetComponent<HousesBehaviour>().freePiece = true;
    }

    public void PaintRookColor(int x, int z)
    {
        board[x, z].GetComponent<MeshRenderer>().material = redColor;
        board[x, z].GetComponent<HousesBehaviour>().freePiece = true;
    }


    public void ReturnColor()
    {
        for (int z = 0; z < 8; z++)
        {
            for (int x = 0; x < 8; x++)
            {
                if (board[x, z].GetComponent<HousesBehaviour>().freePiece == true)
                {
                    if (board[x, z].GetComponent<HousesBehaviour>().isWhite == true)
                    {
                        board[x, z].GetComponent<MeshRenderer>().material = whiteColor;
                    }
                    else
                    {
                        board[x, z].GetComponent<MeshRenderer>().material = blackColor;
                    }
                }
                board[x, z].GetComponent<HousesBehaviour>().freePiece = false;
            }
        }

    }

}