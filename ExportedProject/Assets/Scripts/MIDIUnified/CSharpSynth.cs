using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using AudioSynthesis;
using AudioSynthesis.Synthesis;
using ForieroEngine.Collections.NonBlocking;
using ForieroEngine.MIDIUnified.Synthesizer;
using UnityEngine;

public class CSharpSynth : MonoBehaviour, ISynthRecorder
{
	public class MFile : IResource
	{
		private readonly byte[] _file;

		private readonly string _fileName;

		public MFile(byte[] file, string fileName)
		{
		}

		public string GetName()
		{
			return null;
		}

		public bool DeleteAllowed()
		{
			return false;
		}

		public bool ReadAllowed()
		{
			return false;
		}

		public bool WriteAllowed()
		{
			return false;
		}

		public void DeleteResource()
		{
		}

		public Stream OpenResourceForRead()
		{
			return null;
		}

		public Stream OpenResourceForWrite()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CSharpSynth _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStart_003Ed__24(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private AudioSource _audioSource;

	private int _channels;

	private int _bufferSize;

	private int _numBuffers;

	private int _outputSampleRate;

	private readonly string _soundBank;

	private int _currentBufferIndex;

	private float[] _currentBuffer;

	private float[] _tempBuffer;

	private MidiMessage _midiMessage;

	private Synthesizer _synth;

	private int _sampleRateDivider;

	private int _length;

	private int _dataIndex;

	private bool record;

	private FileStream fileStream;

	private static Synth.Settings settings;

	private static bool initialized;

	private static bool active;

	private static bool isEnabled;

	private static bool allSoundsOff;

	private static NonBlockingQueue<MidiMessage> queue;

	private static float _volume;

	public static CSharpSynth Instance { get; private set; }

	public float volume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDestroy()
	{
	}

	private void CleanUp()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__24))]
	private IEnumerator Start()
	{
		return null;
	}

	private bool InitSynth()
	{
		return false;
	}

	private void OnAudioFilterRead(float[] data, int channels)
	{
	}

	public void StartRecording(AudioClip bgClip = null, float volume = 1f, float speed = 1f, int semitone = 0)
	{
	}

	public void StopRecording()
	{
	}

	public static void StartSynthesizer(Synth.Settings settings)
	{
	}

	public static void StopSynthesizer()
	{
	}

	public static void SendShortMessage(byte Command, byte Data1, byte Data2)
	{
	}

	public static void AllSoundOff()
	{
	}
}
