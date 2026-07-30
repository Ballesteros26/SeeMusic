namespace Sanford.Multimedia.Midi
{
	public interface IClock
	{
		bool IsRunning { get; }

		int Ticks { get; }
	}
}
