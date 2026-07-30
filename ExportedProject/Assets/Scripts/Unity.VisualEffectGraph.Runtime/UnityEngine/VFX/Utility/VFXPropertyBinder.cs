using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.VFX.Utility
{
	[DefaultExecutionOrder(1)]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[RequireComponent(typeof(VisualEffect))]
	public class VFXPropertyBinder : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CGetPropertyBinders_003Ed__17<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : VFXBinderBase
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VFXPropertyBinder _003C_003E4__this;

			private List<VFXBinderBase>.Enumerator _003C_003E7__wrap1;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetPropertyBinders_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[SerializeField]
		protected bool m_ExecuteInEditor;

		public List<VFXBinderBase> m_Bindings;

		[SerializeField]
		protected VisualEffect m_VisualEffect;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private static void SafeDestroy(Object toDelete)
		{
		}

		private void Reload()
		{
		}

		private void Reset()
		{
		}

		private void LateUpdate()
		{
		}

		public T AddPropertyBinder<T>() where T : VFXBinderBase
		{
			return null;
		}

		[Obsolete("Use AddPropertyBinder<T>() instead")]
		public T AddParameterBinder<T>() where T : VFXBinderBase
		{
			return null;
		}

		public void ClearPropertyBinders()
		{
		}

		[Obsolete("Please use ClearPropertyBinders() instead")]
		public void ClearParameterBinders()
		{
		}

		public void RemovePropertyBinder(VFXBinderBase binder)
		{
		}

		[Obsolete("Please use RemovePropertyBinder() instead")]
		public void RemoveParameterBinder(VFXBinderBase binder)
		{
		}

		public void RemovePropertyBinders<T>() where T : VFXBinderBase
		{
		}

		[Obsolete("Please use RemovePropertyBinders<T>() instead")]
		public void RemoveParameterBinders<T>() where T : VFXBinderBase
		{
		}

		[IteratorStateMachine(typeof(_003CGetPropertyBinders_003Ed__17<>))]
		public IEnumerable<T> GetPropertyBinders<T>() where T : VFXBinderBase
		{
			return null;
		}

		[Obsolete("Please use GetPropertyBinders<T>() instead")]
		public IEnumerable<T> GetParameterBinders<T>() where T : VFXBinderBase
		{
			return null;
		}
	}
}
