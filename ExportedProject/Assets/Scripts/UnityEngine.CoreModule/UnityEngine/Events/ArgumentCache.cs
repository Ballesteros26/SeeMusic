using System;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver
	{
		[SerializeField]
		[FormerlySerializedAs("objectArgument")]
		private Object m_ObjectArgument;

		[SerializeField]
		[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
		private string m_ObjectArgumentAssemblyTypeName;

		[FormerlySerializedAs("intArgument")]
		[SerializeField]
		private int m_IntArgument;

		[FormerlySerializedAs("floatArgument")]
		[SerializeField]
		private float m_FloatArgument;

		[FormerlySerializedAs("stringArgument")]
		[SerializeField]
		private string m_StringArgument;

		[SerializeField]
		private bool m_BoolArgument;

		public Object unityObjectArgument => null;

		public string unityObjectArgumentAssemblyTypeName => null;

		public int intArgument => 0;

		public float floatArgument => 0f;

		public string stringArgument => null;

		public bool boolArgument => false;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
