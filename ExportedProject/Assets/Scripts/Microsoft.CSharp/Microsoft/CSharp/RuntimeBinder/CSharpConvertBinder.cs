using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal sealed class CSharpConvertBinder : ConvertBinder, ICSharpBinder
	{
		private readonly RuntimeBinder _binder;

		[ExcludeFromCodeCoverage]
		public string Name => null;

		public BindingFlag BindingFlags => default(BindingFlag);

		public bool IsBinderThatCanHaveRefReceiver => false;

		private CSharpConversionKind ConversionKind { get; }

		public Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
		{
			return null;
		}

		public void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments)
		{
		}

		CSharpArgumentInfo ICSharpBinder.GetArgumentInfo(int index)
		{
			return null;
		}

		public CSharpConvertBinder(Type type, CSharpConversionKind conversionKind, bool isChecked, Type callingContext)
			: base(null, @explicit: false)
		{
		}

		public override DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
