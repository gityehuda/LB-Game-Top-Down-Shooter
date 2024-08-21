using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameOverController : MonoBehaviour
{
   public void gameOver()
    {
        MyCode.GameManager.GetInstance().gameOver();
    }

}
