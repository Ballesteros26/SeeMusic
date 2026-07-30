using UnityEngine;

namespace ForieroEngine.MIDIUnified.Synthesizer
{
	public interface ISynthRecorder
	{
		void StartRecording(AudioClip bgClip = null, float volume = 1f, float speed = 1f, int semitone = 0);

		void StopRecording();
	}
}
