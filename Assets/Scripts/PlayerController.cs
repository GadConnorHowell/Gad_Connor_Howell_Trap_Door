using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public Rigidbody2D rb2d;
    public float vel;
    public bool trapDoorFall; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float hAxis = Input.GetAxisRaw("Horizontal");


        if (hAxis != 0)
        {
            rb2d.velocity = new Vector2(hAxis * vel, rb2d.velocity.y);
        }
	}

    public void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Trigger")
        {

            trapDoorFall = true;
        
        }

    }
}
