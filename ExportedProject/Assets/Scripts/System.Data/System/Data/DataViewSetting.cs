using System.ComponentModel;

namespace System.Data
{
	/// <summary>Represents the default settings for <see cref="P:System.Data.DataView.ApplyDefaultSort" />, <see cref="P:System.Data.DataView.DataViewManager" />, <see cref="P:System.Data.DataView.RowFilter" />, <see cref="P:System.Data.DataView.RowStateFilter" />, <see cref="P:System.Data.DataView.Sort" />, and <see cref="P:System.Data.DataView.Table" /> for DataViews created from the <see cref="T:System.Data.DataViewManager" />.</summary>
	/// <filterpriority>1</filterpriority>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class DataViewSetting
	{
		private DataViewManager _dataViewManager;

		private DataTable _table;

		private string _sort;

		private string _rowFilter;

		private DataViewRowState _rowStateFilter;

		private bool _applyDefaultSort;

		/// <summary>Gets or sets a value indicating whether to use the default sort.</summary>
		/// <returns>true if the default sort is used; otherwise false.</returns>
		/// <filterpriority>1</filterpriority>
		public bool ApplyDefaultSort => false;

		/// <summary>Gets or sets the filter to apply in the <see cref="T:System.Data.DataView" />. See <see cref="P:System.Data.DataView.RowFilter" /> for a code sample using RowFilter.</summary>
		/// <returns>A string that contains the filter to apply.</returns>
		/// <filterpriority>1</filterpriority>
		public string RowFilter => null;

		/// <summary>Gets or sets a value indicating whether to display Current, Deleted, Modified Current, ModifiedOriginal, New, Original, Unchanged, or no rows in the <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>A value that indicates which rows to display.</returns>
		/// <filterpriority>1</filterpriority>
		public DataViewRowState RowStateFilter => default(DataViewRowState);

		/// <summary>Gets or sets a value indicating the sort to apply in the <see cref="T:System.Data.DataView" />. </summary>
		/// <returns>The sort to apply in the <see cref="T:System.Data.DataView" />.</returns>
		/// <filterpriority>1</filterpriority>
		public string Sort => null;

		internal DataViewSetting()
		{
		}

		internal void SetDataViewManager(DataViewManager dataViewManager)
		{
		}

		internal void SetDataTable(DataTable table)
		{
		}
	}
}
