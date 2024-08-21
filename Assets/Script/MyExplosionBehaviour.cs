using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyExplosionBehaviour : MonoBehaviour
{
    private Animator animator;
    private MyPoolObject poolObject;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        poolObject = GetComponent<MyPoolObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(poolObject.isActive())
        {
            if(animationIsDone())
            {
                poolObject.deactivate();
            }
        }
    }

    private bool animationIsDone()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !animator.IsInTransition(0))
        {
            return true;
        }
        return false;
    }

}
