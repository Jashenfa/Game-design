using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointsText : MonoBehaviour {
	//public var text: string;
	public Text words;

	GameObject zombie;
	ZombieController zc;



	// Use this for initialization
	void Start () {
		zombie = GameObject.Find("zombie");
		zc = zombie.GetComponent<ZombieController>();

		words = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		zc = zombie.GetComponent<ZombieController>();
		words.text = "You've got " + zc.points + " Points";
	}
}
