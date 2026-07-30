using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NatML.API;
using NatML.API.Types;
using UnityEngine;
using UnityEngine.Networking;

namespace NatML
{
	public static class MLUnityExtensions
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStreamingAssetsToAbsolutePath_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public string relativePath;

			private string _003CpersistentPath_003E5__2;

			private UnityWebRequest _003Crequest_003E5__3;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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

		public static NatMLClient? CreateClient(string? accessKey = null, string? url = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStreamingAssetsToAbsolutePath_003Ed__1))]
		public static Task<string> StreamingAssetsToAbsolutePath(string relativePath)
		{
			return null;
		}

		public static void Deconstruct(this Normalization? norm, out Vector3 mean, out Vector3 std)
		{
			mean = default(Vector3);
			std = default(Vector3);
		}

		public static void Deconstruct(this AudioFormat? format, out int sampleRate, out int channelCount)
		{
			sampleRate = default(int);
			channelCount = default(int);
		}
	}
}
