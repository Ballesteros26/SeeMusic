using System.Collections.Generic;
using UnityEngine;

public class PlatformExample : MonoBehaviour
{
	public GameObject musicCubePrefab;

	public float distance;

	public Material[] materials;

	private MusicCube[] musicCubes;

	private List<MusicCube> cubes;

	private Touch touch;

	private Ray ray;

	private RaycastHit hit;

	private bool[] touchPhaseBegan;

	private void Awake()
	{
	}

	private void OnTap(int finger, Vector2 pos)
	{
	}

	private void OnUp(int finger, Vector2 pos, float timeHeld)
	{
	}

	private void Update()
	{
	}
}
