using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public Point[] points;
    public Stick[] sticks;
    public float graviti;


    void Simulate()
    {
        foreach(Point p in points)
        {
            if (!p.isLocked)
            {
                Vector2 positionBeforeUpdate = p.position;
                p.position += p.position - p.prevPosition;
                p.position += Vector2.down * graviti * Time.deltaTime * Time.deltaTime;
                p.prevPosition = positionBeforeUpdate;
            }
        }

        foreach (Stick stick in sticks)
        {
            Vector2 stickCentre = (stick.pointA.position + stick.pointB.position) / 2;
            Vector2 stickDir = (stick.pointB.position - stick.pointB.position).normalized;
            if (!stick.pointA.isLocked)
                stick.pointA.position = stickCentre + stickDir * stick.lenght / 2;
            if (!stick.pointB.isLocked)
                stick.pointB.position = stickCentre + stickDir * stick.lenght / 2;

        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Simulate();
    }
}
