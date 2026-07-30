using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NatML.API.Graph;
using NatML.API.Types;

namespace NatML.API.Services
{
	public sealed class StorageService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDownload_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MemoryStream> _003C_003Et__builder;

			public string url;

			public StorageService _003C_003E4__this;

			private TaskAwaiter<MemoryStream> _003C_003Eu__1;

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
		private struct _003CUpload_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public string mime;

			public MemoryStream stream;

			public int dataUrlLimit;

			public StorageService _003C_003E4__this;

			public string name;

			public UploadType type;

			private string _003Curl_003E5__2;

			private TaskAwaiter<string> _003C_003Eu__1;

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
		private struct _003CCreateUploadURL_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public StorageService _003C_003E4__this;

			public string name;

			public UploadType type;

			public string key;

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

		private readonly IGraphClient client;

		[AsyncStateMachine(typeof(_003CDownload_003Ed__0))]
		public Task<MemoryStream> Download(string url)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpload_003Ed__1))]
		public Task<string> Upload(string name, MemoryStream stream, UploadType type, string? mime = null, int dataUrlLimit = 0)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateUploadURL_003Ed__2))]
		public Task<string> CreateUploadURL(string name, UploadType type, string? key = null)
		{
			return null;
		}

		internal StorageService(IGraphClient client)
		{
		}
	}
}
