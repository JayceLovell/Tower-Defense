using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float startHealth = 100;
	private float health;

	public float startSpeed = 10f;

	[HideInInspector]
	public float speed = 10f;

	public int worth = 50;

	public GameObject deathEffect;

	[Header("Unity Stuff")]
	public Image HealthBar;

	private bool isDead = false;

	void Start()
	{
		speed = startSpeed;
		health = startHealth;
	}

	void Die()
	{
		isDead = true; 

		GameObject effect = (GameObject) Instantiate (deathEffect, transform.position, Quaternion.identity);
		PlayerStats.Money += worth;

		Destroy (gameObject);
		Destroy (effect, 5f);

		WaveSpawner.EnemiesAlive--;
	}

	public void TakeDamage(float amount)
	{
		health -= amount;

		HealthBar.fillAmount = health/startHealth;

		if(health <= 0 && !isDead)
		{
			Die ();
		}
	}

	public void Slow(float slowAmount)
	{
		speed = startSpeed * (1f - slowAmount);
	}
}
