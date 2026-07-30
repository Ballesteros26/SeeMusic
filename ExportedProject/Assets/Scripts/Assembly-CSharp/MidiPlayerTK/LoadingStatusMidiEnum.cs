namespace MidiPlayerTK
{
	public enum LoadingStatusMidiEnum
	{
		NotYetDefined = -1,
		Success = 0,
		NotFound = 1,
		TooShortSize = 2,
		NoMThdSignature = 3,
		NetworkError = 4,
		MidiFileInvalid = 5,
		SoundFontNotLoaded = 6,
		AlreadyPlaying = 7,
		MidiNameInvalid = 8,
		MidiNameNotDefined = 9
	}
}
