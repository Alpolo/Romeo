using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour 
{
	void Awake()
	{
		print ("Hola Awake");
	}


	void Start () 
	{
		Debug.Log ("Hola Stat");
	}
	

	void Update ()
	{
		print ("Hola Update");
	}

	void FixedUpdate ()
	{
		Debug.Log ("Hola FixedUpdate");
	}
}
