using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function.Graph;
using Function.Types;

namespace Function.Services
{
	public sealed class StorageService
	{
		private sealed class CreateUploadUrlInput
		{
			public string name;

			public UploadType type;

			public string? key;
		}

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

			public Stream stream;

			public int dataUrlLimit;

			public StorageService _003C_003E4__this;

			public string name;

			public UploadType type;

			public string key;

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

		private readonly IGraphClient client;

		[AsyncStateMachine(typeof(_003CDownload_003Ed__0))]
		public Task<MemoryStream> Download(string url)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpload_003Ed__1))]
		public Task<string> Upload(string name, Stream stream, UploadType type, string? mime = null, int dataUrlLimit = 0, string? key = null)
		{
			return null;
		}

		public Task<string> CreateUploadUrl(string name, UploadType type, string? key = null)
		{
			return null;
		}

		internal StorageService(IGraphClient client)
		{
		}

		internal static byte[] ReadStream(Stream stream)
		{
			return null;
		}
	}
}
