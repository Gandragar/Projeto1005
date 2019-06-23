﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaEclipse : MonoBehaviour
{
	private Vector3 mPrevPos = Vector3.zero;
	private Vector3 mPosDelta = Vector3.zero;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			mPosDelta = Input.mousePosition - mPrevPos;
			transform.Rotate(transform.forward, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
		}
		mPrevPos = Input.mousePosition;
	}
}
