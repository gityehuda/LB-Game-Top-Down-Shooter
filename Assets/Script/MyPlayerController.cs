using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MyPlayerController : MonoBehaviour
{
    public MyInputHandler myInputHandler;
    private MyMoveable moveable;
    // Start is called before the first frame update
    void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSetDirect(Vector2 direction)
    {
        Debug.Log("OnSetDirect");
        moveable.setDirection(direction);
    }

    private void OnEnable()
    {
        myInputHandler.OnSetDirectionAction += OnSetDirect;
    }

    private void OnDisable()
    {
        myInputHandler.OnSetDirectionAction -= OnSetDirect;
    }
}
