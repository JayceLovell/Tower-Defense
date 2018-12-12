using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    
    NavMeshAgent navAgent;
    NavMeshObstacle navOb;
    AudioSource audio;
    public AudioClip[] sounds;
    private bool audioPlayed = false;

    private bool alive = true;
    GameObject player;

    // Use this for initialization
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        navOb = GetComponent<NavMeshObstacle>();
        audio = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            navAgent.destination = player.transform.position;
        }
        else
        {
            StartCoroutine("despawn");
        }
        
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "sword")
        {
            if (alive && OutOfBoundsRagdoll.deadtime == false)
            {
                KillCount.kcount++;
            }
            navAgent.enabled = false;
            navOb.enabled = true;
            Debug.Log("oof");
            alive = false;
            this.gameObject.tag = "none";
            
        }
        if (c.gameObject.tag == "death" && !alive)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator despawn()
    {
        while (true)
        {
            if (!audioPlayed)
            {
                audioPlayed = true;
                audio.PlayOneShot(sounds[Random.Range(0, sounds.Length)]);
            }
            yield return new WaitForSeconds(3f);
            Destroy(gameObject);
        }
    }

}
