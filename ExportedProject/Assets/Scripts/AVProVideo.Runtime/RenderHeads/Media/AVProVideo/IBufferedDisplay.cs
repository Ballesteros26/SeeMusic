namespace RenderHeads.Media.AVProVideo
{
	public interface IBufferedDisplay
	{
		long UpdateBufferedDisplay();

		BufferedFramesState GetBufferedFramesState();

		void SetSlaves(IBufferedDisplay[] slaves);

		void SetBufferedDisplayMode(BufferedFrameSelectionMode mode, IBufferedDisplay master = null);

		void SetBufferedDisplayOptions(bool pauseOnPrerollComplete);
	}
}
