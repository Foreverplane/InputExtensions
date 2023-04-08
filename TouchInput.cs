using System;
using UnityEngine;

[Serializable]
public struct TouchInput
{
	public bool IsPressed;
	public Vector2 Position;

	public TouchInput(bool isPressed, Vector2 position)
	{
		IsPressed = isPressed;
		Position = position;
	}

	public override string ToString()
	{
		return $"IsPressed: {IsPressed}, Position: {Position}";
	}
}
