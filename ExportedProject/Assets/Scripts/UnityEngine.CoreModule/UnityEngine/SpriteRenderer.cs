using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
	public sealed class SpriteRenderer : Renderer
	{
		private UnityEvent<SpriteRenderer> m_SpriteChangeEvent;

		public Sprite sprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SpriteDrawMode drawMode
		{
			set
			{
			}
		}

		public Vector2 size
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Color color
		{
			set
			{
			}
		}

		[RequiredByNativeCode]
		private void InvokeSpriteChanged()
		{
		}

		[SpecialName]
		private void get_size_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}

		[SpecialName]
		private void set_size_Injected(ref Vector2 value)
		{
		}

		[SpecialName]
		private void set_color_Injected(ref Color value)
		{
		}
	}
}
