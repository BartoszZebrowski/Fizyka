using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Vector2 position, prevPosition;
    public bool isLocked;


    private void Update()
    {   
        transform.position = position;
    }
}
