using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathClick : MonoBehaviour
{
	public int PosNum = 0;
	public MoonMovement MoonMovementScript;

	private void OnMouseDown()
	{
		MoonMovementScript.MoonMov(PosNum);
	}
}
