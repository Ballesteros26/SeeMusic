using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.CSharp.RuntimeBinder.Semantics;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal static class SymbolTable
	{
		private readonly struct NameHashKey : IEquatable<NameHashKey>
		{
			internal Type Type { get; }

			internal string Name { get; }

			public NameHashKey(Type type, string name)
			{
				Type = null;
				Name = null;
			}

			public bool Equals(NameHashKey other)
			{
				return false;
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

		private static readonly HashSet<Type> s_typesWithConversionsLoaded;

		private static readonly HashSet<NameHashKey> s_namesLoadedForEachType;

		private static readonly Type s_Sentinel;

		private static Type s_EventRegistrationTokenType;

		private static Type s_WindowsRuntimeMarshal;

		private static Type s_EventRegistrationTokenTable;

		internal static Type EventRegistrationTokenType => null;

		internal static Type WindowsRuntimeMarshalType => null;

		private static Type EventRegistrationTokenTableType => null;

		internal static void PopulateSymbolTableWithName(string name, IEnumerable<Type> typeArguments, Type callingType)
		{
		}

		internal static SymWithType LookupMember(string name, Expr callingObject, ParentSymbol context, int arity, MemberLookup mem, bool allowSpecialNames, bool requireInvocable)
		{
			return null;
		}

		private static void AddParameterConversions(MethodBase method)
		{
		}

		private static void AddNamesOnType(NameHashKey key)
		{
		}

		private static void AddNamesInInheritanceHierarchy(string name, List<Type> inheritance)
		{
		}

		private static List<Type> CreateInheritanceHierarchyList(Type type)
		{
			return null;
		}

		private static Name GetName(string p)
		{
			return null;
		}

		private static Name GetName(Type type)
		{
			return null;
		}

		private static TypeArray GetMethodTypeParameters(MethodInfo method, MethodSymbol parent)
		{
			return null;
		}

		private static TypeArray GetAggregateTypeParameters(Type type, AggregateSymbol agg)
		{
			return null;
		}

		private static TypeParameterType LoadClassTypeParameter(AggregateSymbol parent, Type t)
		{
			return null;
		}

		private static bool AreTypeParametersEquivalent(Type t1, Type t2)
		{
			return false;
		}

		private static Type GetOriginalTypeParameterType(Type t)
		{
			return null;
		}

		private static TypeParameterType LoadMethodTypeParameter(MethodSymbol parent, Type t)
		{
			return null;
		}

		private static TypeParameterType AddTypeParameterToSymbolTable(AggregateSymbol agg, MethodSymbol meth, Type t, bool bIsAggregate)
		{
			return null;
		}

		private static CType LoadSymbolsFromType(Type type)
		{
			return null;
		}

		private static TypeParameterType ProcessMethodTypeParameter(MethodInfo methinfo, Type t, AggregateSymbol parent)
		{
			return null;
		}

		private static CType GetConstructedType(Type type, AggregateSymbol agg)
		{
			return null;
		}

		private static CType ProcessSpecialTypeInChain(NamespaceOrAggregateSymbol parent, Type t)
		{
			return null;
		}

		private static List<object> BuildDeclarationChain(Type callingType)
		{
			return null;
		}

		private static AggregateSymbol FindSymForType(Symbol sym, Type t)
		{
			return null;
		}

		private static NamespaceSymbol AddNamespaceToSymbolTable(NamespaceOrAggregateSymbol parent, string sz)
		{
			return null;
		}

		internal static CType[] GetCTypeArrayFromTypes(Type[] types)
		{
			return null;
		}

		internal static CType GetCTypeFromType(Type type)
		{
			return null;
		}

		private static AggregateSymbol AddAggregateToSymbolTable(NamespaceOrAggregateSymbol parent, Type type)
		{
			return null;
		}

		private static void SetInterfacesOnAggregate(AggregateSymbol aggregate, Type type)
		{
		}

		private static FieldSymbol AddFieldToSymbolTable(FieldInfo fieldInfo, AggregateSymbol aggregate)
		{
			return null;
		}

		private static Type GetTypeByName(ref Type cachedResult, string name)
		{
			return null;
		}

		private static void AddEventToSymbolTable(EventInfo eventInfo, AggregateSymbol aggregate, FieldSymbol addedField)
		{
		}

		internal static void AddPredefinedPropertyToSymbolTable(AggregateSymbol type, Name property)
		{
		}

		private static void AddPropertyToSymbolTable(PropertyInfo property, AggregateSymbol aggregate)
		{
		}

		internal static void AddPredefinedMethodToSymbolTable(AggregateSymbol type, Name methodName)
		{
		}

		private static MethodSymbol AddMethodToSymbolTable(MethodBase member, AggregateSymbol callingAggregate, MethodKindEnum kind)
		{
			return null;
		}

		private static void SetParameterDataForMethProp(MethodOrPropertySymbol methProp, ParameterInfo[] parameters)
		{
		}

		private static void SetParameterAttributes(MethodOrPropertySymbol methProp, ParameterInfo[] parameters, int i)
		{
		}

		private static MethodSymbol FindMatchingMethod(MemberInfo method, AggregateSymbol callingAggregate)
		{
			return null;
		}

		private static uint GetCountOfModOpts(ParameterInfo[] parameters)
		{
			return 0u;
		}

		private static TypeArray CreateParameterArray(MemberInfo associatedInfo, ParameterInfo[] parameters)
		{
			return null;
		}

		private static CType GetTypeOfParameter(ParameterInfo p, MemberInfo m)
		{
			return null;
		}

		private static bool DoesMethodHaveParameterArray(ParameterInfo[] parameters)
		{
			return false;
		}

		private static SymWithType GetSlotForOverride(MethodInfo method)
		{
			return null;
		}

		private static MethodSymbol FindMethodFromMemberInfo(MemberInfo baseMemberInfo)
		{
			return null;
		}

		internal static bool AggregateContainsMethod(AggregateSymbol agg, string szName, symbmask_t mask)
		{
			return false;
		}

		internal static void AddConversionsForType(Type type)
		{
		}

		private static void AddConversionsForOneType(Type type)
		{
		}

		private static bool IsOperator(MethodInfo method)
		{
			return false;
		}
	}
}
