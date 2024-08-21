using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDestroyable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void destroyObject()
    {
        Destroy(gameObject);
    }
}
