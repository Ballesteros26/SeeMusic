using System;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal interface ICSharpBinder
	{
		bool IsBinderThatCanHaveRefReceiver { get; }

		BindingFlag BindingFlags { get; }

		string Name { get; }

		Type ReturnType { get; }

		CSharpArgumentInfo GetArgumentInfo(int index);

		void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments);

		Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals);
	}
}
