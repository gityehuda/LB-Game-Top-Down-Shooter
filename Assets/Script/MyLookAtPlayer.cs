using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLookAtPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAt();
    }

    void LookAt()
    {
        if(MyCode.GameManager.GetInstance().activePlayer != null)
        {
            transform.right = MyCode.GameManager.GetInstance().activePlayer.transform.position - transform.position;
        }
    }
}
