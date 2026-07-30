using System;
using UnityEngine;

[ExecuteInEditMode]
public class DesignResolution : MonoBehaviour
{
	private static Vector2 _scaler;

	private static float _width;

	private static float _height;

	public static Vector2 designResolution;

	public static Vector2 currentResolution;

	public static Action OnDisplayResolutionChange;

	public static Vector2 scaler => default(Vector2);

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static Vector2 AspectRatio(int width, int height)
	{
		return default(Vector2);
	}
}
