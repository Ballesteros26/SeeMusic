using System.Collections.Generic;
using System.ComponentModel;
using Parse.Common.Internal;
using Parse.Core.Internal;

namespace Parse
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class ParseRelationBase : IJsonConvertible
	{
		private ParseObject parent;

		private string key;

		private string targetClassName;

		internal static IObjectSubclassingController SubclassingController => null;

		internal string TargetClassName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ParseRelationBase(ParseObject parent, string key)
		{
		}

		internal ParseRelationBase(ParseObject parent, string key, string targetClassName)
		{
		}

		internal void EnsureParentAndKey(ParseObject parent, string key)
		{
		}

		internal void Add(ParseObject obj)
		{
		}

		internal void Remove(ParseObject obj)
		{
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}

		internal ParseQuery<T> GetQuery<T>() where T : ParseObject
		{
			return null;
		}

		internal static ParseRelationBase CreateRelation(ParseObject parent, string key, string targetClassName)
		{
			return null;
		}

		private static ParseRelation<T> CreateRelation<T>(ParseObject parent, string key, string targetClassName) where T : ParseObject
		{
			return null;
		}
	}
}
