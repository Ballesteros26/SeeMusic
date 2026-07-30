using System;
using UnityEngine;

[Serializable]
public struct SerializableGuid : ISerializationCallbackReceiver
{
	private Guid guid;

	[SerializeField]
	private string serializedGuid;

	public SerializableGuid(Guid guid)
	{
		this.guid = default(Guid);
		serializedGuid = null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static bool operator ==(SerializableGuid a, SerializableGuid b)
	{
		return false;
	}

	public static bool operator !=(SerializableGuid a, SerializableGuid b)
	{
		return false;
	}

	public static implicit operator SerializableGuid(Guid guid)
	{
		return default(SerializableGuid);
	}

	public static implicit operator Guid(SerializableGuid serializable)
	{
		return default(Guid);
	}

	public static implicit operator SerializableGuid(string serializedGuid)
	{
		return default(SerializableGuid);
	}

	public static implicit operator string(SerializableGuid serializedGuid)
	{
		return null;
	}
}
