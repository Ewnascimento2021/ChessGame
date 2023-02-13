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

    private bool isPieceSelected;

    private bool isHouseSelected;
    public bool IsPieceSelected { get => isPieceSelected; set => isPieceSelected = value; }
    public bool IsHouseSelected { get => isHouseSelected; set => isHouseSelected = value; }

    public float housePosX;
    public float housePosZ;
    public GameObject[,] board;


    void Start()
    {

    }


    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    board[2, 2].gameObject.GetComponent<HousesBehaviour>().typePiece = "Flyngons";
        //    Debug.Log(board[2, 2].gameObject.GetComponent<HousesBehaviour>().typePiece);
        //}
        
    }

   
   



}
