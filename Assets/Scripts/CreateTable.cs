using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTable : MonoBehaviour
{
    [SerializeField]
    private GameObject blackHouse;

    [SerializeField]
    private GameObject whiteHouse;

    [SerializeField]
    private Transform target;

    private GameObject[,] board;

    private float initPosX = 1.0f;
    private float initPosZ = 1.0f;

    private void Start()
    {
        board = new GameObject[8, 8];

        GenerateGrid();
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
                }
                else
                {
                    board[x, z] = Instantiate(whiteHouse, target.position, target.rotation);
                }

                board[x,z].name = $"Tile {x} {z}";

            }
        }
    }
}
