namespace ForieroEngine.MIDIUnified.Synthesizer
{
	public interface ISynthProvider
	{
		int Start(Synth.Settings settings);

		int Stop();

		int SendShortMessage(int Command, int Data1, int Data2);
	}
}
