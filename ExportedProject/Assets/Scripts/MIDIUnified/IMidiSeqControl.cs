public interface IMidiSeqControl
{
	MidiSeqStates State { get; }

	void Play();

	void Continue();

	void Pause();

	void Stop();
}
