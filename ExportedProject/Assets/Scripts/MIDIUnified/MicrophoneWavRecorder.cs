using System.IO;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MicrophoneWavRecorder : MonoBehaviour
{
	private int bufferSize;

	private int numBuffers;

	private int outputSampleRate;

	private readonly string fileName;

	private FileStream fileStream;

	private AudioSource audioSource;

	public bool Recording { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void StartRecording(string microphoneName = null)
	{
	}

	public void StopRecording(string microphoneName = null)
	{
	}
}
