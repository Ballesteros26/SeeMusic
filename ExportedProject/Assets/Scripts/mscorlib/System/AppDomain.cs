using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Threading;

namespace System
{
	/// <summary>Represents an application domain, which is an isolated environment where applications execute. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	[StructLayout((LayoutKind)0)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public sealed class AppDomain : MarshalByRefObject
	{
		private IntPtr _mono_app_domain;

		private static string _process_guid;

		[ThreadStatic]
		private static Dictionary<string, object> type_resolve_in_progress;

		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress;

		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress_refonly;

		private object _evidence;

		private object _granted;

		private int _principalPolicy;

		[CompilerGenerated]
		private AssemblyLoadEventHandler AssemblyLoad;

		[CompilerGenerated]
		private ResolveEventHandler AssemblyResolve;

		[CompilerGenerated]
		private ResolveEventHandler ResourceResolve;

		[CompilerGenerated]
		private ResolveEventHandler TypeResolve;

		[CompilerGenerated]
		private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;

		private object _domain_manager;

		[CompilerGenerated]
		private ResolveEventHandler ReflectionOnlyAssemblyResolve;

		private object _activation;

		private object _applicationIdentity;

		private List<string> compatibility_switch;

		/// <summary>Gets the friendly name of this application domain.</summary>
		/// <returns>The friendly name of this application domain.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <filterpriority>2</filterpriority>
		public string FriendlyName => null;

		/// <summary>Gets the current application domain for the current <see cref="T:System.Threading.Thread" />.</summary>
		/// <returns>The current application domain.</returns>
		/// <filterpriority>1</filterpriority>
		public static AppDomain CurrentDomain => null;

		/// <summary>Gets a value that indicates whether the current application domain has a set of permissions that is granted to all assemblies that are loaded into the application domain.</summary>
		/// <returns>true if the current application domain has a homogenous set of permissions; otherwise, false.</returns>
		[MonoTODO]
		public bool IsHomogenous => false;

		/// <summary>Gets a value that indicates whether assemblies that are loaded into the current application domain execute with full trust.</summary>
		/// <returns>true if assemblies that are loaded into the current application domain execute with full trust; otherwise, false.</returns>
		[MonoTODO]
		public bool IsFullyTrusted => false;

		/// <summary>Occurs when an <see cref="T:System.AppDomain" /> is about to be unloaded.</summary>
		/// <filterpriority>2</filterpriority>
		public event EventHandler DomainUnload
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		/// <summary>Occurs when the default application domain's parent process exits.</summary>
		/// <filterpriority>2</filterpriority>
		public event EventHandler ProcessExit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		/// <summary>Occurs when an exception is not caught.</summary>
		/// <filterpriority>2</filterpriority>
		public event UnhandledExceptionEventHandler UnhandledException
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Intrinsic]
		internal static bool IsAppXModel()
		{
			return false;
		}

		private AppDomain()
		{
		}

		private string getFriendlyName()
		{
			return null;
		}

		private static AppDomain getCurDomain()
		{
			return null;
		}

		private Assembly[] GetAssemblies(bool refOnly)
		{
			return null;
		}

		/// <summary>Gets the assemblies that have been loaded into the execution context of this application domain.</summary>
		/// <returns>An array of assemblies in this application domain.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <filterpriority>2</filterpriority>
		public Assembly[] GetAssemblies()
		{
			return null;
		}

		/// <summary>Gets the value stored in the current application domain for the specified name.</summary>
		/// <returns>The value of the <paramref name="name" /> property, or null if the property does not exist.</returns>
		/// <param name="name">The name of a predefined application domain property, or the name of an application domain property you have defined.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public object GetData(string name)
		{
			return null;
		}

		/// <summary>Gives the <see cref="T:System.AppDomain" /> an infinite lifetime by preventing a lease from being created.</summary>
		/// <returns>Always null.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <filterpriority>2</filterpriority>
		public override object InitializeLifetimeService()
		{
			return null;
		}

		internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark)
		{
			return null;
		}

		/// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <returns>The loaded assembly.</returns>
		/// <param name="assemblyRef">An object that describes the assembly to load. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyRef" /> is null. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyRef" /> is not found. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyRef" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyRef" /> was compiled with a later version.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public Assembly Load(AssemblyName assemblyRef)
		{
			return null;
		}

		/// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <returns>The loaded assembly.</returns>
		/// <param name="assemblyRef">An object that describes the assembly to load. </param>
		/// <param name="assemblySecurity">Evidence for loading the assembly. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyRef" /> is null</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyRef" /> is not found. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyRef" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyRef" /> was compiled with a later version.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity)
		{
			return null;
		}

		/// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its display name.</summary>
		/// <returns>The loaded assembly.</returns>
		/// <param name="assemblyString">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyString" /> is null</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyString" /> is not found. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Assembly Load(string assemblyString)
		{
			return null;
		}

		internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark)
		{
			return null;
		}

		private static AppDomain InternalSetDomainByID(int domain_id)
		{
			return null;
		}

		private static AppDomain InternalSetDomain(AppDomain context)
		{
			return null;
		}

		internal static void InternalPushDomainRefByID(int domain_id)
		{
		}

		internal static void InternalPopDomainRef()
		{
		}

		internal static Context InternalSetContext(Context context)
		{
			return null;
		}

		internal static Context InternalGetContext()
		{
			return null;
		}

		internal static Context InternalGetDefaultContext()
		{
			return null;
		}

		internal static string InternalGetProcessGuid(string newguid)
		{
			return null;
		}

		internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args)
		{
			return null;
		}

		internal static string GetProcessGuid()
		{
			return null;
		}

		private static bool InternalIsFinalizingForUnload(int domain_id)
		{
			return false;
		}

		/// <summary>Indicates whether this application domain is unloading, and the objects it contains are being finalized by the common language runtime.</summary>
		/// <returns>true if this application domain is unloading and the common language runtime has started invoking finalizers; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		public bool IsFinalizingForUnload()
		{
			return false;
		}

		private int getDomainID()
		{
			return 0;
		}

		/// <summary>Obtains a string representation that includes the friendly name of the application domain and any context policies.</summary>
		/// <returns>A string formed by concatenating the literal string "Name:", the friendly name of the application domain, and either string representations of the context policies or the string "There are no context policies." </returns>
		/// <exception cref="T:System.AppDomainUnloadedException">The application domain represented by the current <see cref="T:System.AppDomain" /> has been unloaded.</exception>
		/// <filterpriority>2</filterpriority>
		public override string ToString()
		{
			return null;
		}

		private void DoAssemblyLoad(Assembly assembly)
		{
		}

		private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
		{
			return null;
		}

		internal Assembly DoTypeResolve(string name)
		{
			return null;
		}

		private void DoDomainUnload()
		{
		}

		internal byte[] GetMarshalledDomainObjRef()
		{
			return null;
		}

		internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm)
		{
			arrResponse = null;
			cadMrm = null;
		}
	}
}
