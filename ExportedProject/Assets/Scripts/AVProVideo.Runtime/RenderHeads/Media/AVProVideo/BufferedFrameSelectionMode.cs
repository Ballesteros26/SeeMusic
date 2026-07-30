namespace RenderHeads.Media.AVProVideo
{
	public enum BufferedFrameSelectionMode
	{
		None = 0,
		NewestFrame = 10,
		OldestFrame = 11,
		MediaClock = 20,
		ElapsedTime = 30,
		ElapsedTimeVsynced = 40,
		FromExternalTime = 50,
		FromExternalTimeClosest = 51
	}
}
