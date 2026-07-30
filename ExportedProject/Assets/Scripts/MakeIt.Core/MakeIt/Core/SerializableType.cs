using System;
using UnityEngine;

namespace MakeIt.Core
{
	[Serializable]
	public struct SerializableType : ISerializationCallbackReceiver, IEquatable<SerializableType>, IEquatable<Type>
	{
		[SerializeField]
		private string _assemblyQualifiedTypeName;

		[NonSerialized]
		public Type type;

		public SerializableType(Type type)
		{
			_assemblyQualifiedTypeName = null;
			this.type = null;
		}

		public SerializableType(string assemblyQualifiedTypeName)
		{
			_assemblyQualifiedTypeName = null;
			type = null;
		}

		public static implicit operator Type(SerializableType serializableType)
		{
			return null;
		}

		public static implicit operator SerializableType(Type type)
		{
			return default(SerializableType);
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(Type other)
		{
			return false;
		}

		public bool Equals(SerializableType other)
		{
			return false;
		}

		public static bool operator ==(SerializableType lhs, SerializableType rhs)
		{
			return false;
		}

		public static bool operator !=(SerializableType lhs, SerializableType rhs)
		{
			return false;
		}

		public static bool operator ==(SerializableType lhs, Type rhs)
		{
			return false;
		}

		public static bool operator !=(SerializableType lhs, Type rhs)
		{
			return false;
		}

		public static bool operator ==(Type lhs, SerializableType rhs)
		{
			return false;
		}

		public static bool operator !=(Type lhs, SerializableType rhs)
		{
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
