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
    private bool test;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        objectSelect = false;
        test = true;

    }

    // Update is called once per frame
    void Update()
    {
        testSelect();

        if (objectSelect == true)
        {
            rb.position = new Vector3(rb.position.x, selectObjectEixoY, rb.position.z);
            rb.useGravity = false;
            test = false;
        }
        if (objectSelect == false)
        {
            rb.useGravity = true;
            test = true;
        }
    }

    private void testSelect()
    {
        if (Input.GetMouseButtonDown(0) && test == true)
        {
            objectSelect = true;
        }

        if (Input.GetMouseButtonDown(0) && test == false)
        {
            objectSelect = false;
        }
    }
}
