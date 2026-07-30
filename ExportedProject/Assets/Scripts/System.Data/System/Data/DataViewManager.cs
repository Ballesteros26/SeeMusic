using System.ComponentModel;

namespace System.Data
{
	/// <summary>Contains a default <see cref="T:System.Data.DataViewSettingCollection" /> for each <see cref="T:System.Data.DataTable" /> in a <see cref="T:System.Data.DataSet" />.</summary>
	/// <filterpriority>1</filterpriority>
	public class DataViewManager : MarshalByValueComponent
	{
		private DataViewSettingCollection _dataViewSettingsCollection;

		internal int _nViews;

		private static NotSupportedException s_notSupported;

		/// <summary>Gets the <see cref="T:System.Data.DataViewSettingCollection" /> for each <see cref="T:System.Data.DataTable" /> in the <see cref="T:System.Data.DataSet" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataViewSettingCollection" /> for each DataTable.</returns>
		/// <filterpriority>1</filterpriority>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataViewSettingCollection DataViewSettings => null;
	}
}
