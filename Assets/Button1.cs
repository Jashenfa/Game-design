using UnityEngine;
using System.Collections;

public class Button1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//if click
		if( Input.GetButton("Fire1") ) {
			if(Application.loadedLevel == 5)
			{
				Application.LoadLevel ("CongaScene2");
			}
			else
			{
				Application.LoadLevel("CongaScene");
			}
		}
	}
	
}
