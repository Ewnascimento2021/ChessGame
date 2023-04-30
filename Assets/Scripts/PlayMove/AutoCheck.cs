using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;

public class AutoCheck : MonoBehaviour
{
    private int xPlusZplusX;
    private int xPlusZplusZ;

    private void Start()
    {
        xPlusZplusX = gameObject.GetComponent<PieceController>().myX + 1;
        xPlusZplusZ = gameObject.GetComponent<PieceController>().myZ + 1;
    }
    void Update()
    {
        AutoCheckCheck();
    }

    private void AutoCheckCheck()
    {


    }
}
