using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		private readonly List<JToken> _values;

		protected override IList<JToken> ChildrenTokens => null;

		public override JTokenType Type => default(JTokenType);

		public JToken this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsReadOnly => false;

		public JArray()
		{
		}

		internal JArray(JArray other, JsonCloneSettings? settings)
		{
		}

		public JArray(object content)
		{
		}

		internal override JToken CloneToken(JsonCloneSettings? settings = null)
		{
			return null;
		}

		public static JArray Load(JsonReader reader, JsonLoadSettings? settings)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		internal override int IndexOfItem(JToken? item)
		{
			return 0;
		}

		public int System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIndexOf(JToken item)
		{
			return 0;
		}

		public void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EInsert(int index, JToken item)
		{
		}

		public void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemoveAt(int index)
		{
		}

		public IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
		{
			return null;
		}

		public void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(JToken item)
		{
		}

		public void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EClear()
		{
		}

		public bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContains(JToken item)
		{
			return false;
		}

		public void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECopyTo(JToken[] array, int arrayIndex)
		{
		}

		public bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemove(JToken item)
		{
			return false;
		}
	}
}
