using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class MyContainItem : MonoBehaviour
{
    public List<MyObjectSpawnRate> objects;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void spawnItemOnDeath()
    {
        GameObject go = getItem();
        //Instantiate(go);
        if(go != null )
        {
            MyCode.GameManager.GetInstance().addItem(Instantiate(go, transform.position, Quaternion.identity));
        }
    }

    private GameObject getItem()
    {
        int limit = 0;

        foreach(MyObjectSpawnRate osr in objects)
        {
            limit += osr.rate;
        }

        int random = Random.Range(0, limit);

        foreach(MyObjectSpawnRate osr in objects)
        {
            if(random < osr.rate)
            {
                return osr.prefab;
            }
            else
            {
                random -= osr.rate;
            }
        }

        return null;

    }

}
