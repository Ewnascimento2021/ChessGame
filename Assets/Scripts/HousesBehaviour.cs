using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousesBehaviour : MonoBehaviour
{
    public bool isWhite;
    public string typePiece = "Empty";
    private bool houseEnter;


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
            typePiece = other.gameObject.tag;
    }
    private void OnCollisionExit(Collision other)
    {
        typePiece = "Empty";
    }
}
