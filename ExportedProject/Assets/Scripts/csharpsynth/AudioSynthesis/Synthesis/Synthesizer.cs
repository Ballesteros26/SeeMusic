using System;
using System.Collections.Generic;
using AudioSynthesis.Bank;
using AudioSynthesis.Bank.Components;
using AudioSynthesis.Bank.Patches;

namespace AudioSynthesis.Synthesis
{
	public class Synthesizer
	{
		public static InterpolationEnum InterpolationMode;

		public const double TwoPi = Math.PI * 2.0;

		public const double HalfPi = Math.PI / 2.0;

		public const double InverseSqrtOfTwo = 0.707106781186;

		public const double DefaultLfoFrequency = 8.0;

		public const int DefaultModDepth = 100;

		public const int DefaultPolyphony = 40;

		public const int MinPolyphony = 5;

		public const int MaxPolyphony = 250;

		public const int DefaultBlockSize = 64;

		public const double MaxBufferSize = 0.05;

		public const double MinBufferSize = 0.001;

		public const float DenormLimit = 1E-38f;

		public const float NonAudible = 1E-05f;

		public const int MaxVoiceComponents = 4;

		public const int DefaultChannelCount = 16;

		public const int DefaultKeyCount = 128;

		internal float[] sampleBuffer;

		private VoiceManager voiceManager;

		private int audioChannels;

		private bool littleEndian;

		private PatchBank bank;

		private int sampleRate;

		private float mainVolume;

		private float synthGain;

		private int microBufferSize;

		private int microBufferCount;

		private SynthParameters[] synthChannels;

		internal Queue<MidiMessage> midiEventQueue;

		internal int[] midiEventCounts;

		private Patch[] layerList;

		public float[] WorkingBuffer => null;

		public float MixGain
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int SampleRate => 0;

		public int AudioChannels => 0;

		public Synthesizer(int sampleRate, int audioChannels, int bufferSize, int bufferCount, int polyphony)
		{
		}

		public void LoadBank(IResource bankFile)
		{
		}

		public void LoadBank(PatchBank bank)
		{
		}

		public void UnloadBank()
		{
		}

		public void ResetSynthControls()
		{
		}

		public void ResetPrograms()
		{
		}

		public void GetNext()
		{
		}

		private void FillWorkingBuffer()
		{
		}

		public void NoteOn(int channel, int note, int velocity)
		{
		}

		public void NoteOff(int channel, int note)
		{
		}

		public void NoteOffAll(bool immediate)
		{
		}

		public void ProcessMidiMessage(int channel, int command, int data1, int data2)
		{
		}

		private void ReleaseAllHoldPedals()
		{
		}

		private void ReleaseHoldPedal(int channel)
		{
		}
	}
}
