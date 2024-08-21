using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MoveForward : MonoBehaviour
{
    private MyMoveable moveable;

    // Start is called before the first frame update
    private void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    // Update is called once per frame
    void Update()
    {
        moveable.setDirection(transform.right);
    }
}
