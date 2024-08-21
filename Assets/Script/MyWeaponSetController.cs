using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeaponSetController : MonoBehaviour
{
    public GameObject[] weaponSet;
    public int upgradeLevel;

    // Start is called before the first frame update
    void Start()
    {
        deactivateAllWeapons();
        activateWeaponSet(0);
        weaponUpgradeCheck();
    }

    private void deactivateAllWeapons()
    {
        foreach(GameObject go in weaponSet)
        {
            go.SetActive(false);
        }
    }

    public void activateWeaponSet(int upgradeLevel)
    {
        for(int i = 0; i < weaponSet.Length; i++)
        {
            if(i == upgradeLevel)
            {
                weaponSet[i].SetActive(true);
            }
            else
            {
                weaponSet[i].SetActive(false);
            }
        }
    }

    public void weaponUpgradeCheck()
    {
        upgradeLevel = GetComponents<MyWeaponUpgrade>().Length;

        if(upgradeLevel >= weaponSet.Length) 
        {
            upgradeLevel = weaponSet.Length - 1;
        }
        activateWeaponSet(upgradeLevel);
        fireRateUpdate();
    }

    private void fireRateUpdate()
    {
        foreach(MyWeapon w in GetComponentsInChildren<MyWeapon>())
        {
            w.clearModifier();
            foreach(MyFireRateModifier f in GetComponents<MyFireRateModifier>())
            {
                w.addFireRateModifier(f.modifier);
            }
        }  
    }

}
