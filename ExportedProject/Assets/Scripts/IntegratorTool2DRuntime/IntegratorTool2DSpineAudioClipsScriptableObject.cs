using System;
using System.Collections.Generic;
using UnityEngine;

public class IntegratorTool2DSpineAudioClipsScriptableObject : ScriptableObject
{
	[Serializable]
	public class Clip
	{
		public string spineEventName;

		public string spineAudioPath;

		public AudioClip audioClip;

		public string FMODEventName => null;

		public string WwiseEventName => null;
	}

	public List<Clip> clips;
}
