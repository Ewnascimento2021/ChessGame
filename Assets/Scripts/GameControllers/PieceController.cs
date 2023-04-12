using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
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
    public bool isPainting = false;
    public bool firstMove;
    


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
        else if (iAmSelected && !mouseEnter && Input.GetMouseButtonDown(0))
        {
            cancelSelect();
        }
    }

    private void SelectedPiece()
    {
        iAmSelected = true;
        isPainting = true;
        ReferenceController.Instance.IsPieceSelected = true;
        gameObject.GetComponent<MeshRenderer>().material = ReferenceController.Instance.blueColor;
    }

    private void MovePieceSelected()
    {
        transform.position = new Vector3(ReferenceController.Instance.housePosX, transform.position.y, ReferenceController.Instance.housePosZ);
        myOldX = myX;
        myOldZ = myZ;
        myX = (int)transform.position.x - 1;
        myZ = (int)transform.position.z - 1;
        firstMove = true;
        iAmSelected = false;
        ReferenceController.Instance.IsPieceSelected = false;
        ReferenceController.Instance.IsHouseSelected = false;
        gameObject.GetComponent<MeshRenderer>().material = ReferenceController.Instance.chessMaterial;
        ReferenceController.Instance.BlackOrWhite = !ReferenceController.Instance.BlackOrWhite;
        ReferenceController.Instance.ReturnColor();
        ReferenceController.Instance.rotateCamera = !ReferenceController.Instance.rotateCamera;
        ReferenceController.Instance.RotateCamera();


    }

    private void cancelSelect()
    {
        ReferenceController.Instance.IsPieceSelected = false;
        ReferenceController.Instance.ReturnColor();
        iAmSelected = false;
        gameObject.GetComponent<MeshRenderer>().material = ReferenceController.Instance.chessMaterial;
    }



    private void OnMouseEnter()
    {
        mouseEnter = true;
    }
    private void OnMouseExit()
    {
        mouseEnter = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (isWhite && !ReferenceController.Instance.BlackOrWhite)
        {
            if (other.gameObject.CompareTag("BlackPiece"))
            {
                Destroy(other.gameObject);
            }
        }
        if (!isWhite && ReferenceController.Instance.BlackOrWhite)
        {
            if (other.gameObject.CompareTag("WhitePiece"))
            {
                Destroy(other.gameObject);
            }
        }
    }
}
