using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MyLife))]
public class MyLifeEditor : Editor
{
    private MyLife life;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        life = (MyLife)target;
        life.useScriptable = EditorGUILayout.Toggle("Use Scriptable?", life.useScriptable);
        if (life.useScriptable)
        {
            life.lifeScriptable = (MyScriptableInteger)EditorGUILayout.ObjectField("Life", life.lifeScriptable, typeof(MyScriptableInteger), true);
            life.maxLifeScriptable = (MyScriptableInteger)EditorGUILayout.ObjectField("Max Life", life.maxLifeScriptable, typeof(MyScriptableInteger), true);
        }
        else
        {
            life.life = EditorGUILayout.IntField("Life", life.life);
            life.maxLife = EditorGUILayout.IntField("Max Life", life.maxLife);
        }
    }

}
