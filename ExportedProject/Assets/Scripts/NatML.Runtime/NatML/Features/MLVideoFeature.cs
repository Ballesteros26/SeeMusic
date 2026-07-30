using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NatML.API.Types;
using UnityEngine;

namespace NatML.Features
{
	public sealed class MLVideoFeature : MLFeature, IEnumerable<(MLImageFeature, long)>, IEnumerable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFromStreamingAssets_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MLVideoFeature> _003C_003Et__builder;

			public string relativePath;

			private TaskAwaiter<string?> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public readonly string path;

		public Vector4 mean;

		public Vector4 std;

		public AspectMode aspectMode;

		public int width => 0;

		public int height => 0;

		public int frames => 0;

		public MLVideoFeature(string path)
			: base(null)
		{
		}

		[AsyncStateMachine(typeof(_003CFromStreamingAssets_003Ed__11))]
		public static Task<MLVideoFeature> FromStreamingAssets(string relativePath)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003C_0028NatML_002DFeatures_002DMLImageFeaturefeature_005C_002CSystem_002DInt64timestamp_0029_003E_002DGetEnumerator_003Ed__12))]
		IEnumerator<(MLImageFeature, long)> IEnumerable<(MLImageFeature, long)>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private static MLImageFeature CreateImageFeature(IntPtr feature)
		{
			return null;
		}
	}
}
