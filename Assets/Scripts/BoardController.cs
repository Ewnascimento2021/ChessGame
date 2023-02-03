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
        for (int x = 0; x < 8; x++)
        {
            target.position = new Vector3(initPosX + x, 0.2f, initPosZ + 1);

            board[1, x] = Instantiate(PawnWhite,target.position, target.rotation);
        }

    }
}

