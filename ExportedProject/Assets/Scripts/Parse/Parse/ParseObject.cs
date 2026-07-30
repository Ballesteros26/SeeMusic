using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Parse.Common.Internal;
using Parse.Core.Internal;

namespace Parse
{
	public class ParseObject : IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged
	{
		[CompilerGenerated]
		private sealed class _003CDeepTraversalInternal_003Ed__43 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private ICollection<object> seen;

			public ICollection<object> _003C_003E3__seen;

			private object root;

			public object _003C_003E3__root;

			private bool traverseParseObjects;

			public bool _003C_003E3__traverseParseObjects;

			private IEnumerator _003C_003E7__wrap1;

			private object _003Ci_003E5__3;

			private IEnumerator<object> _003C_003E7__wrap3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDeepTraversalInternal_003Ed__43(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly string AutoClassName;

		private static readonly bool isCompiledByIL2CPP;

		internal readonly object mutex;

		private readonly LinkedList<IDictionary<string, IParseFieldOperation>> operationSetQueue;

		private readonly IDictionary<string, object> estimatedData;

		private static readonly ThreadLocal<bool> isCreatingPointer;

		private bool hasBeenFetched;

		private bool dirty;

		internal TaskQueue taskQueue;

		private IObjectState state;

		private SynchronizedEventHandler<PropertyChangedEventArgs> propertyChanged;

		internal IObjectState State => null;

		internal static IParseObjectController ObjectController => null;

		internal static IObjectSubclassingController SubclassingController => null;

		private bool HasDirtyChildren => false;

		private bool CanBeSerialized => false;

		public virtual object this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsDataAvailable => false;

		internal IDictionary<string, IParseFieldOperation> CurrentOperations => null;

		public ICollection<string> Keys => null;

		[ParseFieldName("ACL")]
		public ParseACL ACL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsNew
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		[ParseFieldName("updatedAt")]
		public DateTime? UpdatedAt => null;

		[ParseFieldName("createdAt")]
		public DateTime? CreatedAt => null;

		public bool IsDirty
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		[ParseFieldName("objectId")]
		public string ObjectId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ClassName => null;

		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal void MutateState(Action<MutableObjectState> func)
		{
		}

		protected ParseObject()
		{
		}

		public ParseObject(string className)
		{
		}

		public static ParseObject Create(string className)
		{
			return null;
		}

		public static ParseObject CreateWithoutData(string className, string objectId)
		{
			return null;
		}

		public static T Create<T>() where T : ParseObject
		{
			return null;
		}

		public static T CreateWithoutData<T>(string objectId) where T : ParseObject
		{
			return null;
		}

		internal static T FromState<T>(IObjectState state, string defaultClassName) where T : ParseObject
		{
			return null;
		}

		private static string GetFieldForPropertyName(string className, string propertyName)
		{
			return null;
		}

		protected void SetProperty<T>(T value, [CallerMemberName] string propertyName = null)
		{
		}

		protected ParseRelation<T> GetRelationProperty<T>([CallerMemberName] string propertyName = null) where T : ParseObject
		{
			return null;
		}

		protected T GetProperty<T>([CallerMemberName] string propertyName = null)
		{
			return default(T);
		}

		protected T GetProperty<T>(T defaultValue, [CallerMemberName] string propertyName = null)
		{
			return default(T);
		}

		internal virtual void SetDefaultValues()
		{
		}

		public static void RegisterSubclass<T>() where T : ParseObject, new()
		{
		}

		public static void RegisterSubclass(Type type)
		{
		}

		internal static void UnregisterSubclass<T>() where T : ParseObject, new()
		{
		}

		internal static void UnregisterSubclass(Type type)
		{
		}

		public void Revert()
		{
		}

		internal virtual void HandleFetchResult(IObjectState serverState)
		{
		}

		internal void HandleFailedSave(IDictionary<string, IParseFieldOperation> operationsBeforeSave)
		{
		}

		internal virtual void HandleSave(IObjectState serverState)
		{
		}

		internal virtual void MergeFromServer(IObjectState serverState)
		{
		}

		internal void MergeFromObject(ParseObject other)
		{
		}

		internal static IEnumerable<object> DeepTraversal(object root, bool traverseParseObjects = false, bool yieldRoot = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDeepTraversalInternal_003Ed__43))]
		private static IEnumerable<object> DeepTraversalInternal(object root, bool traverseParseObjects, ICollection<object> seen)
		{
			return null;
		}

		private IEnumerable<ParseObject> FindUnsavedChildren()
		{
			return null;
		}

