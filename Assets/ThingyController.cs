using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class ThingyController : MonoBehaviour {
    public bool showHealth = true;
    public float health = 80;
	

}
[CustomEditor(typeof(ThingyEditor))]
public class ThingyEditor : Editor {

    void OnsSceneGUI()
    {
        ThingyController thingy = (ThingyController)target;
        Handles.DrawWireCube(thingy.transform.position, Vector3.one);

    }
   public override void OnInspectorGUI()
    {
        ThingyController thingy = (ThingyController)target;

//        base.OnInspectorGUI();
        serializedObject.Update();

       thingy.showHealth = EditorGUILayout.Toggle("Show Health", thingy.showHealth);
        if (thingy.showHealth)
        {
            thingy.health = EditorGUILayout.FloatField("How Health I am", thingy.health);
        }
        EditorGUILayout.ColorField(Color.white);
        //EditorGUILayout.CurveField()
        if(GUILayout.Button("CLICK ME!"))
        {

        }
            serializedObject.ApplyModifiedProperties();
    }

}
