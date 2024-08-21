using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObjectPool : MonoBehaviour
{
    private static MyObjectPool instance;
    public int size;
    public GameObject[] prefabs;
    public List<MyPoolObject> poolObjects;

    // Start is called before the first frame update
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static MyObjectPool GetInstance()
    {
        return instance;
    }

    void Start()
    {
        instantiateObjects();
    }

    private void instantiateObjects()
    {
        poolObjects = new List<MyPoolObject>();
        for(int i = 0; i < size; i++)
        {
            foreach(GameObject go in prefabs)
            {
                poolObjects.Add(Instantiate(go, transform).GetComponent<MyPoolObject>());
            }
        }
    }

    public MyPoolObject requestObject(MyPoolObjectType type)
    {
        foreach(MyPoolObject po in poolObjects)
        {
            if(po.type == type && !po.isActive())
            {
                return po;
            }
        }
        return null;
    }

    public void deactivateAllObject()
    {
        foreach(MyPoolObject po in poolObjects)
        {
            po.deactivate();
        }
    }

}