		private IDictionary<string, ParseObject> CollectFetchedObjects()
		{
			return null;
		}

		internal static IDictionary<string, object> ToJSONObjectForSaving(IDictionary<string, IParseFieldOperation> operations)
		{
			return null;
		}

		internal IDictionary<string, object> ServerDataToJSONObjectForSerialization()
		{
			return null;
		}

		internal IDictionary<string, IParseFieldOperation> StartSave()
		{
			return null;
		}

		protected virtual Task SaveAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task SaveAsync()
		{
			return null;
		}

		public Task SaveAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal virtual Task<ParseObject> FetchAsyncInternal(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		private static Task DeepSaveAsync(object obj, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task SaveAllAsync<T>(IEnumerable<T> objects) where T : ParseObject
		{
			return null;
		}

		public static Task SaveAllAsync<T>(IEnumerable<T> objects, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		internal Task<ParseObject> FetchAsyncInternal(CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task<ParseObject> FetchIfNeededAsyncInternal(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task<ParseObject> FetchIfNeededAsyncInternal(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllIfNeededAsync<T>(IEnumerable<T> objects) where T : ParseObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllIfNeededAsync<T>(IEnumerable<T> objects, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllAsync<T>(IEnumerable<T> objects) where T : ParseObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllAsync<T>(IEnumerable<T> objects, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		private static Task<IEnumerable<T>> FetchAllInternalAsync<T>(IEnumerable<T> objects, bool force, Task toAwait, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		internal Task DeleteAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task DeleteAsync()
		{
			return null;
		}

		public Task DeleteAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task DeleteAllAsync<T>(IEnumerable<T> objects) where T : ParseObject
		{
			return null;
		}

		public static Task DeleteAllAsync<T>(IEnumerable<T> objects, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		private static void CollectDirtyChildren(object node, IList<ParseObject> dirtyChildren, ICollection<ParseObject> seen, ICollection<ParseObject> seenNew)
		{
		}

		private static void CollectDirtyChildren(object node, IList<ParseObject> dirtyChildren)
		{
		}

		private static bool CanBeSerializedAsValue(object value)
		{
			return false;
		}

		private static Task<T> EnqueueForAll<T>(IEnumerable<ParseObject> objects, Func<Task, Task<T>> taskStart, CancellationToken cancellationToken)
		{
			return null;
		}

		public virtual void Remove(string key)
		{
		}

		private void ApplyOperations(IDictionary<string, IParseFieldOperation> operations, IDictionary<string, object> map)
		{
		}

		internal void RebuildEstimatedData()
		{
		}

		internal void PerformOperation(string key, IParseFieldOperation operation)
		{
		}

		internal virtual void OnSettingValue(ref string key, ref object value)
		{
		}

		internal void Set(string key, object value)
		{
		}

		internal void SetIfDifferent<T>(string key, T value)
		{
		}

		public void Increment(string key)
		{
		}

		public void Increment(string key, long amount)
		{
		}

		public void Increment(string key, double amount)
		{
		}

		public void AddToList(string key, object value)
		{
		}

		public void AddRangeToList<T>(string key, IEnumerable<T> values)
		{
		}

		public void AddUniqueToList(string key, object value)
		{
		}

		public void AddRangeUniqueToList<T>(string key, IEnumerable<T> values)
		{
		}

		public void RemoveAllFromList<T>(string key, IEnumerable<T> values)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public T Get<T>(string key)
		{
			return default(T);
		}

		public ParseRelation<T> GetRelation<T>(string key) where T : ParseObject
		{
			return null;
		}

		public bool TryGetValue<T>(string key, out T result)
		{
			result = default(T);
			return false;
		}

		private bool CheckIsDataAvailable(string key)
		{
			return false;
		}

		private void CheckGetAccess(string key)
		{
		}

		private void CheckKeyIsMutable(string key)
		{
		}

		protected virtual bool IsKeyMutable(string key)
		{
			return false;
		}

		public bool HasSameId(ParseObject other)
		{
			return false;
		}

		public bool IsKeyDirty(string key)
		{
			return false;
		}

		private bool CheckIsDirty(bool considerChildren)
		{
			return false;
		}

		private void SetObjectIdInternal(string objectId)
		{
		}

		public void Add(string key, object value)
		{
		}

		IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public static ParseQuery<ParseObject> GetQuery(string className)
		{
			return null;
		}

		protected void OnFieldsChanged(IEnumerable<string> fieldNames)
		{
		}

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
		}
	}
}
