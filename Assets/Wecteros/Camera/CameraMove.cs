using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	
	// Start is called before the first frame update
	void Start()
	{
	}
	float inputX;
	float inputZ;
	// Update is called once per frame
	void Update()
	{
		inputX = Input.GetAxis("Horizontal") * 100;
		inputZ = Input.GetAxis("Vertical") * 100;
		if (inputX != 0)
		{
			rotate();
		}
		if (inputZ != 0)
		{
			move();
		}
	}

	private void move()
	{
		transform.position += transform.forward * inputZ * Time.deltaTime;
	}

	private void rotate()
	{
		transform.Rotate(new Vector3(0f, inputX * Time.deltaTime, 0f));
	}
}
