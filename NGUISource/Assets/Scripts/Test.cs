using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    Transform a, b;
    void Start()
    {
        var t = GetComponentInParent<Test>();
        a = new GameObject().transform;
        b = new GameObject().transform;
        a.SetParent(transform);
        b.SetParent(transform);
        a.localPosition = Vector3.zero;
        a.localScale = Vector3.one;
        b.localScale = Vector3.one;
        b.localPosition = new Vector3(100, 0, 0);
        a.name = "a";
        b.name = "b";
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void OnGUI()
    {
        if(GUILayout.Button("线性插值"))
        {
            Debug.Log("线性插值。");
            Vector3 pos = Vector3.LerpUnclamped(a.localPosition, b.localPosition,-1.5f); 
            Transform c = new GameObject().transform;
            c.SetParent(transform);
            c.localPosition = pos;
            c.localScale = Vector3.one;
            c.name = "c";
        }
    }
}
