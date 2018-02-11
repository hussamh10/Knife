using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcher : MonoBehaviour {

    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        //if (Input.GetMouseButtonDown(0))
        {
                launch();
        }
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector3(0, -4.76f);
        transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        if (collision.gameObject.name == "target")
        {
            controller.instance.scoreIncrement();
        }
        else
        {
            controller.instance.Die();
        }
    }

    void launch()
    {
        rb.velocity = new Vector2(0f, controller.knife_speed);
    }
}
