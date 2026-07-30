using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Specifies a set of values that are used when you start a process.</summary>
	/// <filterpriority>2</filterpriority>
	[StructLayout((LayoutKind)0)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public sealed class ProcessStartInfo
	{
		private string fileName;

		private string arguments;

		private string directory;

		private string verb;

		private ProcessWindowStyle windowStyle;

		private bool errorDialog;

		private IntPtr errorDialogParentHandle;

		private bool useShellExecute;

		private string userName;

		private string domain;

		private SecureString password;

		private string passwordInClearText;

		private bool loadUserProfile;

		private bool redirectStandardInput;

		private bool redirectStandardOutput;

		private bool redirectStandardError;

		private Encoding standardOutputEncoding;

		private Encoding standardErrorEncoding;

		private bool createNoWindow;

		private WeakReference weakParentProcess;

		internal StringDictionary environmentVariables;

		private static readonly string[] empty;

		private Collection<string> _argumentList;

		private IDictionary<string, string> environment;

		public Collection<string> ArgumentList => null;

		/// <summary>Gets or sets the verb to use when opening the application or document specified by the <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property.</summary>
		/// <returns>The action to take with the file that the process opens. The default is an empty string (""), which signifies no action.</returns>
		/// <filterpriority>2</filterpriority>
		[NotifyParentProperty(true)]
		[TypeConverter("System.Diagnostics.Design.VerbConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("The verb to apply to the document specified by the FileName property.")]
		[DefaultValue(null)]
		public string Verb
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the set of command-line arguments to use when starting the application.</summary>
		/// <returns>File type–specific arguments that the system can associate with the application specified in the <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property. The default is an empty string (""). On Windows Vista and earlier versions of the Windows operating system, the length of the arguments added to the length of the full path to the process must be less than 2080. On Windows 7 and later versions, the length must be less than 32699.</returns>
		/// <filterpriority>1</filterpriority>
		[NotifyParentProperty(true)]
		[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[SettingsBindable(true)]
		[DefaultValue(null)]
		public string Arguments
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value indicating whether to start the process in a new window.</summary>
		/// <returns>true if the process should be started without creating a new window to contain it; otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		[DefaultValue(false)]
		[MonitoringDescription("Whether to start the process without creating a new window to contain it.")]
		[NotifyParentProperty(true)]
		public bool CreateNoWindow
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets search paths for files, directories for temporary files, application-specific options, and other similar information.</summary>
		/// <returns>A string dictionary that provides environment variables that apply to this process and child processes. The default is null.</returns>
		/// <filterpriority>1</filterpriority>
		[NotifyParentProperty(true)]
		[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[DefaultValue(null)]
		public StringDictionary EnvironmentVariables => null;

		[DefaultValue(null)]
		[NotifyParentProperty(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IDictionary<string, string> Environment => null;

		/// <summary>Gets or sets a value indicating whether the input for an application is read from the <see cref="P:System.Diagnostics.Process.StandardInput" /> stream.</summary>
		/// <returns>true if input should be read from <see cref="P:System.Diagnostics.Process.StandardInput" />; otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		[DefaultValue(false)]
		[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
		[NotifyParentProperty(true)]
		public bool RedirectStandardInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value that indicates whether the output of an application is written to the <see cref="P:System.Diagnostics.Process.StandardOutput" /> stream.</summary>
		/// <returns>true if output should be written to <see cref="P:System.Diagnostics.Process.StandardOutput" />; otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		[NotifyParentProperty(true)]
		[DefaultValue(false)]
		[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
		public bool RedirectStandardOutput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value that indicates whether the error output of an application is written to the <see cref="P:System.Diagnostics.Process.StandardError" /> stream.</summary>
		/// <returns>true if error output should be written to <see cref="P:System.Diagnostics.Process.StandardError" />; otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		[DefaultValue(false)]
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
		public bool RedirectStandardError
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the preferred encoding for error output.</summary>
		/// <returns>An object that represents the preferred encoding for error output. The default is null.</returns>
		public Encoding StandardErrorEncoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the preferred encoding for standard output.</summary>
		/// <returns>An object that represents the preferred encoding for standard output. The default is null.</returns>
		public Encoding StandardOutputEncoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value indicating whether to use the operating system shell to start the process.</summary>
		/// <returns>true if the shell should be used when starting the process; false if the process should be created directly from the executable file. The default is true.</returns>
		/// <filterpriority>2</filterpriority>
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether to use the operating system shell to start the process.")]
		[DefaultValue(true)]
		public bool UseShellExecute
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the user name to be used when starting the process.</summary>
		/// <returns>The user name to use when starting the process.</returns>
		/// <filterpriority>1</filterpriority>
		[NotifyParentProperty(true)]
		public string UserName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a secure string that contains the user password to use when starting the process.</summary>
		/// <returns>The user password to use when starting the process.</returns>
		/// <filterpriority>1</filterpriority>
		public SecureString Password
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string PasswordInClearText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value that identifies the domain to use when starting the process. </summary>
		/// <returns>The Active Directory domain to use when starting the process. The domain property is primarily of interest to users within enterprise environments that use Active Directory.</returns>
		/// <filterpriority>1</filterpriority>
		[NotifyParentProperty(true)]
		public string Domain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value that indicates whether the Windows user profile is to be loaded from the registry. </summary>
		/// <returns>true if the Windows user profile should be loaded; otherwise, false. The default is false.</returns>
		/// <filterpriority>1</filterpriority>
		[NotifyParentProperty(true)]
		public bool LoadUserProfile
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the application or document to start.</summary>
		/// <returns>The name of the application to start, or the name of a document of a file type that is associated with an application and that has a default open action available to it. The default is an empty string ("").</returns>
		/// <filterpriority>1</filterpriority>
		[NotifyParentProperty(true)]
		[DefaultValue(null)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[SettingsBindable(true)]
		[MonitoringDescription("The name of the application, document or URL to start.")]
		[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string FileName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>When the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property is false, gets or sets the working directory for the process to be started. When <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> is true, gets or sets the directory that contains the process to be started.</summary>
		/// <returns>When <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> is true, the fully qualified name of the directory that contains the process to be started. When the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property is false, the working directory for the process to be started. The default is an empty string ("").</returns>
		/// <filterpriority>1</filterpriority>
		[MonitoringDescription("The initial working directory for the process.")]
		[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[SettingsBindable(true)]
		[DefaultValue(null)]
		[NotifyParentProperty(true)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string WorkingDirectory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value indicating whether an error dialog box is displayed to the user if the process cannot be started.</summary>
		/// <returns>true if an error dialog box should be displayed on the screen if the process cannot be started; otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		[NotifyParentProperty(true)]
		[DefaultValue(false)]
		[MonitoringDescription("Whether to show an error dialog to the user if there is an error.")]
		public bool ErrorDialog
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the window handle to use when an error dialog box is shown for a process that cannot be started.</summary>
		/// <returns>A pointer to the handle of the error dialog box that results from a process start failure.</returns>
		/// <filterpriority>2</filterpriority>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IntPtr ErrorDialogParentHandle
		{
			get
			{
				return (IntPtr)0;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the window state to use when the process is started.</summary>
		/// <returns>One of the enumeration values that indicates whether the process is started in a window that is maximized, minimized, normal (neither maximized nor minimized), or not visible. The default is Normal.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The window style is not one of the <see cref="T:System.Diagnostics.ProcessWindowStyle" /> enumeration members. </exception>
		/// <filterpriority>2</filterpriority>
		[DefaultValue(ProcessWindowStyle.Normal)]
		[MonitoringDescription("How the main window should be created when the process starts.")]
		[NotifyParentProperty(true)]
		public ProcessWindowStyle WindowStyle
		{
			get
			{
				return default(ProcessWindowStyle);
			}
			set
			{
			}
		}

		internal bool HaveEnvVars => false;

		public Encoding StandardInputEncoding { get; set; }

		/// <summary>Gets the set of verbs associated with the type of file specified by the <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property.</summary>
		/// <returns>The actions that the system can apply to the file indicated by the <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property.</returns>
		/// <filterpriority>2</filterpriority>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string[] Verbs => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessStartInfo" /> class without specifying a file name with which to start the process.</summary>
		public ProcessStartInfo()
		{
		}

		internal ProcessStartInfo(Process parent)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessStartInfo" /> class and specifies a file name such as an application or document with which to start the process.</summary>
		/// <param name="fileName">An application or document with which to start a process. </param>
		public ProcessStartInfo(string fileName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessStartInfo" /> class, specifies an application file name with which to start the process, and specifies a set of command-line arguments to pass to the application.</summary>
		/// <param name="fileName">An application with which to start a process. </param>
		/// <param name="arguments">Command-line arguments to pass to the application when the process starts. </param>
		public ProcessStartInfo(string fileName, string arguments)
		{
		}
	}
}
