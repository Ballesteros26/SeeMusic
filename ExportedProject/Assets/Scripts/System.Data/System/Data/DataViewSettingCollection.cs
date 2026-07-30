using System.Collections;

namespace System.Data
{
	/// <summary>Contains a read-only collection of <see cref="T:System.Data.DataViewSetting" /> objects for each <see cref="T:System.Data.DataTable" /> in a <see cref="T:System.Data.DataSet" />.</summary>
	/// <filterpriority>1</filterpriority>
	public class DataViewSettingCollection
	{
		private readonly DataViewManager _dataViewManager;

		private readonly Hashtable _list;

		/// <summary>Gets the <see cref="T:System.Data.DataViewSetting" /> objects of the specified <see cref="T:System.Data.DataTable" /> from the collection. </summary>
		/// <returns>A collection of <see cref="T:System.Data.DataViewSetting" /> objects.</returns>
		/// <param name="table">The <see cref="T:System.Data.DataTable" /> to find. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public virtual DataViewSetting this[DataTable table]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void Remove(DataTable table)
		{
		}
	}
}
