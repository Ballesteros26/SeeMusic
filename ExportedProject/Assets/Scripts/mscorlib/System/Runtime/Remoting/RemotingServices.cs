using System.Collections;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Runtime.Remoting
{
	/// <summary>Provides several methods for using and publishing remoted objects and proxies. This class cannot be inherited.</summary>
	[ComVisible(true)]
	public static class RemotingServices
	{
		[Serializable]
		private class CACD
		{
			public object d;

			public object c;
		}

		private static Hashtable uri_hash;

		private static BinaryFormatter _serializationFormatter;

		private static BinaryFormatter _deserializationFormatter;

		private static string app_id;

		private static readonly object app_id_lock;

		private static int next_id;

		private static readonly MethodInfo FieldSetterMethod;

		private static readonly MethodInfo FieldGetterMethod;

		static RemotingServices()
		{
		}

		internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args)
		{
			out_args = null;
			return null;
		}

		internal static MethodBase GetVirtualMethod(Type type, MethodBase method)
		{
			return null;
		}

		/// <summary>Returns a Boolean value that indicates whether the given object is a transparent proxy or a real object.</summary>
		/// <returns>A Boolean value that indicates whether the object specified in the <paramref name="proxy" /> parameter is a transparent proxy or a real object.</returns>
		/// <param name="proxy">The reference to the object to check. </param>
		public static bool IsTransparentProxy(object proxy)
		{
			return false;
		}

		internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
		{
			return null;
		}

		/// <summary>Creates a proxy for a well-known object, given the <see cref="T:System.Type" /> and URL.</summary>
		/// <returns>A proxy to the remote object that points to an endpoint served by the specified well-known object.</returns>
		/// <param name="classToProxy">The <see cref="T:System.Type" /> of a well-known object on the server end to which you want to connect. </param>
		/// <param name="url">The URL of the server class. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, RemotingConfiguration" />
		/// </PermissionSet>
		[ComVisible(true)]
		public static object Connect(Type classToProxy, string url)
		{
			return null;
		}

		/// <summary>Creates a proxy for a well-known object, given the <see cref="T:System.Type" />, URL, and channel-specific data.</summary>
		/// <returns>A proxy that points to an endpoint that is served by the requested well-known object.</returns>
		/// <param name="classToProxy">The <see cref="T:System.Type" /> of the well-known object to which you want to connect. </param>
		/// <param name="url">The URL of the well-known object. </param>
		/// <param name="data">Channel specific data. Can be null. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, RemotingConfiguration" />
		/// </PermissionSet>
		[ComVisible(true)]
		public static object Connect(Type classToProxy, string url, object data)
		{
			return null;
		}

		/// <summary>Returns the <see cref="T:System.Type" /> of the object with the specified URI.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the object with the specified URI.</returns>
		/// <param name="URI">The URI of the object whose <see cref="T:System.Type" /> is requested. </param>
		/// <exception cref="T:System.Security.SecurityException">Either the immediate caller does not have infrastructure permission, or at least one of the callers higher in the callstack does not have permission to retrieve the type information of non-public members. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public static Type GetServerTypeForUri(string URI)
		{
			return null;
		}

		/// <summary>Takes a <see cref="T:System.Runtime.Remoting.ObjRef" /> and creates a proxy object out of it.</summary>
		/// <returns>A proxy to the object that the given <see cref="T:System.Runtime.Remoting.ObjRef" /> represents.</returns>
		/// <param name="objectRef">The <see cref="T:System.Runtime.Remoting.ObjRef" /> that represents the remote object for which the proxy is being created. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Runtime.Remoting.ObjRef" /> instance specified in the <paramref name="objectRef" /> parameter is not well-formed. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" />
		/// </PermissionSet>
		public static object Unmarshal(ObjRef objectRef)
		{
			return null;
		}

		/// <summary>Takes a <see cref="T:System.Runtime.Remoting.ObjRef" /> and creates a proxy object out of it, refining it to the type on the server.</summary>
		/// <returns>A proxy to the object that the given <see cref="T:System.Runtime.Remoting.ObjRef" /> represents.</returns>
		/// <param name="objectRef">The <see cref="T:System.Runtime.Remoting.ObjRef" /> that represents the remote object for which the proxy is being created. </param>
		/// <param name="fRefine">true to refine the proxy to the type on the server; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Runtime.Remoting.ObjRef" /> instance specified in the <paramref name="objectRef" /> parameter is not well-formed. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" />
		/// </PermissionSet>
		public static object Unmarshal(ObjRef objectRef, bool fRefine)
		{
			return null;
		}

		/// <summary>Takes a <see cref="T:System.MarshalByRefObject" />, registers it with the remoting infrastructure, and converts it into an instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class.</summary>
		/// <returns>An instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class that represents the object specified in the <paramref name="Obj" /> parameter.</returns>
		/// <param name="Obj">The object to convert. </param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">The <paramref name="Obj" /> parameter is an object proxy. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static ObjRef Marshal(MarshalByRefObject Obj)
		{
			return null;
		}

		/// <summary>Takes a <see cref="T:System.MarshalByRefObject" /> and converts it into an instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class with the specified URI, and the provided <see cref="T:System.Type" />.</summary>
		/// <returns>An instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class that represents the object specified in the <paramref name="Obj" /> parameter.</returns>
		/// <param name="Obj">The object to convert into a <see cref="T:System.Runtime.Remoting.ObjRef" />. </param>
		/// <param name="ObjURI">The URI the object specified in the <paramref name="Obj" /> parameter is marshaled with. Can be null. </param>
		/// <param name="RequestedType">The <see cref="T:System.Type" /><paramref name="Obj" /> is marshaled as. Can be null. </param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="Obj" /> is a proxy of a remote object, and the <paramref name="ObjUri" /> parameter is not null. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
		{
			return null;
		}

		private static string NewUri()
		{
			return null;
		}

		/// <summary>Returns the real proxy backing the specified transparent proxy.</summary>
		/// <returns>The real proxy instance backing the transparent proxy.</returns>
		/// <param name="proxy">A transparent proxy. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static RealProxy GetRealProxy(object proxy)
		{
			return null;
		}

		/// <summary>Returns the method base from the given <see cref="T:System.Runtime.Remoting.Messaging.IMethodMessage" />.</summary>
		/// <returns>The method base extracted from the <paramref name="msg" /> parameter.</returns>
		/// <param name="msg">The method message to extract the method base from. </param>
		/// <exception cref="T:System.Security.SecurityException">Either the immediate caller does not have infrastructure permission, or at least one of the callers higher in the callstack does not have permission to retrieve the type information of non-public members. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
		{
			return null;
		}

		internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature)
		{
			return null;
		}

		private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature)
		{
			return null;
		}

		/// <summary>Serializes the specified marshal by reference object into the provided <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="obj">The object to serialize. </param>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> into which the object is serialized. </param>
		/// <param name="context">The source and destination of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> or <paramref name="info" /> parameter is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Returns a Boolean value that indicates whether the client that called the method specified in the given message is waiting for the server to finish processing the method before continuing execution.</summary>
		/// <returns>true if the method is one way; otherwise, false.</returns>
		/// <param name="method">The method in question. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public static bool IsOneWay(MethodBase method)
		{
			return false;
		}

		internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes)
		{
			return null;
		}

		internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes)
		{
			return null;
		}

		internal static object CreateClientProxy(WellKnownClientTypeEntry entry)
		{
			return null;
		}

		internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes)
		{
			return null;
		}

		internal static Identity GetIdentityForUri(string uri)
		{
			return null;
		}

		private static string RemoveAppNameFromUri(string uri)
		{
			return null;
		}

		internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy)
		{
			clientProxy = null;
			return null;
		}

		private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri)
		{
			objectUri = null;
			return null;
		}

		internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType)
		{
			return null;
		}

		internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri)
		{
			return null;
		}

		internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode)
		{
			return null;
		}

		private static void RegisterServerIdentity(ServerIdentity identity)
		{
		}

		internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy)
		{
			return null;
		}

		internal static object GetRemoteObject(ObjRef objRef, Type proxyType)
		{
			return null;
		}

		internal static byte[] SerializeCallData(object obj)
		{
			return null;
		}

		internal static object DeserializeCallData(byte[] array)
		{
			return null;
		}

		internal static byte[] SerializeExceptionData(Exception ex)
		{
			return null;
		}

		private static void RegisterInternalChannels()
		{
		}

		internal static void DisposeIdentity(Identity ident)
		{
		}

		internal static Identity GetMessageTargetIdentity(IMessage msg)
		{
			return null;
		}

		internal static void SetMessageTargetIdentity(IMessage msg, Identity ident)
		{
		}

		internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote)
		{
			return false;
		}

		private static string GetNormalizedUri(string uri)
		{
			return null;
		}
	}
}
