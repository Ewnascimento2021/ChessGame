using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnPassant : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        EnPassanted();
    }

    private void EnPassanted()
    {
        int contX = gameObject.GetComponent<PieceController>().myX;
        int contZ = gameObject.GetComponent<PieceController>().myZ;

        if (gameObject.GetComponent<PieceController>().isWhite && gameObject.GetComponent<PieceController>().myZ == 6 )
        {

        }
    }
}
