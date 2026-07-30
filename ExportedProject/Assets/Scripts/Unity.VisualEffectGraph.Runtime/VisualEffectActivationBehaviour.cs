using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

[Serializable]
internal class VisualEffectActivationBehaviour : PlayableBehaviour
{
	[Serializable]
	public enum AttributeType
	{
		Float = 1,
		Float2 = 2,
		Float3 = 3,
		Float4 = 4,
		Int32 = 5,
		Uint32 = 6,
		Boolean = 17
	}

	[Serializable]
	public struct EventState
	{
		public ExposedProperty attribute;

		public AttributeType type;

		public float[] values;
	}

	[SerializeField]
	private ExposedProperty onClipEnter;

	[SerializeField]
	private ExposedProperty onClipExit;

	[SerializeField]
	private EventState[] clipEnterEventAttributes;

	[SerializeField]
	private EventState[] clipExitEventAttributes;

	public override void OnPlayableCreate(Playable playable)
	{
	}

	public void SendEventEnter(VisualEffect component)
	{
	}

	public void SendEventExit(VisualEffect component)
	{
	}

	private static VFXEventAttribute BuildEventAttribute(VisualEffect component, EventState[] states)
	{
		return null;
	}
}
