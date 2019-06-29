using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonMovement : MonoBehaviour
{
	public float MovDuration = 1f;
	[Space]
	public Transform[] MoonPos;

	IEnumerator Move(int moonPosN)
	{
		float journey = 0f;
		while (journey <= MovDuration)
		{
			journey = journey + Time.deltaTime;
			float percent = Mathf.Clamp01(journey / MovDuration);

			Vector3 pos = MoonPos[moonPosN].position;
			transform.position = Vector3.Lerp(transform.position, new Vector3(pos.x, pos.y, -1), percent);

			yield return null;
		}
	}

	public void MoonMov(int pos)
	{
		StartCoroutine(Move(pos));
	}
}
