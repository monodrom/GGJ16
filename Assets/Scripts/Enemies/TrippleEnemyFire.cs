﻿using UnityEngine;
using System.Collections;

public class TrippleEnemyFire : MonoBehaviour {

	public float interval = 2f;
	public Rigidbody2D proj;
	public Transform spawnPosition;

	// Use this for initialization
	void Start () {
		StartCoroutine (Fire ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){

	}

	private IEnumerator Fire(){
		yield return new WaitForSeconds(interval);
		Rigidbody2D projectileInstance1 = Instantiate (proj, spawnPosition.position, spawnPosition.rotation) as Rigidbody2D;
		yield return new WaitForSeconds(0.13f);
		Rigidbody2D projectileInstance2 = Instantiate (proj, spawnPosition.position, spawnPosition.rotation) as Rigidbody2D;
		yield return new WaitForSeconds(0.13f);
		Rigidbody2D projectileInstance3 = Instantiate (proj, spawnPosition.position, spawnPosition.rotation) as Rigidbody2D;
		StartCoroutine (Fire ());
	}
}