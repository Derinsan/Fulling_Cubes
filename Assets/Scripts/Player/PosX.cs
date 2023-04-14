using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosX : MonoBehaviour
{
    private float minX, maxX;

    void Start()
    {
        minX = -1.6f;
        maxX = 1.6f;
    }

    public void ControllObject()
    {
        if (transform.position.x < minX)
        {
            transform.position = new Vector2(minX, transform.position.y);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }
    }
}
