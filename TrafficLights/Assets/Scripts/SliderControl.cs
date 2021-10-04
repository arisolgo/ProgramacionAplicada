using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderControl : MonoBehaviour
{
	public float mainSpeed = 0;
    public void OnValueChanged(float value)
	{
		mainSpeed = value;
	}
}
