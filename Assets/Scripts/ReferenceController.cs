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

   
    

}
