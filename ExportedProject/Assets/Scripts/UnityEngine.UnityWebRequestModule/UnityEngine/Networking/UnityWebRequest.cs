using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
	public class UnityWebRequest : IDisposable
	{
		internal enum UnityWebRequestMethod
		{
			Get = 0,
			Post = 1,
			Put = 2,
			Head = 3,
			Custom = 4
		}

		internal enum UnityWebRequestError
		{
			OK = 0,
			Unknown = 1,
			SDKError = 2,
			UnsupportedProtocol = 3,
			MalformattedUrl = 4,
			CannotResolveProxy = 5,
			CannotResolveHost = 6,
			CannotConnectToHost = 7,
			AccessDenied = 8,
			GenericHttpError = 9,
			WriteError = 10,
			ReadError = 11,
			OutOfMemory = 12,
			Timeout = 13,
			HTTPPostError = 14,
			SSLCannotConnect = 15,
			Aborted = 16,
			TooManyRedirects = 17,
			ReceivedNoData = 18,
			SSLNotSupported = 19,
			FailedToSendData = 20,
			FailedToReceiveData = 21,
			SSLCertificateError = 22,
			SSLCipherNotAvailable = 23,
			SSLCACertError = 24,
			UnrecognizedContentEncoding = 25,
			LoginFailed = 26,
			SSLShutdownFailed = 27,
			NoInternetConnection = 28
		}

		public enum Result
		{
			InProgress = 0,
			Success = 1,
			ConnectionError = 2,
			ProtocolError = 3,
			DataProcessingError = 4
		}

		[NonSerialized]
		internal IntPtr m_Ptr;

		[NonSerialized]
		internal DownloadHandler m_DownloadHandler;

		[NonSerialized]
		internal UploadHandler m_UploadHandler;

		[NonSerialized]
		internal CertificateHandler m_CertificateHandler;

		[NonSerialized]
		internal Uri m_Uri;

		public const string kHttpVerbGET = "GET";

		public const string kHttpVerbHEAD = "HEAD";

		public const string kHttpVerbPOST = "POST";

		public const string kHttpVerbPUT = "PUT";

		public const string kHttpVerbCREATE = "CREATE";

		public const string kHttpVerbDELETE = "DELETE";

		public bool disposeCertificateHandlerOnDispose { get; set; }

		public bool disposeDownloadHandlerOnDispose { get; set; }

		public bool disposeUploadHandlerOnDispose { get; set; }

		public string method
		{
			set
			{
			}
		}

		public string error => null;

		private bool use100Continue
		{
			set
			{
			}
		}

		public bool useHttpContinue
		{
			set
			{
			}
		}

		public string url
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Uri uri
		{
			set
			{
			}
		}

		public long responseCode => 0L;

		public float uploadProgress => 0f;

		public bool isModifiable
		{
			[NativeMethod("IsModifiable")]
			get
			{
				return false;
			}
		}

		public bool isDone => false;

		[Obsolete("UnityWebRequest.isNetworkError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ConnectionError) instead.", false)]
		public bool isNetworkError => false;

		[Obsolete("UnityWebRequest.isHttpError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ProtocolError) instead.", false)]
		public bool isHttpError => false;

		public Result result
		{
			[NativeMethod("GetResult")]
			get
			{
				return default(Result);
			}
		}

		public float downloadProgress => 0f;

		public ulong downloadedBytes => 0uL;

		public UploadHandler uploadHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DownloadHandler downloadHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CertificateHandler certificateHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int timeout
		{
			set
			{
			}
		}

		[NativeMethod(IsThreadSafe = true)]
		[NativeConditional("ENABLE_UNITYWEBREQUEST")]
		private static string GetWebErrorString(UnityWebRequestError err)
		{
			return null;
		}

		[VisibleToOtherModules]
		internal static string GetHTTPStatusString(long responseCode)
		{
			return null;
		}

		internal static IntPtr Create()
		{
			return (IntPtr)0;
		}

		[NativeMethod(IsThreadSafe = true)]
		private void Release()
		{
		}

		internal void InternalDestroy()
		{
		}

		private void InternalSetDefaults()
		{
		}

		public UnityWebRequest(string url, string method)
		{
		}

		public UnityWebRequest(Uri uri, string method)
		{
		}

		public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
		{
		}

		~UnityWebRequest()
		{
		}

		public void Dispose()
		{
		}

		private void DisposeHandlers()
		{
		}

		[NativeThrows]
		internal UnityWebRequestAsyncOperation BeginWebRequest()
		{
			return null;
		}

		[Obsolete("Use SendWebRequest.  It returns a UnityWebRequestAsyncOperation which contains a reference to the WebRequest object.", false)]
		public AsyncOperation Send()
		{
			return null;
		}

		public UnityWebRequestAsyncOperation SendWebRequest()
		{
			return null;
		}

		[NativeMethod(IsThreadSafe = true)]
		public void Abort()
		{
		}

		private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType)
		{
			return default(UnityWebRequestError);
		}

		internal void InternalSetMethod(UnityWebRequestMethod methodType)
		{
		}

		private UnityWebRequestError SetCustomMethod(string customMethodName)
		{
			return default(UnityWebRequestError);
		}

		internal void InternalSetCustomMethod(string customMethodName)
		{
		}

		private UnityWebRequestError GetError()
		{
			return default(UnityWebRequestError);
		}

		private string GetUrl()
		{
			return null;
		}

		private UnityWebRequestError SetUrl(string url)
		{
			return default(UnityWebRequestError);
		}

		private void InternalSetUrl(string url)
		{
		}

		private float GetUploadProgress()
		{
			return 0f;
		}

		private bool IsExecuting()
		{
			return false;
		}

		private float GetDownloadProgress()
		{
			return 0f;
		}

		[NativeMethod("SetRequestHeader")]
		internal UnityWebRequestError InternalSetRequestHeader(string name, string value)
		{
			return default(UnityWebRequestError);
		}

		public void SetRequestHeader(string name, string value)
		{
		}

		public string GetResponseHeader(string name)
		{
			return null;
		}

		internal string[] GetResponseHeaderKeys()
		{
			return null;
		}

		public Dictionary<string, string> GetResponseHeaders()
		{
			return null;
		}

		private UnityWebRequestError SetUploadHandler(UploadHandler uh)
		{
			return default(UnityWebRequestError);
		}

		private UnityWebRequestError SetDownloadHandler(DownloadHandler dh)
		{
			return default(UnityWebRequestError);
		}

		private UnityWebRequestError SetCertificateHandler(CertificateHandler ch)
		{
			return default(UnityWebRequestError);
		}

		private UnityWebRequestError SetTimeoutMsec(int timeout)
		{
			return default(UnityWebRequestError);
		}

		public static UnityWebRequest Get(string uri)
		{
			return null;
		}

		public static UnityWebRequest Post(string uri, WWWForm formData)
		{
			return null;
		}

		private static void SetupPost(UnityWebRequest request, WWWForm formData)
		{
		}
	}
}
