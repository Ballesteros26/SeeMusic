using System;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		private MemberSerialization _memberSerialization;

		internal MissingMemberHandling? _missingMemberHandling;

		internal Required? _itemRequired;

		internal NullValueHandling? _itemNullValueHandling;

		public MemberSerialization MemberSerialization => default(MemberSerialization);
	}
}
