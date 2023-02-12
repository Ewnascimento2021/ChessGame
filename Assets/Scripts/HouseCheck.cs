using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCheck : MonoBehaviour
{
    public bool houseSelect;
    private bool houseEnter;
    private bool selectPiece;

    public Transform house;

    private void Start()
    {

    }
    private void Update()
    {
        selectPiece = GetComponent<SelectPiece>().selectPiece;

        if (selectPiece == true)
        {
            selectHouse();
        }
    }
        

    private void selectHouse()
    {
        if (houseEnter == true && Input.GetMouseButtonDown(0))
        {
            houseSelect = true;
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
}
