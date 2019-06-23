using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuaPosicao : MonoBehaviour
{
	public GameObject MoonCycle;
	[Space]
	public Image TargetImage;
	public Sprite[] PossibleImages;

	private Transform _moon;

	private void Start()
	{
		_moon = MoonCycle.transform;
	}

	private void Update()
	{
		if (_moon.rotation.eulerAngles.z >= 85 && _moon.rotation.eulerAngles.z <= 95)
			TargetImage.sprite = PossibleImages[0];
		else if (_moon.rotation.eulerAngles.z >= 265 && _moon.rotation.eulerAngles.z <= 275)
			TargetImage.sprite = PossibleImages[1];
	}
}
