using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FluidSynth : MonoBehaviour
{
	public static FluidSynth singleton { get; private set; }
}
