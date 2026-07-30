using System.Collections;
using System.Reflection;

namespace System.Diagnostics
{
	/// <summary>Identifies a switch used in an assembly, class, or member.</summary>
	/// <filterpriority>1</filterpriority>
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public sealed class SwitchAttribute : Attribute
	{
		private Type type;

		private string name;

		private string description;

		/// <summary>Gets or sets the display name of the switch.</summary>
		/// <returns>The display name of the switch.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="P:System.Diagnostics.SwitchAttribute.SwitchName" /> is set to null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Diagnostics.SwitchAttribute.SwitchName" /> is set to an empty string.</exception>
		/// <filterpriority>2</filterpriority>
		public string SwitchName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the type of the switch.</summary>
		/// <returns>The type of the switch.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="P:System.Diagnostics.SwitchAttribute.SwitchType" /> is set to null.</exception>
		/// <filterpriority>2</filterpriority>
		public Type SwitchType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the description of the switch.</summary>
		/// <returns>The description of the switch.</returns>
		/// <filterpriority>2</filterpriority>
		public string SwitchDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.SwitchAttribute" /> class, specifying the name and the type of the switch. </summary>
		/// <param name="switchName">The display name of the switch.</param>
		/// <param name="switchType">The type of the switch.</param>
		public SwitchAttribute(string switchName, Type switchType)
		{
		}

		/// <summary>Returns all switch attributes for the specified assembly.</summary>
		/// <returns>An array that contains all the switch attributes for the assembly.</returns>
		/// <param name="assembly">The assembly to check for switch attributes.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assembly" /> is null.</exception>
		/// <filterpriority>1</filterpriority>
		public static SwitchAttribute[] GetAll(Assembly assembly)
		{
			return null;
		}

		private static void GetAllRecursive(Type type, ArrayList switchAttribs)
		{
		}

		private static void GetAllRecursive(MemberInfo member, ArrayList switchAttribs)
		{
		}
	}
}
