using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyLifeUi : MonoBehaviour
{
    public TMP_Text text;
    public MyScriptableInteger lifeScriptable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = lifeScriptable.value.ToString();
    }
}
