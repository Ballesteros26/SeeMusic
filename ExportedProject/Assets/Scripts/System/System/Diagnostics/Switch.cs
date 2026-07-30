using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml.Serialization;

namespace System.Diagnostics
{
	/// <summary>Provides an abstract base class to create new debugging and tracing switches.</summary>
	/// <filterpriority>2</filterpriority>
	public abstract class Switch
	{
		private object switchSettings;

		private readonly string description;

		private readonly string displayName;

		private int switchSetting;

		private bool initialized;

		private bool initializing;

		private string switchValueString;

		private StringDictionary attributes;

		private string defaultValue;

		private object m_intializedLock;

		private static List<WeakReference> switches;

		private static int s_LastCollectionCount;

		private object IntializedLock => null;

		/// <summary>Gets the custom switch attributes defined in the application configuration file.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.StringDictionary" /> containing the case-insensitive custom attributes for the trace switch.</returns>
		/// <filterpriority>1</filterpriority>
		[XmlIgnore]
		public StringDictionary Attributes => null;

		/// <summary>Gets a name used to identify the switch.</summary>
		/// <returns>The name used to identify the switch. The default value is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		public string DisplayName => null;

		/// <summary>Gets a description of the switch.</summary>
		/// <returns>The description of the switch. The default value is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		public string Description => null;

		/// <summary>Gets or sets the current setting for this switch.</summary>
		/// <returns>The current setting for this switch. The default is zero.</returns>
		protected int SwitchSetting
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the value of the switch.</summary>
		/// <returns>A string representing the value of the switch.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">The value is null.-or-The value does not consist solely of an optional negative sign followed by a sequence of digits ranging from 0 to 9.-or-The value represents a number less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		protected string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Switch" /> class.</summary>
		/// <param name="displayName">The name of the switch. </param>
		/// <param name="description">The description for the switch. </param>
		protected Switch(string displayName, string description)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Switch" /> class, specifying the display name, description, and default value for the switch. </summary>
		/// <param name="displayName">The name of the switch. </param>
		/// <param name="description">The description of the switch. </param>
		/// <param name="defaultSwitchValue">The default value for the switch.</param>
		protected Switch(string displayName, string description, string defaultSwitchValue)
		{
		}

		private static void _pruneCachedSwitches()
		{
		}

		private void Initialize()
		{
		}

		private bool InitializeWithStatus()
		{
			return false;
		}

		private bool InitializeConfigSettings()
		{
			return false;
		}

		/// <summary>Gets the custom attributes supported by the switch.</summary>
		/// <returns>A string array that contains the names of the custom attributes supported by the switch, or null if there no custom attributes are supported.</returns>
		protected internal virtual string[] GetSupportedAttributes()
		{
			return null;
		}

		/// <summary>Invoked when the <see cref="P:System.Diagnostics.Switch.SwitchSetting" /> property is changed.</summary>
		protected virtual void OnSwitchSettingChanged()
		{
		}

		/// <summary>Invoked when the <see cref="P:System.Diagnostics.Switch.Value" /> property is changed.</summary>
		protected virtual void OnValueChanged()
		{
		}

		internal static void RefreshAll()
		{
		}

		internal void Refresh()
		{
		}
	}
}
