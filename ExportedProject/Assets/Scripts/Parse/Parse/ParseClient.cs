using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Parse
{
	public static class ParseClient
	{
		public struct Configuration
		{
			public interface IStorageConfiguration
			{
				string RelativeStorageFilePath { get; }
			}

			public struct MetadataBasedStorageConfiguration : IStorageConfiguration
			{
				public static MetadataBasedStorageConfiguration CompanyInferred { get; }

				public string CompanyName { get; set; }

				public string ProductName { get; set; }

				public string RelativeStorageFilePath => null;
			}

			public struct IdentifierBasedStorageConfiguration : IStorageConfiguration
			{
				internal static IdentifierBasedStorageConfiguration Fallback { get; }

				internal bool IsFallback { get; set; }

				public string Identifier { get; set; }

				public string RelativeStorageFilePath => null;

				private string GeneratePath()
				{
					return null;
				}
			}

			public struct VersionInformation
			{
				private string _buildVersion;

				private string _displayVersion;

				public static VersionInformation Inferred { get; }

				public string BuildVersion
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public string DisplayVersion
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public string OSVersion { get; set; }

				internal bool IsDefault => false;

				internal bool CanBeUsedForInference => false;
			}

			public string ApplicationID { get; set; }

			public string ServerURI { get; set; }

			public string Key { get; set; }

			public string MasterKey
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public IDictionary<string, string> AuxiliaryHeaders { get; set; }

			public VersionInformation VersionInfo { get; set; }

			public IStorageConfiguration StorageConfiguration { get; set; }
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReflectStorageChangeAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string originalRelativePath;

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

		internal static readonly string[] DateFormatStrings;

		private static readonly object mutex;

		public static Configuration CurrentConfiguration { get; internal set; }

		internal static string MasterKey { get; set; }

		internal static Version Version => null;

		internal static string VersionString { get; }

		static ParseClient()
		{
		}

		public static void Initialize(string identifier, string serverURI)
		{
		}

		public static void Initialize(Configuration configuration)
		{
		}

		[AsyncStateMachine(typeof(_003CReflectStorageChangeAsync_003Ed__19))]
		public static Task ReflectStorageChangeAsync(string originalRelativePath)
		{
			return null;
		}

		internal static string BuildQueryString(IDictionary<string, object> parameters)
		{
			return null;
		}

		internal static IDictionary<string, string> DecodeQueryString(string queryString)
		{
			return null;
		}

		internal static IDictionary<string, object> DeserializeJsonString(string jsonData)
		{
			return null;
		}

		internal static string SerializeJsonString(IDictionary<string, object> jsonData)
		{
			return null;
		}
	}
}
