using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerController : MonoBehaviour {
    public HingeJoint2D pivot;
    public PlayerController player1;
	// Use this for initialization
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {
        JointMotor2D theMotor = pivot.motor;
        if (player1.trapDoorFall == true)
        {


            theMotor.motorSpeed = 100;
        }
        pivot.motor = theMotor; 
	}


 
}
