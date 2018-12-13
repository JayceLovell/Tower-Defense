using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsRagdoll : MonoBehaviour {

    Rigidbody rigBod;
    static public bool deadtime = false;

    private void Start()
    {
        rigBod = GetComponent<Rigidbody>();
    }
    
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "death" || c.gameObject.tag == "enemy")
        {
            rigBod.constraints = RigidbodyConstraints.None;
            deadtime = true;
        }
    }
}
