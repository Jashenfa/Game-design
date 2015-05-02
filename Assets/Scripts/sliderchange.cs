using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class sliderchange : MonoBehaviour {

	GameObject zombie;
	ZombieController zc;

//	public value health;

	// Use this for initialization
	void Start () {
		zombie = GameObject.Find("zombie");
		zc = zombie.GetComponent<ZombieController>();
		
//		health = GetComponent<value> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	//health = ZombieController.lives;

	}
}
