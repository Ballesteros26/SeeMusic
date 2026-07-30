using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NJsonSchema.References;
using Newtonsoft.Json.Serialization;

namespace NJsonSchema.Visitors
{
	public abstract class JsonReferenceVisitorBase
	{
		private readonly IContractResolver _contractResolver;

		protected JsonReferenceVisitorBase(IContractResolver contractResolver)
		{
		}

		public virtual void Visit(object obj)
		{
		}

		protected abstract IJsonReference VisitJsonReference(IJsonReference reference, string path, string typeNameHint);

		protected virtual void Visit(object obj, string path, string typeNameHint, ISet<object> checkedObjects, Action<object> replacer)
		{
		}

		private static void ReplaceOrDelete<T>(ObservableCollection<T> collection, int index, T obj)
		{
		}

		private static void ReplaceOrDelete(IList collection, int index, object obj)
		{
		}
	}
}
