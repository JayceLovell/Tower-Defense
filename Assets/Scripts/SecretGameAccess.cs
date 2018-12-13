using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretGameAccess : MonoBehaviour {
    
	void Update () {
        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene("SwordScene");
        }
    }
}
