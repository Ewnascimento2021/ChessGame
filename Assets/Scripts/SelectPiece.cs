using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPiece : MonoBehaviour
{
    public bool selectPiece;
    private bool mouseEnter;

    [SerializeField]
    private GameObject pieceType;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SelectedPiece();
    }

    private void SelectedPiece()
    {
        if (mouseEnter && Input.GetMouseButtonDown(0))
        {
            selectPiece = true;
            Debug.Log(selectPiece);
        }

        else if (!mouseEnter && selectPiece && Input.GetMouseButtonDown(0) && GetComponent<HouseCheck>().houseSelect == true)
        {
            transform.position = GetComponent<HouseCheck>().house.position;
        }
        else
        {
            selectPiece = false;
            Debug.Log(selectPiece);
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
