using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	public class HttpHeaderData : IEnumerable
	{
		[SerializeField]
		private List<HttpHeader> httpHeaders;

		public HttpHeader this[int index] => default(HttpHeader);

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Add(string name, string value)
		{
		}

		public bool IsModified()
		{
			return false;
		}

		public string ToValidatedString()
		{
			return null;
		}
	}
}
