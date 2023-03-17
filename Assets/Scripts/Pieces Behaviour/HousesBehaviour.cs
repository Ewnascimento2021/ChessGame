using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousesBehaviour : MonoBehaviour
{
    public GameObject myPiece = null;
    public string myPieceName;
    public Transform house;
    public bool freePiece;
    public bool freeCkeck;
    public bool isWhite;
    public int myHouseX;
    public int myHouseZ;
    public string colorPiece = "Empty";
    private bool houseEnter;

    private void Update()
    {
        if (ReferenceController.Instance.IsPieceSelected && houseEnter && Input.GetMouseButtonDown(0) && freePiece)
        {
            selectHouse();
        }
    }


    private void selectHouse()
    {
        ReferenceController.Instance.IsHouseSelected = true;
        ReferenceController.Instance.housePosX = transform.position.x;
        ReferenceController.Instance.housePosZ = transform.position.z;
    }

    private void OnMouseEnter()
    {
        houseEnter = true;
    }

    private void OnMouseExit()
    {
        houseEnter = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        colorPiece = other.gameObject.tag;
        myPiece = other.gameObject;
        myPieceName = other.gameObject.name;
    }

    private void OnCollisionExit(Collision other)
    {
        colorPiece = "Empty";
        myPiece = null;
        myPieceName = null;
    }
}
