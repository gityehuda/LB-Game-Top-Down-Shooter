using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeaponUpgrade : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void addComponentToObject(GameObject go)
    {
        
        go.AddComponent<MyWeaponUpgrade>();
        go.GetComponent<MyWeaponSetController>().weaponUpgradeCheck();
        Debug.Log("Weapon Upgraded");
    }

}
