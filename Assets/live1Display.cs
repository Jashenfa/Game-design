using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class live1Display : MonoBehaviour {

	GameObject zombie;
	ZombieController zc;
	Image livepic;

	// Use this for initialization
	void Start () {
		zombie = GameObject.Find("zombie");
		zc = zombie.GetComponent<ZombieController>();
		livepic = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (zc.lives < 3) 
		{
			livepic.CrossFadeAlpha (0, .3f, false);
		}
	}
}
