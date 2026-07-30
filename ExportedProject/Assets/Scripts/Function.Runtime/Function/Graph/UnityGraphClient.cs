using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Networking;

namespace Function.Graph
{
	public sealed class UnityGraphClient : IGraphClient
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CQuery_003Ed__5<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			public string query;

			public Dictionary<string, object?> variables;

			public UnityGraphClient _003C_003E4__this;

			public string key;

			private UnityWebRequest _003Cclient_003E5__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDownload_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MemoryStream> _003C_003Et__builder;

			public string url;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpload_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string url;

			public Stream stream;

			public string mime;

			private UnityWebRequest _003Cclient_003E5__2;

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

		private readonly string url;

		private readonly string? accessKey;

		public string? Id { get; private set; }

		public UnityGraphClient(string url, string? accessKey, string? id = null)
		{
		}

		[AsyncStateMachine(typeof(_003CQuery_003Ed__5<>))]
		public Task<T> Query<T>(string query, string key, Dictionary<string, object?>? variables = null) where T : notnull
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDownload_003Ed__6))]
		public Task<MemoryStream> Download(string url)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpload_003Ed__7))]
		public Task Upload(Stream stream, string url, string? mime = null)
		{
			return null;
		}
	}
}
