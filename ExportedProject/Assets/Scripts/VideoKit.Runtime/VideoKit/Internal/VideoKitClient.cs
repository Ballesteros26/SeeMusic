using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Networking;

namespace VideoKit.Internal
{
	public sealed class VideoKitClient
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateBuildToken_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public VideoKitClient _003C_003E4__this;

			private HttpClient _003Crequest_003E5__2;

			private HttpResponseMessage _003Cresponse_003E5__3;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

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
		private struct _003CCreateSessionTokenDotNet_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public VideoKitClient _003C_003E4__this;

			public string payload;

			private HttpClient _003Cclient_003E5__2;

			private StringContent _003Ccontent_003E5__3;

			private HttpResponseMessage _003Cresponse_003E5__4;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

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
		private struct _003CCreateSessionTokenUnity_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public VideoKitClient _003C_003E4__this;

			public string payload;

			private UnityWebRequest _003Crequest_003E5__2;

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

		public const string Version = "0.0.18";

		public const string URL = "https://www.videokit.ai/api";

		private readonly string accessKey;

		private readonly string url;

		private string buildUrl => null;

		private string sessionUrl => null;

		public VideoKitClient(string accessKey, string url = null)
		{
		}

		[AsyncStateMachine(typeof(_003CCreateBuildToken_003Ed__3))]
		public Task<string> CreateBuildToken()
		{
			return null;
		}

		public Task<string> CreateSessionToken(string buildToken, string bundleId, string platform)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateSessionTokenDotNet_003Ed__11))]
		private Task<string> CreateSessionTokenDotNet(string payload)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateSessionTokenUnity_003Ed__12))]
		private Task<string> CreateSessionTokenUnity(string payload)
		{
			return null;
		}
	}
}
