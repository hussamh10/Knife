using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runner : MonoBehaviour {

    Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(6f, 16f), 0);
	}
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "right edge")
        {
            rb.velocity = new Vector2(Random.Range(-6f, -16f), 0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (other.gameObject.name == "left edge")
        {
            rb.velocity = new Vector2(Random.Range(6f, 16f), 0);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

}
