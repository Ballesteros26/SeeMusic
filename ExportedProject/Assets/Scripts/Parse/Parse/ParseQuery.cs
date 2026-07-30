using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Parse.Core.Internal;

namespace Parse
{
	public class ParseQuery<T> where T : ParseObject
	{
		private readonly string className;

		private readonly Dictionary<string, object> where;

		private readonly ReadOnlyCollection<string> orderBy;

		private readonly ReadOnlyCollection<string> includes;

		private readonly ReadOnlyCollection<string> selectedKeys;

		private readonly string redirectClassNameForKey;

		private readonly int? skip;

		private readonly int? limit;

		internal string ClassName => null;

		internal static IParseQueryController QueryController => null;

		internal static IObjectSubclassingController SubclassingController => null;

		private ParseQuery(ParseQuery<T> source, IDictionary<string, object> where = null, IEnumerable<string> replacementOrderBy = null, IEnumerable<string> thenBy = null, int? skip = null, int? limit = null, IEnumerable<string> includes = null, IEnumerable<string> selectedKeys = null, string redirectClassNameForKey = null)
		{
		}

		private HashSet<string> MergeIncludes(IEnumerable<string> includes)
		{
			return null;
		}

		private HashSet<string> MergeSelectedKeys(IEnumerable<string> selectedKeys)
		{
			return null;
		}

		private IDictionary<string, object> MergeWhereClauses(IDictionary<string, object> where)
		{
			return null;
		}

		public ParseQuery()
		{
		}

		public ParseQuery(string className)
		{
		}

		public static ParseQuery<T> Or(IEnumerable<ParseQuery<T>> queries)
		{
			return null;
		}

		public ParseQuery<T> OrderBy(string key)
		{
			return null;
		}

		public ParseQuery<T> OrderByDescending(string key)
		{
			return null;
		}

		public ParseQuery<T> ThenBy(string key)
		{
			return null;
		}

		public ParseQuery<T> ThenByDescending(string key)
		{
			return null;
		}

		public ParseQuery<T> Include(string key)
		{
			return null;
		}

		public ParseQuery<T> Select(string key)
		{
			return null;
		}

		public ParseQuery<T> Skip(int count)
		{
			return null;
		}

		public ParseQuery<T> Limit(int count)
		{
			return null;
		}

		internal ParseQuery<T> RedirectClassName(string key)
		{
			return null;
		}

		public ParseQuery<T> WhereContainedIn<TIn>(string key, IEnumerable<TIn> values)
		{
			return null;
		}

		public ParseQuery<T> WhereContainsAll<TIn>(string key, IEnumerable<TIn> values)
		{
			return null;
		}

		public ParseQuery<T> WhereContains(string key, string substring)
		{
			return null;
		}

		public ParseQuery<T> WhereDoesNotExist(string key)
		{
			return null;
		}

		public ParseQuery<T> WhereDoesNotMatchQuery<TOther>(string key, ParseQuery<TOther> query) where TOther : ParseObject
		{
			return null;
		}

		public ParseQuery<T> WhereEndsWith(string key, string suffix)
		{
			return null;
		}

		public ParseQuery<T> WhereEqualTo(string key, object value)
		{
			return null;
		}

		public ParseQuery<T> WhereExists(string key)
		{
			return null;
		}

		public ParseQuery<T> WhereGreaterThan(string key, object value)
		{
			return null;
		}

		public ParseQuery<T> WhereGreaterThanOrEqualTo(string key, object value)
		{
			return null;
		}

		public ParseQuery<T> WhereLessThan(string key, object value)
		{
			return null;
		}

		public ParseQuery<T> WhereLessThanOrEqualTo(string key, object value)
		{
			return null;
		}

		public ParseQuery<T> WhereMatches(string key, Regex regex, string modifiers)
		{
			return null;
		}

		public ParseQuery<T> WhereMatches(string key, Regex regex)
		{
			return null;
		}

		public ParseQuery<T> WhereMatches(string key, string pattern, string modifiers = null)
		{
			return null;
		}

		public ParseQuery<T> WhereMatches(string key, string pattern)
		{
			return null;
		}

		public ParseQuery<T> WhereMatchesKeyInQuery<TOther>(string key, string keyInQuery, ParseQuery<TOther> query) where TOther : ParseObject
		{
			return null;
		}

		public ParseQuery<T> WhereDoesNotMatchesKeyInQuery<TOther>(string key, string keyInQuery, ParseQuery<TOther> query) where TOther : ParseObject
		{
			return null;
		}

		public ParseQuery<T> WhereMatchesQuery<TOther>(string key, ParseQuery<TOther> query) where TOther : ParseObject
		{
			return null;
		}

		public ParseQuery<T> WhereNear(string key, ParseGeoPoint point)
		{
			return null;
		}

		public ParseQuery<T> WhereNotContainedIn<TIn>(string key, IEnumerable<TIn> values)
		{
			return null;
		}

		public ParseQuery<T> WhereNotEqualTo(string key, object value)
		{
			return null;
		}

		public ParseQuery<T> WhereStartsWith(string key, string suffix)
		{
			return null;
		}

		public ParseQuery<T> WhereWithinGeoBox(string key, ParseGeoPoint southwest, ParseGeoPoint northeast)
		{
			return null;
		}

		public ParseQuery<T> WhereWithinDistance(string key, ParseGeoPoint point, ParseGeoDistance maxDistance)
		{
			return null;
		}

		internal ParseQuery<T> WhereRelatedTo(ParseObject parent, string key)
		{
			return null;
		}

		public Task<IEnumerable<T>> FindAsync()
		{
			return null;
		}

		public Task<IEnumerable<T>> FindAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<T> FirstOrDefaultAsync()
		{
			return null;
		}

		public Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<T> FirstAsync()
		{
			return null;
		}

		public Task<T> FirstAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<int> CountAsync()
		{
			return null;
		}

		public Task<int> CountAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<T> GetAsync(string objectId)
		{
			return null;
		}

		public Task<T> GetAsync(string objectId, CancellationToken cancellationToken)
		{
			return null;
		}

		internal object GetConstraint(string key)
		{
			return null;
		}

		internal IDictionary<string, object> BuildParameters(bool includeClassName = false)
		{
			return null;
		}

		private string RegexQuote(string input)
		{
			return null;
		}

		private string GetRegexOptions(Regex regex, string modifiers)
		{
			return null;
		}

		private IDictionary<string, object> EncodeRegex(Regex regex, string modifiers)
		{
			return null;
		}

		private void EnsureNotInstallationQuery()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
