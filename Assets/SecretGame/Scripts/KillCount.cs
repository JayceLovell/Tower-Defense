using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCount : MonoBehaviour {

    TextMesh text;
    public static int kcount = 0;

	// Use this for initialization
	void Start () {
        text = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "KILL COUNT: " + kcount;

    }
}
