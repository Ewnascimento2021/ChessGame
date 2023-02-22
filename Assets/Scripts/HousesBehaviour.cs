using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousesBehaviour : MonoBehaviour
{
    public bool isWhite;
    public string colorPiece = "Empty";
    private bool houseEnter;
    public GameObject myPiece = null;

    public Transform house;

    private void Start()
    {

    }
    private void Update()
    {

        if (ReferenceController.Instance.IsPieceSelected)
        {
            selectHouse();
        }
    }


    private void selectHouse()
    {
        if (houseEnter == true && Input.GetMouseButtonDown(0))
        {
            ReferenceController.Instance.IsHouseSelected = true;
            ReferenceController.Instance.housePosX = transform.position.x;
            ReferenceController.Instance.housePosZ = transform.position.z;
        }
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
    }
    private void OnCollisionExit(Collision other)
    {
        colorPiece = "Empty";
        myPiece = null;
    }
}
