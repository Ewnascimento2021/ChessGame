using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManeger : MonoBehaviour
{
    public LayerMask boardLayer;
    bool clicked;
    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray screenRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(screenRay, out hit, Mathf.Infinity, boardLayer))
            {
                float minX = Mathf.Floor(hit.point.x);
                float maxX = Mathf.Ceil(hit.point.x);
                float newX = (minX + maxX) / 2;

                float minZ = Mathf.Floor(hit.point.z);
                float maxZ = Mathf.Ceil(hit.point.z);
                float newZ = (minZ + maxZ) / 2;

                targetPosition = new Vector3(newX, 0, newZ);

                Debug.Log(targetPosition);

            }
        }
    }
}
