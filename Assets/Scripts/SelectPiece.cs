using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPiece : MonoBehaviour
{

    [SerializeField]
    private GameObject pieceType;

    public bool selectPiece;
    private bool mouseEnter;
    private bool iAmSelected;
    private float xPos;
    private float zPos;

    private void Start()
    {
        selectPiece = false;
        mouseEnter = false;
    }

    void Update()
    {
        SelectedPiece();
    }

    private void SelectedPiece()
    {
        if (mouseEnter && Input.GetMouseButtonDown(0))
        {
            selectPiece = true;
            xPos = transform.position.x;
            zPos = transform.position.z;
            ReferenceController.Instance.IsPieceSelected = true;
            iAmSelected= true;
        }


        else if (!mouseEnter && ReferenceController.Instance.IsHouseSelected && iAmSelected)
        {

            transform.position = new Vector3(ReferenceController.Instance.housePosX, transform.position.y, ReferenceController.Instance.housePosZ);
            iAmSelected= false;
            ReferenceController.Instance.IsPieceSelected = false;
            ReferenceController.Instance.IsHouseSelected = false;

        }
        else
        {
            selectPiece = false;
        }
    }

    private void OnMouseEnter()
    {
        mouseEnter = true;
    }
    private void OnMouseExit()
    {
        mouseEnter = false;
    }
}
