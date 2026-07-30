using System.Collections.Generic;
using ForieroEngine.Pooling;
using UnityEngine;

namespace ForieroEngine.MIDIUnified
{
	public class MIDIPercussion : MonoBehaviour
	{
		private struct ScheduledPercussion
		{
			public AudioClip clip;

			public float volume;

			public double dspTime;
		}

		private class AudioObject
		{
			public AudioSource audioSource;

			public double dspTime;

			public bool IsPlaying()
			{
				return false;
			}

			public void Schedule(ScheduledPercussion scheduledPercussion)
			{
			}
		}

		public static MIDIPercussion instance;

		private AudioSource _audioSource;

		private AudioObject _audioObject;

		private ScheduledPercussion _scheduledPercussion;

		private AudioClip _percussionAudioClip;

		private ObjectPool<AudioObject> _audioObjectPool;

		private List<ScheduledPercussion> _scheduledPercussionItems;

		private List<AudioObject> _playingPercussionItems;

		private List<AudioObject> _percussionItems;

		public static MIDIPercussionSettings settings => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void InitAudioSourcePool()
		{
		}

		private void UpdateAudioSourcePool()
		{
		}

		private static int Percussion(PercussionEnum percussionEnum, int volume)
		{
			return 0;
		}

		public static void Mute()
		{
		}

		public static void UnMute()
		{
		}

		public static double SchedulePercussion(PercussionEnum percussionEnum, int volume, double scheduleTime = 0.0, bool absoluteDspTime = false)
		{
			return 0.0;
		}

		public static void CancelScheduledPercussion()
		{
		}

		private void PercussionDestroy()
		{
		}
	}
}
