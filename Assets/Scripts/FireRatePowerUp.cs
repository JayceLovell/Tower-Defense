using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRatePowerUp : MonoBehaviour {

    Turret turret;
    float duration = 3.0f;

	// Use this for initialization
	void Start () {
        turret = gameObject.GetComponent<Turret>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
