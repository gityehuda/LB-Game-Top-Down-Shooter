using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "My New Scriptable Integer", menuName = "My Scriptable Variable/Integer")]
public class MyScriptableInteger : ScriptableObject
{
    public int value;
    public int defaultValue;
    public bool resetOnEnable;

    private void OnEnable()
    {
        if(resetOnEnable)
        {
            reseet();
        }
    }

    internal void reseet()
    {
        value = defaultValue;
    }

}
