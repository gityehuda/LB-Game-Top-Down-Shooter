using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyTriggerEvent : MonoBehaviour
{
    public UnityEvent OnTrigger;
    public string targetTag;
    public UnityEvent<GameObject> OnTriggerWithGameobject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == targetTag)
        {
            OnTrigger?.Invoke();
            OnTriggerWithGameobject?.Invoke(collision.gameObject);
        }
    }

}
