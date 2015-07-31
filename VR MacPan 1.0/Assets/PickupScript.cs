using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour { 

	public Transform target;


	// Use this for initialization
	void Start () {
	
	}


	public Camera targetCamera;
	// Update is called once per frame
	void Update () {
	  	  Vector3 relativePos = target.position - transform.position;
	  	  transform.rotation = Quaternion.LookRotation(relativePos, new Vector3 (0, 1, 0));
  
		
	}
}
