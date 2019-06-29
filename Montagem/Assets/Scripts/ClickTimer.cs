using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickTimer : MonoBehaviour
{
	[Range(0f, 900f)]
	public float TotalTime = 360;

	private float _timeLeft;

	private void Start()
	{
		_timeLeft = TotalTime;
	}

	private void FixedUpdate()
	{
		_timeLeft -= Time.fixedDeltaTime;
		if (_timeLeft < 0)
		{
			SceneManager.LoadScene("01Menu", LoadSceneMode.Single);
		}

		if (Input.GetMouseButtonDown(0))
		{
			_timeLeft = TotalTime;
		}
	}
}
