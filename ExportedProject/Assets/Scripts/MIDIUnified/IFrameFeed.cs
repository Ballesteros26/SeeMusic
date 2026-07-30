public interface IFrameFeed
{
	int SampleRate();

	int DeltaFrames();

	void PlayFeed();

	void StopFeed();

	void PauseFeed();
}
