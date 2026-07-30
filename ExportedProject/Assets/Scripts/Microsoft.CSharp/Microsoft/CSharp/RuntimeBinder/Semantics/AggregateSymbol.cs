using System;
using System.Reflection;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal class AggregateSymbol : NamespaceOrAggregateSymbol
	{
		public Type AssociatedSystemType;

		public Assembly AssociatedAssembly;

		private AggregateType _atsInst;

		private AggregateType _pBaseClass;

		private AggregateType _pUnderlyingType;

		private TypeArray _ifaces;

		private TypeArray _ifacesAll;

		private TypeArray _typeVarsThis;

		private TypeArray _typeVarsAll;

		private MethodSymbol _pConvFirst;

		private AggKindEnum _aggKind;

		private bool _isPredefined;

		private PredefinedType _iPredef;

		private bool _isAbstract;

		private bool _isSealed;

		private bool _hasPubNoArgCtor;

		private bool _isSkipUDOps;

		private bool? _hasConversion;

		public AggregateSymbol GetBaseAgg()
		{
			return null;
		}

		public AggregateType getThisType()
		{
			return null;
		}

		public bool FindBaseAgg(AggregateSymbol agg)
		{
			return false;
		}

		public bool isNested()
		{
			return false;
		}

		public AggregateSymbol GetOuterAgg()
		{
			return null;
		}

		public bool isPredefAgg(PredefinedType pt)
		{
			return false;
		}

		public AggKindEnum AggKind()
		{
			return default(AggKindEnum);
		}

		public void SetAggKind(AggKindEnum aggKind)
		{
		}

		public bool IsClass()
		{
			return false;
		}

		public bool IsDelegate()
		{
			return false;
		}

		public bool IsInterface()
		{
			return false;
		}

		public bool IsStruct()
		{
			return false;
		}

		public bool IsEnum()
		{
			return false;
		}

		public bool IsValueType()
		{
			return false;
		}

		public bool IsRefType()
		{
			return false;
		}

		public bool IsStatic()
		{
			return false;
		}

		public bool IsAbstract()
		{
			return false;
		}

		public void SetAbstract(bool @abstract)
		{
		}

		public bool IsPredefined()
		{
			return false;
		}

		public void SetPredefined(bool predefined)
		{
		}

		public PredefinedType GetPredefType()
		{
			return default(PredefinedType);
		}

		public void SetPredefType(PredefinedType predef)
		{
		}

		public bool IsSealed()
		{
			return false;
		}

		public void SetSealed(bool @sealed)
		{
		}

		public bool HasConversion()
		{
			return false;
		}

		public void SetHasConversion()
		{
		}

		public bool HasPubNoArgCtor()
		{
			return false;
		}

		public void SetHasPubNoArgCtor(bool hasPubNoArgCtor)
		{
		}

		public bool IsSkipUDOps()
		{
			return false;
		}

		public void SetSkipUDOps(bool skipUDOps)
		{
		}

		public TypeArray GetTypeVars()
		{
			return null;
		}

		public void SetTypeVars(TypeArray typeVars)
		{
		}

		public TypeArray GetTypeVarsAll()
		{
			return null;
		}

		public AggregateType GetBaseClass()
		{
			return null;
		}

		public void SetBaseClass(AggregateType baseClass)
		{
		}

		public AggregateType GetUnderlyingType()
		{
			return null;
		}

		public void SetUnderlyingType(AggregateType underlyingType)
		{
		}

		public TypeArray GetIfaces()
		{
			return null;
		}

		public void SetIfaces(TypeArray ifaces)
		{
		}

		public TypeArray GetIfacesAll()
		{
			return null;
		}

		public void SetIfacesAll(TypeArray ifacesAll)
		{
		}

		public MethodSymbol GetFirstUDConversion()
		{
			return null;
		}

		public void SetFirstUDConversion(MethodSymbol conv)
		{
		}

		public bool InternalsVisibleTo(Assembly assembly)
		{
			return false;
		}
	}
}
