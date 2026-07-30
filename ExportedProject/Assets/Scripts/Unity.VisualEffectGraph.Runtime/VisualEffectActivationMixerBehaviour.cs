using UnityEngine.Playables;

internal class VisualEffectActivationMixerBehaviour : PlayableBehaviour
{
	private bool[] enabledStates;

	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	public override void OnPlayableCreate(Playable playable)
	{
	}

	public override void OnPlayableDestroy(Playable playable)
	{
	}
}
