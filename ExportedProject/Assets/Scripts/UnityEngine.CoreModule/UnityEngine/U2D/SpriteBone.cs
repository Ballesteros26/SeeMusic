using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
	[Serializable]
	[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
	[NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[MovedFrom("UnityEngine.Experimental.U2D")]
	[RequiredByNativeCode]
	public struct SpriteBone
	{
		[SerializeField]
		[NativeName("name")]
		private string m_Name;

		[NativeName("guid")]
		[SerializeField]
		private string m_Guid;

		[NativeName("position")]
		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		[NativeName("rotation")]
		private Quaternion m_Rotation;

		[SerializeField]
		[NativeName("length")]
		private float m_Length;

		[SerializeField]
		[NativeName("parentId")]
		private int m_ParentId;

		[NativeName("color")]
		[SerializeField]
		private Color32 m_Color;
	}
}
