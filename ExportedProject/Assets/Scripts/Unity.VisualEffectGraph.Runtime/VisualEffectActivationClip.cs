using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
internal class VisualEffectActivationClip : PlayableAsset, ITimelineClipAsset
{
	public VisualEffectActivationBehaviour activationBehavior;

	public ClipCaps clipCaps => default(ClipCaps);

	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}
}
