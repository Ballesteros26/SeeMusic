using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function.Types;
using UnityEngine;
using UnityEngine.Networking;

namespace Function
{
	public static class FunctionUnity
	{
		private sealed class DownloadUrlCreator : IDisposable
		{
			[StructLayout((LayoutKind)3)]
			[CompilerGenerated]
			private struct _003CURL_003Ed__3 : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

				public DownloadUrlCreator _003C_003E4__this;

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
			private struct _003CCreateFileURL_003Ed__5 : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

				public DownloadUrlCreator _003C_003E4__this;

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

			private readonly string url;

			private readonly string path;

			public DownloadUrlCreator(string url)
			{
			}

			[AsyncStateMachine(typeof(_003CURL_003Ed__3))]
			public Task<string> URL()
			{
				return null;
			}

			public void Dispose()
			{
			}

			[AsyncStateMachine(typeof(_003CCreateFileURL_003Ed__5))]
			private Task<string> CreateFileURL()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CToValue_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Value> _003C_003Et__builder;

			public Texture2D texture;

			public int minUploadSize;

			private MemoryStream _003Cstream_003E5__2;

			private TaskAwaiter<Value> _003C_003Eu__1;

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
		private struct _003CToValue_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Value> _003C_003Et__builder;

			public AudioClip clip;

			public int minUploadSize;

			private MemoryStream _003Cstream_003E5__2;

			private TaskAwaiter<Value> _003C_003Eu__1;

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
		private struct _003CToTexture_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Texture2D> _003C_003Et__builder;

			public Value value;

			public Texture2D texture;

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
		private struct _003CToAudioClip_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AudioClip> _003C_003Et__builder;

			public Value value;

			private DownloadUrlCreator _003CurlCreator_003E5__2;

			private UnityWebRequest _003Cwww_003E5__3;

			private TaskAwaiter<string> _003C_003Eu__1;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__2;

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
		private struct _003CStreamingAssetsToAbsolutePath_003Ed__5 : IAsyncStateMachine
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

		internal static string ClientId => null;

		public static Function? Create(string? accessKey = null, string? url = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToValue_003Ed__1))]
		public static Task<Value> ToValue(this Texture2D texture, int minUploadSize = 4096)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToValue_003Ed__2))]
		public static Task<Value> ToValue(this AudioClip clip, int minUploadSize = 4096)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToTexture_003Ed__3))]
		public static Task<Texture2D> ToTexture(this Value value, Texture2D texture = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToAudioClip_003Ed__4))]
		public static Task<AudioClip> ToAudioClip(this Value value)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStreamingAssetsToAbsolutePath_003Ed__5))]
		public static Task<string> StreamingAssetsToAbsolutePath(string relativePath)
		{
			return null;
		}
	}
}
