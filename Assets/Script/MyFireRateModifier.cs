using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MyFireRateModifier : MonoBehaviour
{
    public float modifier = 3f;
    private List<MyWeapon> weapon;

    private void Awake()
    {
        weapon = GetComponentsInChildren<MyWeapon>().ToList<MyWeapon>();
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach(MyWeapon w in weapon)
        {
            w.addFireRateModifier(modifier);
        }
    }

    private void OnDestroy()
    {
        foreach(MyWeapon w in weapon)
        {
            w.removeFireRateModifier(modifier);
        }
    }

    public void addComponentToObject(GameObject go)
    {
        go.AddComponent<MyFireRateModifier>();
        go.GetComponent<MyWeaponSetController>().weaponUpgradeCheck();
    }

}
