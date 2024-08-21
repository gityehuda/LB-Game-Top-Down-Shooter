using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MyMovementBoundary : MonoBehaviour
{
    public Rect boundary;
    private MyMoveable moveable;

    private void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }
    // Update is called once per frame
    void Update()
    {
        if(isXOutOfBoundary())
        {
            moveable.setXDirection(0f);
        }
        if(isYOutOfBoundary())
        {
            moveable.setYDirection(0f);
        }
    }

    private bool isYOutOfBoundary()
    {
        return moveable.getNextPosition().y < boundary.yMin || moveable.getNextPosition().y > boundary.yMax; ;
    }

    private bool isXOutOfBoundary()
    {
        return moveable.getNextPosition().x < boundary.xMin || moveable.getNextPosition().x > boundary.xMax;
    }
}
