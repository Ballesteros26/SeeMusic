using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Data
{
	/// <summary>Represents a databindable, customized view of a <see cref="T:System.Data.DataTable" /> for sorting, filtering, searching, editing, and navigation. The <see cref="T:System.Data.DataView" /> does not store data, but instead represents a connected view of its corresponding <see cref="T:System.Data.DataTable" />. Changes to the <see cref="T:System.Data.DataView" />’s data will affect the <see cref="T:System.Data.DataTable" />. Changes to the <see cref="T:System.Data.DataTable" />’s data will affect all <see cref="T:System.Data.DataView" />s associated with it.</summary>
	/// <filterpriority>1</filterpriority>
	[DefaultEvent("PositionChanged")]
	[DefaultProperty("Table")]
	public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ISupportInitialize
	{
		private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
		{
			internal static readonly DataRowReferenceComparer s_default;

			private DataRowReferenceComparer()
			{
			}

			public bool Equals(DataRow x, DataRow y)
			{
				return false;
			}

			public int GetHashCode(DataRow obj)
			{
				return 0;
			}
		}

		private DataViewManager _dataViewManager;

		private DataTable _table;

		private bool _locked;

		private Index _index;

		private Dictionary<string, Index> _findIndexes;

		private string _sort;

		private Comparison<DataRow> _comparison;

		private IFilter _rowFilter;

		private DataViewRowState _recordStates;

		private bool _shouldOpen;

		private bool _open;

		private bool _allowNew;

		private bool _allowEdit;

		private bool _allowDelete;

		private bool _applyDefaultSort;

		internal DataRow _addNewRow;

		private ListChangedEventArgs _addNewMoved;

		private ListChangedEventHandler _onListChanged;

		internal static ListChangedEventArgs s_resetEventArgs;

		private DataViewRowState _delayedRecordStates;

		private bool _fEndInitInProgress;

		private Dictionary<DataRow, DataRowView> _rowViewCache;

		private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer;

		private DataViewListener _dvListener;

		private static int s_objectTypeCount;

		private readonly int _objectID;

		/// <summary>Sets or gets a value that indicates whether deletes are allowed.</summary>
		/// <returns>true, if deletes are allowed; otherwise, false.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		[DefaultValue(true)]
		public bool AllowDelete => false;

		/// <summary>Gets or sets a value that indicates whether the new rows can be added by using the <see cref="M:System.Data.DataView.AddNew" /> method.</summary>
		/// <returns>true, if new rows can be added; otherwise, false.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		[DefaultValue(true)]
		public bool AllowNew => false;

		/// <summary>Gets the number of records in the <see cref="T:System.Data.DataView" /> after <see cref="P:System.Data.DataView.RowFilter" /> and <see cref="P:System.Data.DataView.RowStateFilter" /> have been applied.</summary>
		/// <returns>The number of records in the <see cref="T:System.Data.DataView" />.</returns>
		/// <filterpriority>1</filterpriority>
		[Browsable(false)]
		public int Count => 0;

		private int CountFromIndex => 0;

		/// <summary>Gets the <see cref="T:System.Data.DataViewManager" /> associated with this view.</summary>
		/// <returns>The DataViewManager that created this view. If this is the default <see cref="T:System.Data.DataView" /> for a <see cref="T:System.Data.DataTable" />, the DataViewManager property returns the default DataViewManager for the DataSet. Otherwise, if the DataView was created without a DataViewManager, this property is null.</returns>
		/// <filterpriority>2</filterpriority>
		[Browsable(false)]
		public DataViewManager DataViewManager => null;

		/// <summary>Gets a value that indicates whether the data source is currently open and projecting views of data on the <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>true, if the source is open; otherwise, false.</returns>
		[Browsable(false)]
		protected bool IsOpen => false;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets or sets the row state filter used in the <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>One of the <see cref="T:System.Data.DataViewRowState" /> values.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		[DefaultValue(DataViewRowState.CurrentRows)]
		public DataViewRowState RowStateFilter => default(DataViewRowState);

		/// <summary>Gets or sets the sort column or columns, and sort order for the <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>A string that contains the column name followed by "ASC" (ascending) or "DESC" (descending). Columns are sorted ascending by default. Multiple columns can be separated by commas.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		[DefaultValue(null)]
		public string Sort => null;

		internal Comparison<DataRow> SortComparison => null;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Gets or sets the source <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>A <see cref="T:System.Data.DataTable" /> that provides the data for this view.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		[TypeConverter(typeof(DataTableTypeConverter))]
		[DefaultValue(null)]
		[RefreshProperties(RefreshProperties.All)]
		public DataTable Table => null;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.Item(System.Int32)" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.Item(System.Int32)" />.</returns>
		/// <param name="recordIndex">A <see cref="System.Int32" /> value.</param>
		object IList.this[int recordIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets a row of data from a specified table.</summary>
		/// <returns>A <see cref="T:System.Data.DataRowView" /> of the row that you want.</returns>
		/// <param name="recordIndex">The index of a record in the <see cref="T:System.Data.DataTable" />. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public DataRowView this[int recordIndex] => null;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsReadOnly" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.IsReadOnly" />.</returns>
		bool IList.IsReadOnly => false;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</summary>
		/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</returns>
		bool IList.IsFixedSize => false;

		internal int ObjectID => 0;

		internal DataView(DataTable table, bool locked)
		{
		}

		/// <summary>Adds a new row to the <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>A new <see cref="T:System.Data.DataRowView" /> object.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		public virtual DataRowView AddNew()
		{
			return null;
		}

		private void CheckOpen()
		{
		}

		/// <summary>Closes the <see cref="T:System.Data.DataView" />.</summary>
		protected void Close()
		{
		}

		/// <summary>Copies items into an array. Only for Web Forms Interfaces.</summary>
		/// <param name="array">array to copy into. </param>
		/// <param name="index">index to start at. </param>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public void CopyTo(Array array, int index)
		{
		}

		private void CopyTo(DataRowView[] array, int index)
		{
		}

		/// <summary>Deletes a row at the specified index.</summary>
		/// <param name="index">The index of the row to delete. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		public void Delete(int index)
		{
		}

		internal void Delete(DataRow row)
		{
		}

		/// <summary>Disposes of the resources (other than memory) used by the <see cref="T:System.Data.DataView" /> object.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		protected override void Dispose(bool disposing)
		{
		}

		internal void FinishAddNew(bool success)
		{
		}

		/// <summary>Gets an enumerator for this <see cref="T:System.Data.DataView" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for navigating through the list.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</summary>
		/// <returns>For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</returns>
		/// <param name="value">A <see cref="System.Object" /> value.</param>
		int IList.Add(object value)
		{
			return 0;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Clear" />.</summary>
		void IList.Clear()
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Contains(System.Object)" />.</summary>
		/// <returns>For a description of this member, see <see cref="M:System.Collections.IList.Contains(System.Object)" />.</returns>
		/// <param name="value">A <see cref="System.Object" /> value.</param>
		bool IList.Contains(object value)
		{
			return false;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.IndexOf(System.Object)" />.</summary>
		/// <returns>For a description of this member, see <see cref="M:System.Collections.IList.IndexOf(System.Object)" />.</returns>
		/// <param name="value">A <see cref="System.Object" /> value.</param>
		int IList.IndexOf(object value)
		{
			return 0;
		}

		internal int IndexOf(DataRowView rowview)
		{
			return 0;
		}

		private int IndexOfDataRowView(DataRowView rowview)
		{
			return 0;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Insert(System.Int32,System.Object)" />.</summary>
		/// <param name="index">A <see cref="System.Int32" /> value.</param>
		/// <param name="value">A <see cref="System.Object" /> value to be inserted.</param>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Remove(System.Object)" />.</summary>
		/// <param name="value">A <see cref="System.Object" /> value.</param>
		void IList.Remove(object value)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.RemoveAt(System.Int32)" />.</summary>
		/// <param name="index">A <see cref="System.Int32" /> value.</param>
		void IList.RemoveAt(int index)
		{
		}

		internal virtual IFilter GetFilter()
		{
			return null;
		}

		private int GetRecord(int recordIndex)
		{
			return 0;
		}

		internal DataRow GetRow(int index)
		{
			return null;
		}

		private DataRowView GetRowView(int record)
		{
			return null;
		}

		private DataRowView GetRowView(DataRow dr)
		{
			return null;
		}

		/// <summary>Occurs after a <see cref="T:System.Data.DataView" /> has been changed successfully.</summary>
		/// <param name="sender">The source of the event. </param>
		/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data. </param>
		protected virtual void IndexListChanged(object sender, ListChangedEventArgs e)
		{
		}

		internal void IndexListChangedInternal(ListChangedEventArgs e)
		{
		}

		internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
		{
		}

		/// <summary>Raises the <see cref="E:System.Data.DataView.ListChanged" /> event.</summary>
		/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data. </param>
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		/// <summary>Reserved for internal use only.</summary>
		protected void Reset()
		{
		}

		internal void ResetRowViewCache()
		{
		}

		internal void SetDataViewManager(DataViewManager dataViewManager)
		{
		}

		internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
		{
		}

		internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent)
		{
		}

		/// <summary>Reserved for internal use only.</summary>
		protected void UpdateIndex()
		{
		}

		/// <summary>Reserved for internal use only.</summary>
		/// <param name="force">Reserved for internal use only. </param>
		protected virtual void UpdateIndex(bool force)
		{
		}

		internal void UpdateIndex(bool force, bool fireEvent)
		{
		}

		internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		/// <summary>Occurs after a <see cref="T:System.Data.DataColumnCollection" /> has been changed successfully.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data. </param>
		protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e)
		{
		}
	}
}
