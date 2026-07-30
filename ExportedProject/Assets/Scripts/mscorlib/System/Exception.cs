using System.Collections;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents errors that occur during application execution.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ComVisible(true)]
	public class Exception : ISerializable
	{
		internal enum ExceptionMessageKind
		{
			ThreadAbort = 1,
			ThreadInterrupted = 2,
			OutOfMemory = 3
		}

		[OptionalField]
		private static object s_EDILock;

		private string _className;

		internal string _message;

		private IDictionary _data;

		private Exception _innerException;

		private string _helpURL;

		private object _stackTrace;

		private string _stackTraceString;

		private string _remoteStackTraceString;

		private int _remoteStackIndex;

		private object _dynamicMethods;

		internal int _HResult;

		private string _source;

		[OptionalField(VersionAdded = 4)]
		private SafeSerializationManager _safeSerializationManager;

		internal StackTrace[] captured_traces;

		private IntPtr[] native_trace_ips;

		private int caught_in_unmanaged;

		private const int _COMPlusExceptionCode = -532462766;

		/// <summary>Gets a message that describes the current exception.</summary>
		/// <returns>The error message that explains the reason for the exception, or an empty string ("").</returns>
		/// <filterpriority>1</filterpriority>
		public virtual string Message => null;

		/// <summary>Gets a collection of key/value pairs that provide additional user-defined information about the exception.</summary>
		/// <returns>An object that implements the <see cref="T:System.Collections.IDictionary" /> interface and contains a collection of user-defined key/value pairs. The default is an empty collection.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual IDictionary Data => null;

		/// <summary>Gets the <see cref="T:System.Exception" /> instance that caused the current exception.</summary>
		/// <returns>An instance of Exception that describes the error that caused the current exception. The InnerException property returns the same value as was passed into the constructor, or a null reference (Nothing in Visual Basic) if the inner exception value was not supplied to the constructor. This property is read-only.</returns>
		/// <filterpriority>1</filterpriority>
		public Exception InnerException => null;

		/// <summary>Gets a string representation of the immediate frames on the call stack.</summary>
		/// <returns>A string that describes the immediate frames of the call stack.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public virtual string StackTrace => null;

		/// <summary>Gets or sets the name of the application or the object that causes the error.</summary>
		/// <returns>The name of the application or the object that causes the error.</returns>
		/// <exception cref="T:System.ArgumentException">The object must be a runtime <see cref="N:System.Reflection" /> object</exception>
		/// <filterpriority>2</filterpriority>
		public virtual string Source => null;

		/// <summary>Gets or sets HRESULT, a coded numerical value that is assigned to a specific exception.</summary>
		/// <returns>The HRESULT value.</returns>
		public int HResult
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		private void Init()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class.</summary>
		public Exception()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		public Exception(string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
		public Exception(string message, Exception innerException)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
		protected Exception(SerializationInfo info, StreamingContext context)
		{
		}

		private string GetClassName()
		{
			return null;
		}

		/// <summary>When overridden in a derived class, returns the <see cref="T:System.Exception" /> that is the root cause of one or more subsequent exceptions.</summary>
		/// <returns>The first exception thrown in a chain of exceptions. If the <see cref="P:System.Exception.InnerException" /> property of the current exception is a null reference (Nothing in Visual Basic), this property returns the current exception.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual Exception GetBaseException()
		{
			return null;
		}

		private string GetStackTrace(bool needFileInfo)
		{
			return null;
		}

		internal void SetErrorCode(int hr)
		{
		}

		/// <summary>Creates and returns a string representation of the current exception.</summary>
		/// <returns>A string representation of the current exception.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public override string ToString()
		{
			return null;
		}

		private string ToString(bool needFileLineInfo, bool needMessage)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" />
		/// </PermissionSet>
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
		}

		private string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
		{
			return null;
		}

		internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo)
		{
		}

		/// <summary>Gets the runtime type of the current instance.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the exact runtime type of the current instance.</returns>
		/// <filterpriority>2</filterpriority>
		public new Type GetType()
		{
			return null;
		}

		internal static string GetMessageFromNativeResources(ExceptionMessageKind kind)
		{
			return null;
		}

		internal Exception FixRemotingException()
		{
			return null;
		}

		internal static void ReportUnhandledException(Exception exception)
		{
		}
	}
}
