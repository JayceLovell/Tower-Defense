using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float movespeed;

    private bool alive = true;

    void Update()
    {
        if (!OutOfBoundsRagdoll.deadtime)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical1") * movespeed);
            transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal1") * movespeed);
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "death")
        {
            alive = false;
        }
    }

}
