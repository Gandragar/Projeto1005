using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuaFases : MonoBehaviour
{
	public Image TargetImage;

	[Tooltip("Colocar em ordem: Lua Nova > Lua Minguante > Lua Crescente > Lua Cheia")]
	public Sprite[] PossibleImages;

	public void LuaNova()
	{
		TargetImage.sprite = PossibleImages[0];
	}

	public void LuaMinguante()
	{
		TargetImage.sprite = PossibleImages[1];
	}

	public void LuaCrescente()
	{
		TargetImage.sprite = PossibleImages[2];
	}

	public void LuaCheia()
	{
		TargetImage.sprite = PossibleImages[3];
	}
}
