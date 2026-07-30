using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class VolumeComponent : ScriptableObject
	{
		public sealed class Indent : PropertyAttribute
		{
			public readonly int relativeAmount;

			public Indent(int relativeAmount = 1)
			{
			}
		}

		public bool active;

		public string displayName { get; protected set; }

		public ReadOnlyCollection<VolumeParameter> parameters { get; private set; }

		internal static void FindParameters(object o, List<VolumeParameter> parameters, Func<FieldInfo, bool> filter = null)
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Override(VolumeComponent state, float interpFactor)
		{
		}

		public void SetAllOverridesTo(bool state)
		{
		}

		internal void SetOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected virtual void OnDestroy()
		{
		}

		public void Release()
		{
		}
	}
}
