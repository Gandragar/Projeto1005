using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckRotation : MonoBehaviour
{
	public GameObject HorizontalKnob;
	public GameObject VerticalKnob;
	[Space]
	[Range(0, 360)]
	public float HAngle = 90;
	[Range(0, 360)]
	public float VAngle = 90;


	private bool _hCheck = false;
	private bool _vCheck = false;

	private bool _calledTimer = false;

	private IEnumerator Timer()
	{
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene("04Animacao02");
	}

	private void Update()
	{
		// knob horizontal
		if (HorizontalKnob.transform.rotation.eulerAngles.z >= HAngle - 5 && HorizontalKnob.transform.rotation.eulerAngles.z <= HAngle + 5)
		{
			HorizontalKnob.GetComponent<RotateKnob>().enabled = false;
			_hCheck = true;
		}

		// knob vertical
		if (VerticalKnob.transform.rotation.eulerAngles.z >= VAngle - 5 && VerticalKnob.transform.rotation.eulerAngles.z <= VAngle + 5)
		{
			VerticalKnob.GetComponent<RotateKnob>().enabled = false;
			_vCheck = true;
		}


		if (_hCheck && _vCheck)
		{
			if (!_calledTimer)
				StartCoroutine(Timer());
		}
	}
}
