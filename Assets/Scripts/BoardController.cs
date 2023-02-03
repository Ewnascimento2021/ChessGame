using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [SerializeField]
    private GameObject blackHouse;
    [SerializeField]
    private GameObject whiteHouse;
    [SerializeField]
    private Transform target;
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
        CreatePiece();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int z = 0; z < 8; z++)
            {
                float newXposition = initPosX + x;
                float newZposition = initPosZ + z;
                target.position = new Vector3(newXposition, 0f, newZposition);

                if ((x + z) % 2 == 0)
                {
                    board[x, z] = Instantiate(blackHouse, target.position, target.rotation);
                    board[x, z].GetComponent<HousesBehaviour>().isWhite = false;
                }
                else
                {
                    board[x, z] = Instantiate(whiteHouse, target.position, target.rotation);
                    board[x, z].GetComponent<HousesBehaviour>().isWhite = true;
                }

                board[x, z].name = $"Tile {x} {z}";
            }
        }
    }

    void CreatePiece()
    {

        //Create Pawn White
        for (int x = 0; x < 8; x++)
        {
            target.position = new Vector3(initPosX + x, 0.2f, initPosZ + 1);
            Instantiate(PawnWhite,target.position, target.rotation);
        }

        // Create Rook White
        target.position = new Vector3(initPosX, 0.3f, initPosZ);
        Instantiate(RookWhite, target.position, target.rotation);

        target.position = new Vector3(initPosX + 7, 0.3f, initPosZ);
        Instantiate(RookWhite, target.position, target.rotation);

        // Create Knight White
        target.position = new Vector3(initPosX + 1, 0.3f, initPosZ);
        Instantiate(KnightWhite, target.position, target.rotation);

        target.position = new Vector3(initPosX + 6, 0.3f, initPosZ);
        Instantiate(KnightWhite, target.position, target.rotation);

        // Create Bishop White
        target.position = new Vector3(initPosX + 2, 0.3f, initPosZ);
        Instantiate(BishopWhite, target.position, target.rotation);

        target.position = new Vector3(initPosX + 5, 0.3f, initPosZ);
        Instantiate(BishopWhite, target.position, target.rotation);

        // Create Queen White
        target.position = new Vector3(initPosX + 3, 0.3f, initPosZ);
        Instantiate(QueenWhite, target.position, target.rotation);

        // Create King White
        target.position = new Vector3(initPosX + 4, 0.3f, initPosZ);
        Instantiate(KingWhite, target.position, target.rotation);




        //Create Pawn Black 
        for (int x = 0; x < 8; x++)
        {
            target.position = new Vector3(initPosX + x, 0.2f, initPosZ + 6);
            Instantiate(PawnBlack, target.position, target.rotation);
        }
        // Create Rook Black
        target.position = new Vector3(initPosX, 0.3f, initPosZ + 7);
        Instantiate(RookBlack, target.position, target.rotation);

        target.position = new Vector3(initPosX + 7, 0.3f, initPosZ + 7);
        Instantiate(RookBlack, target.position, target.rotation);

        // Create Knight Black
        target.position = new Vector3(initPosX + 1, 0.3f, initPosZ + 7);
        Instantiate(KnightBlack, target.position, target.rotation);

        target.position = new Vector3(initPosX + 6, 0.3f, initPosZ + 7);
        Instantiate(KnightBlack, target.position, target.rotation);

        // Create Bishop Black
        target.position = new Vector3(initPosX + 2, 0.3f, initPosZ + 7);
        Instantiate(BishopBlack, target.position, target.rotation);

        target.position = new Vector3(initPosX + 5, 0.3f, initPosZ + 7);
        Instantiate(BishopBlack, target.position, target.rotation);

        // Create Queen Black
        target.position = new Vector3(initPosX + 3, 0.3f, initPosZ + 7);
        Instantiate(QueenBlack, target.position, target.rotation);

        // Create King Black
        target.position = new Vector3(initPosX + 4, 0.3f, initPosZ + 7);
        Instantiate(KingBlack, target.position, target.rotation);






    }
}

