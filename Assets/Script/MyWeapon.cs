using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon : MonoBehaviour
{
    public float fireRate;
    private float timer = 0;
    public MyPoolObjectType type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime > 0 ? timer - Time.deltaTime : 0;
    }

    public void shoot()
    {
        if(timer == 0f)
        {
            Debug.Log("fire");
            MyObjectPool.GetInstance().requestObject(type).activate(transform.position, transform.rotation);
            timer = fireRate / getFireRateModifier();
        }
    }

    public List<float> fireRateModifier;

    private float getFireRateModifier()
    {
        float mod = 1;

        foreach(float f in fireRateModifier)
        {
            mod += f;
        }
        return mod;
    }

    internal void addFireRateModifier(float modifier)
    {
        fireRateModifier.Add(modifier);
    }

    internal void clearModifier()
    {
        fireRateModifier.Clear();
    }

    internal void removeFireRateModifier(float modifier)
    {
        fireRateModifier.Remove(modifier);
    }

}
