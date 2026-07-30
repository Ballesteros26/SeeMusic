using System.Collections.Generic;
using System.Reflection;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class TypeManager
	{
		private sealed class StdTypeVarColl
		{
			private readonly List<TypeParameterType> prgptvs;

			public TypeParameterType GetTypeVarSym(int iv, bool fMeth)
			{
				return null;
			}
		}

		private static readonly Dictionary<(Assembly, Assembly), bool> s_internalsVisibleToCache;

		private static readonly StdTypeVarColl s_stvcMethod;

		public static ArrayType GetArray(CType elementType, int args, bool isSZArray)
		{
			return null;
		}

		public static AggregateType GetAggregate(AggregateSymbol agg, AggregateType atsOuter, TypeArray typeArgs)
		{
			return null;
		}

		public static AggregateType GetAggregate(AggregateSymbol agg, TypeArray typeArgsAll)
		{
			return null;
		}

		public static PointerType GetPointer(CType baseType)
		{
			return null;
		}

		public static NullableType GetNullable(CType pUnderlyingType)
		{
			return null;
		}

		public static ParameterModifierType GetParameterModifier(CType paramType, bool isOut)
		{
			return null;
		}

		public static AggregateSymbol GetNullable()
		{
			return null;
		}

		private static CType SubstType(CType typeSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth, bool denormMeth)
		{
			return null;
		}

		public static AggregateType SubstType(AggregateType typeSrc, TypeArray typeArgsCls)
		{
			return null;
		}

		private static CType SubstType(CType typeSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth)
		{
			return null;
		}

		public static TypeArray SubstTypeArray(TypeArray taSrc, SubstContext ctx)
		{
			return null;
		}

		public static TypeArray SubstTypeArray(TypeArray taSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth)
		{
			return null;
		}

		public static TypeArray SubstTypeArray(TypeArray taSrc, TypeArray typeArgsCls)
		{
			return null;
		}

		private static AggregateType SubstTypeCore(AggregateType type, SubstContext ctx)
		{
			return null;
		}

		private static CType SubstTypeCore(CType type, SubstContext pctx)
		{
			return null;
		}

		public static bool SubstEqualTypes(CType typeDst, CType typeSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth, bool denormMeth)
		{
			return false;
		}

		public static bool SubstEqualTypeArrays(TypeArray taDst, TypeArray taSrc, TypeArray typeArgsCls, TypeArray typeArgsMeth)
		{
			return false;
		}

		private static bool SubstEqualTypesCore(CType typeDst, CType typeSrc, SubstContext pctx)
		{
			return false;
		}

		public static bool TypeContainsType(CType type, CType typeFind)
		{
			return false;
		}

		public static bool TypeContainsTyVars(CType type, TypeArray typeVars)
		{
			return false;
		}

		public static AggregateSymbol GetPredefAgg(PredefinedType pt)
		{
			return null;
		}

		public static AggregateType SubstType(AggregateType typeSrc, SubstContext ctx)
		{
			return null;
		}

		public static CType SubstType(CType typeSrc, SubstContext pctx)
		{
			return null;
		}

		public static CType SubstType(CType typeSrc, AggregateType atsCls)
		{
			return null;
		}

		public static CType SubstType(CType typeSrc, AggregateType atsCls, TypeArray typeArgsMeth)
		{
			return null;
		}

		public static CType SubstType(CType typeSrc, CType typeCls, TypeArray typeArgsMeth)
		{
			return null;
		}

		public static TypeArray SubstTypeArray(TypeArray taSrc, AggregateType atsCls, TypeArray typeArgsMeth)
		{
			return null;
		}

		public static TypeArray SubstTypeArray(TypeArray taSrc, AggregateType atsCls)
		{
			return null;
		}

		private static bool SubstEqualTypes(CType typeDst, CType typeSrc, CType typeCls, TypeArray typeArgsMeth)
		{
			return false;
		}

		public static bool SubstEqualTypes(CType typeDst, CType typeSrc, CType typeCls)
		{
			return false;
		}

		public static TypeParameterType GetStdMethTypeVar(int iv)
		{
			return null;
		}

		public static TypeParameterType GetTypeParameter(TypeParameterSymbol pSymbol)
		{
			return null;
		}

		internal static CType GetBestAccessibleType(AggregateSymbol context, CType typeSrc)
		{
			return null;
		}

		private static bool TryVarianceAdjustmentToGetAccessibleType(AggregateSymbol context, AggregateType typeSrc, out CType typeDst)
		{
			typeDst = null;
			return false;
		}

		private static bool TryArrayVarianceAdjustmentToGetAccessibleType(AggregateSymbol context, ArrayType typeSrc, out CType typeDst)
		{
			typeDst = null;
			return false;
		}

		internal static bool InternalsVisibleTo(Assembly assemblyThatDefinesAttribute, Assembly assemblyToCheck)
		{
			return false;
		}
	}
}
