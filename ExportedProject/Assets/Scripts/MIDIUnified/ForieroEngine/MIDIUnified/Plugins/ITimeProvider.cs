namespace ForieroEngine.MIDIUnified.Plugins
{
	public interface ITimeProvider
	{
		string Id { get; }

		float GetTime();

		void SetTime(float value);

		void EnableTimeProvider();

		void DisableTimeProvider();
	}
}
