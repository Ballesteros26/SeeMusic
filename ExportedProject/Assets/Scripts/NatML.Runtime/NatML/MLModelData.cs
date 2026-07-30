using NatML.API.Types;
using UnityEngine;

namespace NatML
{
	public sealed class MLModelData : ScriptableObject
	{
		[HideInInspector]
		[SerializeField]
		internal PredictorSession session;

		[HideInInspector]
		[SerializeField]
		internal byte[] graph;
	}
}
