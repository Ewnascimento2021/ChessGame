using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{

    [SerializeField]
    private GameObject pieceType;

    private bool mouseEnter;
    public bool iAmSelected;
    public bool isWhite;
    public int myOldX;
    public int myOldZ;
    public int myX;
    public int myZ;


    private void Start()
    {
        mouseEnter = false;
        myOldX = (int)transform.position.x - 1;
        myOldZ = (int)transform.position.z - 1;

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

        if (ReferenceController.Instance.IsHouseSelected && iAmSelected)
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
        myOldX = myX;
        myOldZ = myZ;
        myX = (int)transform.position.x - 1;
        myZ = (int)transform.position.z - 1;
        iAmSelected = false;
        ReferenceController.Instance.IsPieceSelected = false;
        ReferenceController.Instance.IsHouseSelected = false;
        ReferenceController.Instance.ReturnColor();

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
