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


    private void Start()
    {

        mouseEnter = false;
    }

    void Update()
    {
        if (isWhite && ReferenceController.Instance.BlackOrWhite && mouseEnter && Input.GetMouseButtonDown(0))
        {
            SelectedPiece();
        }
        else if (!isWhite && !ReferenceController.Instance.BlackOrWhite && mouseEnter && Input.GetMouseButtonDown(0))
        {
            SelectedPiece();
        }

        if (!mouseEnter && ReferenceController.Instance.IsHouseSelected && iAmSelected)
        {
            MovePieceSelected();
        }
    }

    private void SelectedPiece()
    {
        iAmSelected = true;
        ReferenceController.Instance.IsPieceSelected = true;
        ReferenceController.Instance.BlackOrWhite = !ReferenceController.Instance.BlackOrWhite;
    }

    private void MovePieceSelected()
    {
        transform.position = new Vector3(ReferenceController.Instance.housePosX, transform.position.y, ReferenceController.Instance.housePosZ);
        iAmSelected = false;
        ReferenceController.Instance.IsPieceSelected = false;
        ReferenceController.Instance.IsHouseSelected = false;
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
