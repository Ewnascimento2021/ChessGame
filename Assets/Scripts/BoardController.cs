using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{

    [SerializeField]
    private Transform target;
    [SerializeField]
    private GameObject blackHouse;
    [SerializeField]
    private GameObject whiteHouse;
    [SerializeField]
    private GameObject PawnWhite;
    [SerializeField]
    private GameObject RookWhite;
    [SerializeField]
    private GameObject KnightWhite;
    [SerializeField]
    private GameObject BishopWhite;
    [SerializeField]
    private GameObject QueenWhite;
    [SerializeField]
    private GameObject KingWhite;
    [SerializeField]
    private GameObject PawnBlack;
    [SerializeField]
    private GameObject RookBlack;
    [SerializeField]
    private GameObject KnightBlack;
    [SerializeField]
    private GameObject BishopBlack;
    [SerializeField]
    private GameObject QueenBlack;
    [SerializeField]
    private GameObject KingBlack;

    private GameObject[,] board;

    private float initPosX = 1.0f;
    private float initPosZ = 1.0f;
    

    private void Start()
    {
        board = new GameObject[8, 8];

        GenerateGrid();
        ReferenceController.Instance.board = board;
        CreatePiece();
    }

    void GenerateGrid()
    {
        for (int z = 0; z < 8; z++)
        {
            for (int x = 0; x < 8; x++)
            {
                float newXposition = initPosX + z;
                float newZposition = initPosZ + x;
                target.position = new Vector3(newXposition, 0f, newZposition);

                if ((z + x) % 2 == 0)
                {
                    board[z, x] = Instantiate(blackHouse, target.position, target.rotation);
                    board[z, x].GetComponent<HousesBehaviour>().isWhite = false;
                }
                else
                {
                    board[z, x] = Instantiate(whiteHouse, target.position, target.rotation);
                    board[z, x].GetComponent<HousesBehaviour>().isWhite = true;
                }

                board[z, x].name = $"Tile {z} {x}";
            }
        }
    }

    void CreatePiece()
    {
        GameObject piece;

        //Create Pawn White
        for (int x = 0; x < 8; x++)
        {
            target.position = new Vector3(initPosX + x, 0.2f, initPosZ + 1);
            piece = Instantiate(PawnWhite, target.position, target.rotation);
            piece.GetComponent<Piece>().isWhite = true;
            piece.name = "Pawn";
            piece.GetComponent<Piece>().myX = x;
            piece.GetComponent<Piece>().myZ = 1;

        }

        // Create Rook White
        target.position = new Vector3(initPosX, 0.3f, initPosZ);
        piece = Instantiate(RookWhite, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = true;
        piece.name = "Rook";

        target.position = new Vector3(initPosX + 7, 0.3f, initPosZ);
        piece = Instantiate(RookWhite, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = true;
        piece.name = "Rook";

        // Create Knight White
        target.position = new Vector3(initPosX + 1, 0.3f, initPosZ);
        piece = Instantiate(KnightWhite, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = true;
        piece.name = "Knight";

        target.position = new Vector3(initPosX + 6, 0.3f, initPosZ);
        piece = Instantiate(KnightWhite, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = true;
        piece.name = "Knight";

        // Create Bishop White
        target.position = new Vector3(initPosX + 2, 0.3f, initPosZ);
        piece = Instantiate(BishopWhite, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = true;
        piece.name = "Bishop";

        target.position = new Vector3(initPosX + 5, 0.3f, initPosZ);
        piece = Instantiate(BishopWhite, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = true;
        piece.name = "Bishop";

        // Create Queen White
        target.position = new Vector3(initPosX + 3, 0.3f, initPosZ);
        piece = Instantiate(QueenWhite, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = true;
        piece.name = "Queen";

        // Create King White
        target.position = new Vector3(initPosX + 4, 0.3f, initPosZ);
        piece = Instantiate(KingWhite, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = true;
        piece.name = "King";




        //Create Pawn Black 
        for (int x = 0; x < 8; x++)
        {
            target.position = new Vector3(initPosX + x, 0.2f, initPosZ + 6);
            piece = Instantiate(PawnBlack, target.position, target.rotation);
            piece.GetComponent<Piece>().isWhite = false;
            piece.name = "Pawn";
        }
        // Create Rook Black
        target.position = new Vector3(initPosX, 0.3f, initPosZ + 7);
        piece = Instantiate(RookBlack, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = false;
        piece.name = "Rook";

        target.position = new Vector3(initPosX + 7, 0.3f, initPosZ + 7);
        piece = Instantiate(RookBlack, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = false;
        piece.name = "Rook";

        // Create Knight Black
        target.position = new Vector3(initPosX + 1, 0.3f, initPosZ + 7);
        piece = Instantiate(KnightBlack, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = false;
        piece.name = "Knight";

        target.position = new Vector3(initPosX + 6, 0.3f, initPosZ + 7);
        piece = Instantiate(KnightBlack, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = false;
        piece.name = "Knight";

        // Create Bishop Black
        target.position = new Vector3(initPosX + 2, 0.3f, initPosZ + 7);
        piece = Instantiate(BishopBlack, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = false;
        piece.name = "Bishop";

        target.position = new Vector3(initPosX + 5, 0.3f, initPosZ + 7);
        piece = Instantiate(BishopBlack, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = false;
        piece.name = "Bishop";

        // Create Queen Black
        target.position = new Vector3(initPosX + 3, 0.3f, initPosZ + 7);
        piece = Instantiate(QueenBlack, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = false;
        piece.name = "Queen";

        // Create King Black
        target.position = new Vector3(initPosX + 4, 0.3f, initPosZ + 7);
        piece = Instantiate(KingBlack, target.position, target.rotation);
        piece.GetComponent<Piece>().isWhite = false;
        piece.name = "King";
    }
}

