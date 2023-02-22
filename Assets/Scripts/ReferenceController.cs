using System.Collections;
using System.Collections.Generic;
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





    private void Update()
    {
        if (isPieceSelected)
        {
            for (int z = 0; z < 8; z++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (board[x, z].GetComponent<HousesBehaviour>().myPiece != null)
                    {
                        if (board[x, z].GetComponent<HousesBehaviour>().myPiece.GetComponent<Piece>().iAmSelected)
                        {
                            // TODO: RayLight da peça selecionada
                            // board[x, z].GetComponent<MeshRenderer>().material = selectedColor;
                        }
                    }

                }
            }
        }
    }

    public bool CheckEmpty(int x, int z)
    {
        if (board[x, z].GetComponent<HousesBehaviour>().myPiece == null)
        {
            return true;
        }
        return false;

    }

    public void PaintColor(int x, int z)
    {
        board[x, z].GetComponent<MeshRenderer>().material = selectedColor;
    }
}