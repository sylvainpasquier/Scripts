using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;


    // Update is called once per frame
    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);

        }

        if (Door.transform.position.y > 7f)
        {
            doorIsOpening = false;

        }

    }

    void OnMouseDown()
    {
        doorIsOpening = true;

    }
}
