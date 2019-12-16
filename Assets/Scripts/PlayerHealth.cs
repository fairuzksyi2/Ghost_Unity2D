﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
	public float fullHealth;
	//public GameObject deathFX;
	float currentHealth;

	PlayerController playerControl;

	//Player Heart Bar
	public Slider heartBar;

	// Use this for initialization
	void Start () {
		currentHealth = fullHealth;
		playerControl = GetComponent<PlayerController>();

		//Heart Bar
		heartBar.maxValue=fullHealth;
		heartBar.value=fullHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addDamage(float damage){
		if(damage<=0) return;
		currentHealth = currentHealth - damage;
		heartBar.value = currentHealth;

		if(currentHealth<=0){
			makeDead();
		}
	}

	public void makeDead(){
		//Instantiate(deathFX, transform.position, transform.rotation);
	
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

	}
}
