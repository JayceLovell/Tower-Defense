using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBarrier : MonoBehaviour {

   
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
