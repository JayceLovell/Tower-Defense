using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;

    public Transform[] spawn;

    public float spawntime;
    public float decrease;

    // Use this for initialization
    void Start () {
        StartCoroutine("Spawner");
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("r"))
        {
            OutOfBoundsRagdoll.deadtime = false;
            KillCount.kcount = 0;
            SceneManager.LoadScene("SwordScene");
        }

	}

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawntime);

            if(spawntime < 1 && spawntime > 0.5)
            {
                decrease = 0.99f;
            }
            if (spawntime < 0.5)
            {
                decrease = 0.995f;
            }
            spawntime *= decrease;

            Instantiate(enemy, spawn[Random.Range(0, spawn.Length)]);
        }
        
    }
}
