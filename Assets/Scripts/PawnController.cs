using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PawnController : MonoBehaviour
{

    private bool objectSelect;
    private bool checkSelect;
    private bool isMouseInside;
    public Vector3 targetPosition;
    public float speed = 10;


    // Start is called before the first frame update
    void Start()
    {
        objectSelect = false;
        checkSelect = false;
        isMouseInside = false;
    }

    // Update is called once per frame
    void Update()
    {
        testSelect();

        if (objectSelect == true)
        {
            checkSelect = false;
        }
        if (objectSelect == false)
        {
            checkSelect = true;
        }
    }

    private void testSelect()
    {
        if (Input.GetMouseButtonDown(0) && checkSelect && isMouseInside)
        {
            objectSelect = true;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            Debug.Log(objectSelect);
        }

        if (Input.GetMouseButtonDown(0) && !checkSelect && !isMouseInside)
        {
            objectSelect = false;
            Debug.Log(objectSelect);
        }
    }

    private void OnMouseEnter()
    {
        isMouseInside = true;
    }

    private void OnMouseExit()
    {
        isMouseInside = false;
    }

}
