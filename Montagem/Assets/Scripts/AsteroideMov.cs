using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroideMov : MonoBehaviour
{
	public float speed = 4f;

	void Update()
	{
		transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Moon")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
		}
	}
}
