using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRect : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody2D rb;
    private float moveX;
    private float moveY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        //rb.velocity = new Vector2(moveX * speed * Time.deltaTime, moveY * speed * Time.deltaTime);
    }

	private void FixedUpdate()
	{
		rb.velocity = new Vector2(moveX * speed, moveY * speed);
	}
}
