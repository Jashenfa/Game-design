using UnityEngine;
using System.Collections;

public class EnemyController2 : MonoBehaviour {

	public float speed = -1;
	private Transform spawnPoint;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
		spawnPoint = GameObject.Find("SpawnPoint").transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible()
	{
		// This line added to remove error displayed by Unity when you stop playing the scene
		if (Camera.main == null)
			return;

		float xMax = Camera.main.orthographicSize - 0.5f;
		transform.position = new Vector3( Random.Range(-xMax, xMax), 
		                              //   spawnPoint.position.y, 
		                                 5f,
		                                 transform.position.z );
	}
}
