using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPiece : MonoBehaviour
{

    [SerializeField]
    private GameObject pieceType;

    private bool mouseEnter;
    private bool iAmSelected;
    public bool isWhite;
    public bool selectPiece;

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
        if (isWhite && ReferenceController.Instance.BlackOrWhite)
        {
            if (mouseEnter && Input.GetMouseButtonDown(0))
            {
                selectPiece = true;
                ReferenceController.Instance.IsPieceSelected = true;
                iAmSelected = true;
                ReferenceController.Instance.BlackOrWhite = false;
            }
        }

        else if (!isWhite && !ReferenceController.Instance.BlackOrWhite)
        {
            if (mouseEnter && Input.GetMouseButtonDown(0))
            {
                selectPiece = true;
                ReferenceController.Instance.IsPieceSelected = true;
                iAmSelected = true;
                ReferenceController.Instance.BlackOrWhite = true;
            }
        }
          

        else if (!mouseEnter && ReferenceController.Instance.IsHouseSelected && iAmSelected)
        {

            transform.position = new Vector3(ReferenceController.Instance.housePosX, transform.position.y, ReferenceController.Instance.housePosZ);
            iAmSelected = false;
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
