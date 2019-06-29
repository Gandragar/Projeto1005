using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroy : MonoBehaviour
{

	private void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Asteroid")
		{
			Destroy(col.gameObject);
		}
	}
}
