using System.Collections.Generic;
using UnityEngine;

namespace MidiPlayerTK
{
	public class DicAudioClip
	{
		private static Dictionary<string, AudioClip> dicSamples;

		public static void Init()
		{
		}

		public static void Add(string name, AudioClip clip)
		{
		}

		public static bool Exist(string name)
		{
			return false;
		}

		public static AudioClip Get(string name)
		{
			return null;
		}
	}
}
