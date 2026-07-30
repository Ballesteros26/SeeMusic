using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NatML.API.Graph
{
	public sealed class DotNetClient : IGraphClient
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CQuery_003Ed__1<T> : IAsyncStateMachine where T : notnull
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			public string query;

			public Dictionary<string, object?> variables;

			public DotNetClient _003C_003E4__this;

			public string key;

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
		private struct _003CDownload_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MemoryStream> _003C_003Et__builder;

			public string url;

			private HttpClient _003Cclient_003E5__2;

			private Stream _003CdataStream_003E5__3;

			private MemoryStream _003CmemoryStream_003E5__4;

			private TaskAwaiter<Stream> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CUpload_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public MemoryStream stream;

			public string mime;

			public string url;

			private HttpClient _003Cclient_003E5__2;

			private StreamContent _003Ccontent_003E5__3;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

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

		private readonly string accessKey;

		public DotNetClient(string url, string accessKey)
		{
		}

		[AsyncStateMachine(typeof(_003CQuery_003Ed__1<>))]
		public Task<T> Query<T>(string query, string key, Dictionary<string, object?>? variables = null) where T : notnull
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDownload_003Ed__2))]
		public Task<MemoryStream> Download(string url)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpload_003Ed__3))]
		public Task Upload(MemoryStream stream, string url, string? mime = null)
		{
			return null;
		}
	}
}
