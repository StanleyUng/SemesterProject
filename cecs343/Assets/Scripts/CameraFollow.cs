﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public GameObject player;


	// Use this for initialization
	void Start () 
	{
        Camera.main.orthographicSize = 3;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -1);
	}
}
