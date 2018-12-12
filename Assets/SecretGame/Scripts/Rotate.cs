using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float rotatespeed;

    

    void Update () {

        if (!OutOfBoundsRagdoll.deadtime)
        {
            var x = Input.GetAxis("Horizontal2") * Time.deltaTime * rotatespeed;
            transform.Rotate(0, x, 0);
        }
    

	}

}
