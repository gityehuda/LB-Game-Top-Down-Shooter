using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MyTravelDistanceLimit : MonoBehaviour
{
    public float maxTravelDistance;
    private float travelDistance;
    private MyMoveable moveable;
    private MyPoolObject poolObject;

    private void Awake()
    {
       moveable = GetComponent<MyMoveable>();
       poolObject = GetComponent<MyPoolObject>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(travelDistance >= maxTravelDistance)
        {
            if(poolObject != null)
            {
                poolObject.deactivate();
            } 
            else
            {
                Destroy(gameObject);
            }
        }

        travelDistance += moveable.newPosition().magnitude;
    }

    private void OnEnable()
    {
        travelDistance = 0;
    }
}
