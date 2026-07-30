using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" /> interface to create a message that responds to a call to instantiate a remote object.</summary>
	[Serializable]
	[ComVisible(true)]
	[CLSCompliant(false)]
	public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
	{
		/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public override IDictionary Properties => null;

		internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg)
			: base((Exception)null, (IMethodCallMessage)null)
		{
		}

		internal ConstructionResponse(Exception e, IMethodCallMessage msg)
			: base((Exception)null, (IMethodCallMessage)null)
		{
		}

		internal ConstructionResponse(SerializationInfo info, StreamingContext context)
			: base((Exception)null, (IMethodCallMessage)null)
		{
		}
	}
}
