using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateKnob : MonoBehaviour
{
	public bool VMov = false;

	private bool _canMove = false;
	private Vector3 mPrevPos = Vector3.zero;
	private Vector3 mPosDelta = Vector3.zero;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0) && _canMove)
		{
			if (!VMov)
			{
				mPosDelta = Input.mousePosition - mPrevPos;
				transform.Rotate(transform.forward, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
			}
			else
			{
				mPosDelta = Input.mousePosition - mPrevPos;
				transform.Rotate(transform.forward, -Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);
			}
		}
		mPrevPos = Input.mousePosition;
	}

	private void OnMouseDown()
	{
		Debug.Log("down");
		_canMove = true;
	}

	private void OnMouseUp()
	{
		Debug.Log("up");
		_canMove = false;
	}

}
