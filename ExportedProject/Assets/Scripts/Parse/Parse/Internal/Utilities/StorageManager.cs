using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Parse.Internal.Utilities
{
	internal static class StorageManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWriteToAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public FileInfo file;

			public string content;

			private FileStream _003Cstream_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CReadAllTextAsync_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public FileInfo file;

			private StreamReader _003Creader_003E5__2;

			private TaskAwaiter<string> _003C_003Eu__1;

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
		private struct _003CTransferAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string originFilePath;

			public string targetFilePath;

			private StreamWriter _003Cwriter_003E5__2;

			private StreamReader _003Creader_003E5__3;

			private StreamWriter _003C_003E7__wrap3;

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

		public static string PersistentStorageFilePath => null;

		public static string FallbackPersistentStorageFilePath { get; }

		public static FileInfo PersistentStorageFileWrapper => null;

		static StorageManager()
		{
		}

		[AsyncStateMachine(typeof(_003CWriteToAsync_003Ed__6))]
		public static Task WriteToAsync(this FileInfo file, string content)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadAllTextAsync_003Ed__7))]
		public static Task<string> ReadAllTextAsync(this FileInfo file)
		{
			return null;
		}

		public static FileInfo GetWrapperForRelativePersistentStorageFilePath(string path)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTransferAsync_003Ed__11))]
		public static Task TransferAsync(string originFilePath, string targetFilePath)
		{
			return null;
		}
	}
}
