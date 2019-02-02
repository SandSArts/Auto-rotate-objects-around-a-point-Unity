//Coded	by Shashank.S - creator of SandS Arts ,Mail me at - sandsarts.developer@gmail.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotateObjectsAroundAPoint : MonoBehaviour {
public float speed;                                                                            //speed of rotation
bool mouseover=false;                                                                          //just to know whether we have moved the mouse over the object
	
	void Update () {
		//Rotating object without checking whether mouse was over this object

		float mouseX=Input.GetAxis("Mouse X");                                             //input from the mouse from x axis
		transform.RotateAround(transform.position,Vector3.down*mouseX,speed*Time.deltaTime);   //rotating the object around

	}

}
