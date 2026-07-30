using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function;
using NatML.API;
using UnityEngine;

namespace VideoKit.Internal
{
	[DefaultExecutionOrder(-10000)]
	public sealed class VideoKitSettings : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckSession_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<VideoKit.Status> _003C_003Et__builder;

			public VideoKitSettings _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public VideoKitSettings _003C_003E4__this;

			private TaskAwaiter<VideoKit.Status> _003C_003Eu__1;

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

		[HideInInspector]
		[SerializeField]
		internal string accessKey;

		[HideInInspector]
		[SerializeField]
		internal string buildToken;

		[SerializeField]
		[HideInInspector]
		internal string sessionToken;

		private VideoKitClient? _client;

		private global::Function.Function? _fxn;

		private NatMLClient? _natml;

		public VideoKitClient? client => null;

		public global::Function.Function? fxn => null;

		public NatMLClient? natml => null;

		public static VideoKitSettings? Instance { get; internal set; }

		public static string BundleId => null;

		internal static string FallbackAccessKey => null;

		[AsyncStateMachine(typeof(_003CCheckSession_003Ed__12))]
		public Task<VideoKit.Status> CheckSession()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAwake_003Ed__21))]
		private void Awake()
		{
		}

		private static string? ToPlatform(RuntimePlatform platform)
		{
			return null;
		}
	}
}
