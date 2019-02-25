//Coded by Shashank - Creator of SandS Arts , Mail me at sandsarts.developer@gmail.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObjectsAroundAPoint : MonoBehaviour {
	
	public float speed;                 //The speed of rotation
	public Transform point;             //Point around which we want to rotate

	void Update () {
		// RotateAround is a function which helps us to rotate an object around a point
		transform.RotateAround (point.position, Vector3.right, speed * Time.deltaTime);
	
	}
}
