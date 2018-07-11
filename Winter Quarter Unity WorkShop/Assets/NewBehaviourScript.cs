using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed,jump_force;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*speed* Time.deltaTime, rb.velocity.y);
        if(Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(new Vector2(0, jump_force));
        }
	}
    void FixedUpdate()
    {

    }
}
