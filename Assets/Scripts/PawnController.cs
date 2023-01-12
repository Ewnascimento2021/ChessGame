using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PawnController : MonoBehaviour
{
    private Rigidbody rb;
    private bool objectSelect;
    [SerializeField]
    private int selectObjectEixoY;
    private bool checkSelect;
    private bool isMouseInside;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            rb.position = new Vector3(rb.position.x, selectObjectEixoY, rb.position.z);
            rb.useGravity = false;
            checkSelect = false;
        }
        if (objectSelect == false)
        {
            rb.useGravity = true;
            checkSelect = true;
        }
    }

    private void testSelect()
    {
        if (Input.GetMouseButtonDown(0) && checkSelect && isMouseInside)
        {
            objectSelect = true;
        }

        if (Input.GetMouseButtonDown(0) && !checkSelect && !isMouseInside)
        {
            objectSelect = false;
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
