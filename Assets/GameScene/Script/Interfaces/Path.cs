using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour {
    public GameObject fromObj, toObj;
    private LineRenderer line;
	// Use this for initialization
	void Start () {
        
    }
    private void OnEnable()
    {
        line = transform.GetComponent<LineRenderer>();
        line.startWidth = 0.05f;
        line.endWidth = 0.05f;
        line.positionCount = 2;
    }

    // Update is called once per frame
    void Update () {
        drawLine();
	}
    public void drawLine()
    {
        if (fromObj != null & toObj != null)
        {
            
            line.SetPosition(0, fromObj.transform.position);
            line.SetPosition(1, toObj.transform.position);
        }
    }
}
