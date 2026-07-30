namespace RenderHeads.Media.AVProVideo
{
	public static class OptionsAppleExtensions
	{
		public static bool GenerateMipmaps(this MediaPlayer.OptionsApple.Flags flags)
		{
			return false;
		}

		public static MediaPlayer.OptionsApple.Flags SetGenerateMipMaps(this MediaPlayer.OptionsApple.Flags flags, bool b)
		{
			return default(MediaPlayer.OptionsApple.Flags);
		}

		public static bool AllowExternalPlayback(this MediaPlayer.OptionsApple.Flags flags)
		{
			return false;
		}

		public static MediaPlayer.OptionsApple.Flags SetAllowExternalPlayback(this MediaPlayer.OptionsApple.Flags flags, bool b)
		{
			return default(MediaPlayer.OptionsApple.Flags);
		}

		public static bool PlayWithoutBuffering(this MediaPlayer.OptionsApple.Flags flags)
		{
			return false;
		}

		public static MediaPlayer.OptionsApple.Flags SetPlayWithoutBuffering(this MediaPlayer.OptionsApple.Flags flags, bool b)
		{
			return default(MediaPlayer.OptionsApple.Flags);
		}

		public static bool UseSinglePlayerItem(this MediaPlayer.OptionsApple.Flags flags)
		{
			return false;
		}

		public static MediaPlayer.OptionsApple.Flags SetUseSinglePlayerItem(this MediaPlayer.OptionsApple.Flags flags, bool b)
		{
			return default(MediaPlayer.OptionsApple.Flags);
		}

		public static bool ResumePlaybackAfterAudioSessionRouteChange(this MediaPlayer.OptionsApple.Flags flags)
		{
			return false;
		}

		public static MediaPlayer.OptionsApple.Flags SetResumePlaybackAfterAudioSessionRouteChange(this MediaPlayer.OptionsApple.Flags flags, bool b)
		{
			return default(MediaPlayer.OptionsApple.Flags);
		}
	}
}
