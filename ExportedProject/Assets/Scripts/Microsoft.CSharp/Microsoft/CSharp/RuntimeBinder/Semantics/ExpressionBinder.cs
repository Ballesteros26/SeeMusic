using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder.Errors;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal readonly struct ExpressionBinder
	{
		private sealed class BinOpArgInfo
		{
			public Expr arg1;

			public Expr arg2;

			public PredefinedType pt1;

			public PredefinedType pt2;

			public PredefinedType ptRaw1;

			public PredefinedType ptRaw2;

			public CType type1;

			public CType type2;

			public CType typeRaw1;

			public CType typeRaw2;

			public BinOpKind binopKind;

			public BinOpMask mask;

			public BinOpArgInfo(Expr op1, Expr op2)
			{
			}

			public bool ValidForDelegate()
			{
				return false;
			}

			public bool ValidForEnumAndUnderlyingType()
			{
				return false;
			}

			public bool ValidForUnderlyingTypeAndEnum()
			{
				return false;
			}

			public bool ValidForEnum()
			{
				return false;
			}
		}

		private class BinOpSig
		{
			public PredefinedType pt1;

			public PredefinedType pt2;

			public BinOpMask mask;

			public int cbosSkip;

			public PfnBindBinOp pfn;

			public OpSigFlags grfos;

			public BinOpFuncKind fnkind;

			protected BinOpSig()
			{
			}

			public BinOpSig(PredefinedType pt1, PredefinedType pt2, BinOpMask mask, int cbosSkip, PfnBindBinOp pfn, OpSigFlags grfos, BinOpFuncKind fnkind)
			{
			}

			public bool ConvertOperandsBeforeBinding()
			{
				return false;
			}

			public bool CanLift()
			{
				return false;
			}

			public bool AutoLift()
			{
				return false;
			}
		}

		private sealed class BinOpFullSig : BinOpSig
		{
			private readonly LiftFlags _grflt;

			private readonly CType _type1;

			private readonly CType _type2;

			public BinOpFullSig(CType type1, CType type2, PfnBindBinOp pfn, OpSigFlags grfos, LiftFlags grflt, BinOpFuncKind fnkind)
			{
			}

			public BinOpFullSig(ExpressionBinder fnc, BinOpSig bos)
			{
			}

			public bool FPreDef()
			{
				return false;
			}

			public bool isLifted()
			{
				return false;
			}

			public bool ConvertFirst()
			{
				return false;
			}

			public bool ConvertSecond()
			{
				return false;
			}

			public CType Type1()
			{
				return null;
			}

			public CType Type2()
			{
				return null;
			}
		}

		private delegate bool ConversionFunc(Expr pSourceExpr, CType pSourceType, CType pDestinationType, bool needsExprDest, out Expr ppDestinationExpr, CONVERTTYPE flags);

		private sealed class ExplicitConversion
		{
			private readonly ExpressionBinder _binder;

			private Expr _exprSrc;

			private readonly CType _typeSrc;

			private readonly CType _typeDest;

			private Expr _exprDest;

			private readonly bool _needsExprDest;

			private readonly CONVERTTYPE _flags;

			public Expr ExprDest => null;

			public ExplicitConversion(ExpressionBinder binder, Expr exprSrc, CType typeSrc, CType typeDest, bool needsExprDest, CONVERTTYPE flags)
			{
			}

			public bool Bind()
			{
				return false;
			}

			private bool bindExplicitConversionFromNub()
			{
				return false;
			}

			private bool bindExplicitConversionFromArrayToIList()
			{
				return false;
			}

			private bool bindExplicitConversionFromIListToArray(ArrayType arrayDest)
			{
				return false;
			}

			private bool bindExplicitConversionFromArrayToArray(ArrayType arraySrc, ArrayType arrayDest)
			{
				return false;
			}

			private bool bindExplicitConversionToArray(ArrayType arrayDest)
			{
				return false;
			}

			private bool bindExplicitConversionToPointer()
			{
				return false;
			}

			private AggCastResult bindExplicitConversionFromEnumToAggregate(AggregateType aggTypeDest)
			{
				return default(AggCastResult);
			}

			private AggCastResult bindExplicitConversionFromDecimalToEnum(AggregateType aggTypeDest)
			{
				return default(AggCastResult);
			}

			private AggCastResult bindExplicitConversionFromEnumToDecimal(AggregateType aggTypeDest)
			{
				return default(AggCastResult);
			}

			private AggCastResult bindExplicitConversionToEnum(AggregateType aggTypeDest)
			{
				return default(AggCastResult);
			}

			private AggCastResult bindExplicitConversionBetweenSimpleTypes(AggregateType aggTypeDest)
			{
				return default(AggCastResult);
			}

			private AggCastResult bindExplicitConversionBetweenAggregates(AggregateType aggTypeDest)
			{
				return default(AggCastResult);
			}

			private AggCastResult bindExplicitConversionFromPointerToInt(AggregateType aggTypeDest)
			{
				return default(AggCastResult);
			}

			private AggCastResult bindExplicitConversionToAggregate(AggregateType aggTypeDest)
			{
				return default(AggCastResult);
			}
		}

		private delegate Expr PfnBindBinOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr op1, Expr op2);

		private delegate Expr PfnBindUnaOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr op);

		public enum NamedArgumentsKind
		{
			None = 0,
			Positioning = 1,
			NonTrailing = 2
		}

		internal sealed class GroupToArgsBinder
		{
			private enum Result
			{
				Success = 0,
				Failure_SearchForExpanded = 1,
				Failure_NoSearchForExpanded = 2
			}

			private readonly ExpressionBinder _pExprBinder;

			private bool _fCandidatesUnsupported;

			private readonly BindingFlag _fBindFlags;

			private readonly ExprMemberGroup _pGroup;

			private readonly ArgInfos _pArguments;

			private readonly ArgInfos _pOriginalArguments;

			private readonly NamedArgumentsKind _namedArgumentsKind;

			private AggregateType _pCurrentType;

			private MethodOrPropertySymbol _pCurrentSym;

			private TypeArray _pCurrentTypeArgs;

			private TypeArray _pCurrentParameters;

			private int _nArgBest;

			private readonly GroupToArgsBinderResult _results;

			private readonly List<CandidateFunctionMember> _methList;

			private readonly MethPropWithInst _mpwiParamTypeConstraints;

			private readonly MethPropWithInst _mpwiBogus;

			private readonly MethPropWithInst _misnamed;

			private readonly MethPropWithInst _mpwiCantInferInstArg;

			private readonly MethWithType _mwtBadArity;

			private Name _pInvalidSpecifiedName;

			private Name _pNameUsedInPositionalArgument;

			private Name _pDuplicateSpecifiedName;

			private readonly List<CType> _HiddenTypes;

			private bool _bArgumentsChangedForNamedOrOptionalArguments;

			public GroupToArgsBinder(ExpressionBinder exprBinder, BindingFlag bindFlags, ExprMemberGroup grp, ArgInfos args, ArgInfos originalArgs, NamedArgumentsKind namedArgumentsKind)
			{
			}

			public void Bind()
			{
			}

			public GroupToArgsBinderResult GetResultsOfBind()
			{
				return null;
			}

			private static CType GetTypeQualifier(ExprMemberGroup pGroup)
			{
				return null;
			}

			private void LookForCandidates()
			{
			}

			private static void CopyArgInfos(ArgInfos src, ArgInfos dst)
			{
			}

			private bool GetResultOfBind()
			{
				return false;
			}

			private bool ReOrderArgsForNamedArguments()
			{
				return false;
			}

			internal static bool ReOrderArgsForNamedArguments(MethodOrPropertySymbol methprop, TypeArray pCurrentParameters, AggregateType pCurrentType, ExprMemberGroup pGroup, ArgInfos pArguments)
			{
				return false;
			}

			private static Expr GenerateOptionalArgument(MethodOrPropertySymbol methprop, CType type, int index)
			{
				return null;
			}

			private static MethodOrPropertySymbol FindMostDerivedMethod(MethodOrPropertySymbol pMethProp, Expr pObject)
			{
				return null;
			}

			public static MethodOrPropertySymbol FindMostDerivedMethod(MethodOrPropertySymbol pMethProp, CType pType)
			{
				return null;
			}

			private bool HasOptionalParameters()
			{
				return false;
			}

			private bool AddArgumentsForOptionalParameters()
			{
				return false;
			}

			private static Expr FindArgumentWithName(ArgInfos pArguments, Name pName)
			{
				return null;
			}

			private bool NamedArgumentNamesAppearInParameterList(MethodOrPropertySymbol methprop)
			{
				return false;
			}

			private bool GetNextSym(CMemberLookupResults.CMethodIterator iterator)
			{
				return false;
			}

			private bool ConstructExpandedParameters()
			{
				return false;
			}

			private Result DetermineCurrentTypeArgs()
			{
				return default(Result);
			}

			private bool ArgumentsAreConvertible()
			{
				return false;
			}

			private void UpdateArguments()
			{
			}

			private static bool DoesTypeArgumentsContainErrorSym(CType var)
			{
				return false;
			}

			private void ReportErrorsOnSuccess()
			{
			}

			private RuntimeBinderException ReportErrorsOnFailure()
			{
				return null;
			}

			private RuntimeBinderException ReportErrorsForBestMatching(bool bUseDelegateErrors)
			{
				return null;
			}
		}

		internal sealed class GroupToArgsBinderResult
		{
			[CompilerGenerated]
			private MethPropWithInst _003CAmbiguousResult_003Ek__BackingField;

			public MethPropWithInst BestResult { get; set; }

			public MethPropWithInst AmbiguousResult
			{
				[CompilerGenerated]
				set
				{
					_003CAmbiguousResult_003Ek__BackingField = value;
				}
			}

			public MethPropWithInst InaccessibleResult { get; }

			public MethPropWithInst UninferableResult { get; }

			private static int NumberOfErrorTypes(TypeArray pTypeArgs)
			{
				return 0;
			}

			private static bool IsBetterThanCurrent(TypeArray pTypeArgs1, TypeArray pTypeArgs2)
			{
				return false;
			}

			public bool IsBetterUninferableResult(TypeArray pTypeArguments)
			{
				return false;
			}
		}

		private sealed class ImplicitConversion
		{
			private Expr _exprDest;

			private readonly ExpressionBinder _binder;

			private readonly Expr _exprSrc;

			private readonly CType _typeSrc;

			private readonly CType _typeDest;

			private readonly bool _needsExprDest;

			private CONVERTTYPE _flags;

			public Expr ExprDest => null;

			public ImplicitConversion(ExpressionBinder binder, Expr exprSrc, CType typeSrc, CType typeDest, bool needsExprDest, CONVERTTYPE flags)
			{
			}

			public bool Bind()
			{
				return false;
			}

			private bool BindNubConversion(NullableType nubDst)
			{
				return false;
			}

			private bool bindImplicitConversionFromNull()
			{
				return false;
			}

			private bool bindImplicitConversionFromNullable(NullableType nubSrc)
			{
				return false;
			}

			private bool bindImplicitConversionFromArray()
			{
				return false;
			}

			private bool bindImplicitConversionFromPointer()
			{
				return false;
			}

			private bool bindImplicitConversionFromAgg(AggregateType aggTypeSrc)
			{
				return false;
			}

			private bool bindImplicitConversionToBase(AggregateType pSource)
			{
				return false;
			}

			private bool bindImplicitConversionFromEnum(AggregateType aggTypeSrc)
			{
				return false;
			}

			private bool bindImplicitConversionToEnum(AggregateType aggTypeSrc)
			{
				return false;
			}

			private bool bindImplicitConversionBetweenSimpleTypes(AggregateType aggTypeSrc)
			{
				return false;
			}
		}

		private class UnaOpSig
		{
			public PredefinedType pt;

			public UnaOpMask grfuom;

			public int cuosSkip;

			public PfnBindUnaOp pfn;

			public UnaOpFuncKind fnkind;

			protected UnaOpSig()
			{
			}

			public UnaOpSig(PredefinedType pt, UnaOpMask grfuom, int cuosSkip, PfnBindUnaOp pfn, UnaOpFuncKind fnkind)
			{
			}
		}

		private sealed class UnaOpFullSig : UnaOpSig
		{
			private readonly LiftFlags _grflt;

			private readonly CType _type;

			public UnaOpFullSig(CType type, PfnBindUnaOp pfn, LiftFlags grflt, UnaOpFuncKind fnkind)
			{
			}

			public UnaOpFullSig(ExpressionBinder fnc, UnaOpSig uos)
			{
			}

			public bool FPreDef()
			{
				return false;
			}

			public bool isLifted()
			{
				return false;
			}

			public bool Convert()
			{
				return false;
			}

			public new CType GetType()
			{
				return null;
			}
		}

		private static readonly byte[][] s_betterConversionTable;

		private static readonly byte[][] s_simpleTypeConversions;

		private static readonly byte[][] s_simpleTypeBetter;

		private static readonly PredefinedType[] s_rgptIntOp;

		private static readonly PredefinedName[] s_EK2NAME;

		private static readonly BinOpSig[] s_binopSignatures;

		private static readonly UnaOpSig[] s_rguos;

		public BindingContext Context { get; }

		private AggregateSymbol ContextForMemberLookup => null;

		private static BetterType WhichMethodIsBetterTieBreaker(CandidateFunctionMember node1, CandidateFunctionMember node2, CType pTypeThrough, ArgInfos args)
		{
			return default(BetterType);
		}

		private static BetterType CompareTypes(TypeArray ta1, TypeArray ta2)
		{
			return default(BetterType);
		}

		private static int FindName(List<Name> names, Name name)
		{
			return 0;
		}

		private static TypeArray RearrangeNamedArguments(TypeArray pta, MethPropWithInst mpwi, CType pTypeThrough, ArgInfos args)
		{
			return null;
		}

		private BetterType WhichMethodIsBetter(CandidateFunctionMember node1, CandidateFunctionMember node2, CType pTypeThrough, ArgInfos args)
		{
			return default(BetterType);
		}

		private BetterType WhichConversionIsBetter(CType argType, CType p1, CType p2)
		{
			return default(BetterType);
		}

		private CandidateFunctionMember FindBestMethod(List<CandidateFunctionMember> list, CType pTypeThrough, ArgInfos args, out CandidateFunctionMember methAmbig1, out CandidateFunctionMember methAmbig2)
		{
			methAmbig1 = null;
			methAmbig2 = null;
			return null;
		}

		private static void RoundToFloat(double d, out float f)
		{
			f = default(float);
		}

		private static long I64(long x)
		{
			return 0L;
		}

		private static long I64(ulong x)
		{
			return 0L;
		}

		private static ConvKind GetConvKind(PredefinedType ptSrc, PredefinedType ptDst)
		{
			return default(ConvKind);
		}

		private static bool isUserDefinedConversion(PredefinedType ptSrc, PredefinedType ptDst)
		{
			return false;
		}

		private BetterType WhichSimpleConversionIsBetter(PredefinedType pt1, PredefinedType pt2)
		{
			return default(BetterType);
		}

		private BetterType WhichTypeIsBetter(PredefinedType pt1, PredefinedType pt2, CType typeGiven)
		{
			return default(BetterType);
		}

		private BetterType WhichTypeIsBetter(CType type1, CType type2, CType typeGiven)
		{
			return default(BetterType);
		}

		private bool canConvert(CType src, CType dest, CONVERTTYPE flags)
		{
			return false;
		}

		public bool canConvert(CType src, CType dest)
		{
			return false;
		}

		private bool canConvert(Expr expr, CType dest)
		{
			return false;
		}

		private bool canConvert(Expr expr, CType dest, CONVERTTYPE flags)
		{
			return false;
		}

		private Expr mustConvertCore(Expr expr, CType destExpr)
		{
			return null;
		}

		private Expr mustConvertCore(Expr expr, CType dest, CONVERTTYPE flags)
		{
			return null;
		}

		public Expr tryConvert(Expr expr, CType dest)
		{
			return null;
		}

		private Expr tryConvert(Expr expr, CType dest, CONVERTTYPE flags)
		{
			return null;
		}

		public Expr mustConvert(Expr expr, CType dest)
		{
			return null;
		}

		private Expr mustConvert(Expr expr, CType dest, CONVERTTYPE flags)
		{
			return null;
		}

		private Expr mustCastCore(Expr expr, CType dest, CONVERTTYPE flags)
		{
			return null;
		}

		private static RuntimeBinderException CantConvert(Expr expr, CType dest)
		{
			return null;
		}

		public Expr mustCast(Expr expr, CType dest)
		{
			return null;
		}

		public Expr mustCast(Expr expr, CType dest, CONVERTTYPE flags)
		{
			return null;
		}

		private Expr MustCastInUncheckedContext(Expr expr, CType dest, CONVERTTYPE flags)
		{
			return null;
		}

		private bool canCast(CType src, CType dest, CONVERTTYPE flags)
		{
			return false;
		}

		private bool BindImplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, CONVERTTYPE flags)
		{
			return false;
		}

		private bool BindImplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, out Expr ppDestinationExpr, CONVERTTYPE flags)
		{
			ppDestinationExpr = null;
			return false;
		}

		private bool BindImplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, bool needsExprDest, out Expr ppDestinationExpr, CONVERTTYPE flags)
		{
			ppDestinationExpr = null;
			return false;
		}

		private bool BindExplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, bool needsExprDest, out Expr ppDestinationExpr, CONVERTTYPE flags)
		{
			ppDestinationExpr = null;
			return false;
		}

		private bool BindExplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, out Expr ppDestinationExpr, CONVERTTYPE flags)
		{
			ppDestinationExpr = null;
			return false;
		}

		private bool BindExplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, CONVERTTYPE flags)
		{
			return false;
		}

		private bool bindUserDefinedConversion(Expr exprSrc, CType typeSrc, CType typeDst, bool needExprDest, out Expr pexprDst, bool fImplicitOnly)
		{
			pexprDst = null;
			return false;
		}

		private static RuntimeBinderException HandleAmbiguity(CType typeSrc, CType typeDst, List<UdConvInfo> prguci, int iuciBestSrc, int iuciBestDst)
		{
			return null;
		}

		private static void MarkAsIntermediateConversion(Expr pExpr)
		{
		}

		private Expr BindUDConversionCore(Expr pFrom, CType pTypeFrom, CType pTypeTo, CType pTypeDestination, MethWithInst mwiBest)
		{
			return null;
		}

		private Expr BindUDConversionCore(Expr pFrom, CType pTypeFrom, CType pTypeTo, CType pTypeDestination, MethWithInst mwiBest, out Expr ppTransformedArgument)
		{
			ppTransformedArgument = null;
			return null;
		}

		private ConstCastResult bindConstantCast(Expr exprSrc, CType typeDest, bool needExprDest, out Expr pexprDest, bool explicitConversion)
		{
			pexprDest = null;
			return default(ConstCastResult);
		}

		private int CompareSrcTypesBased(CType type1, bool fImplicit1, CType type2, bool fImplicit2)
		{
			return 0;
		}

		private int CompareDstTypesBased(CType type1, bool fImplicit1, CType type2, bool fImplicit2)
		{
			return 0;
		}

		private static Expr BindDecimalConstCast(CType destType, CType srcType, ExprConstant src)
		{
			return null;
		}

		private bool CanExplicitConversionBeBoundInUncheckedContext(Expr exprSrc, CType typeSrc, CType typeDest, CONVERTTYPE flags)
		{
			return false;
		}

		public ExpressionBinder(BindingContext context)
		{
			Context = default(BindingContext);
		}

		private static AggregateType GetPredefindType(PredefinedType pt)
		{
			return null;
		}

		private Expr GenerateAssignmentConversion(Expr op1, Expr op2, bool allowExplicit)
		{
			return null;
		}

		public Expr BindAssignment(Expr op1, Expr op2, bool allowExplicit)
		{
			return null;
		}

		internal Expr BindArrayIndexCore(Expr pOp1, Expr pOp2)
		{
			return null;
		}

		private void bindSimpleCast(Expr exprSrc, CType typeDest, out Expr pexprDest)
		{
			pexprDest = null;
		}

		private void bindSimpleCast(Expr exprSrc, CType typeDest, out Expr pexprDest, EXPRFLAG exprFlags)
		{
			pexprDest = null;
		}

		private ExprCall BindToMethod(MethWithInst mwi, Expr pArguments, ExprMemberGroup pMemGroup, MemLookFlags flags)
		{
			return null;
		}

		internal Expr BindToField(Expr pOptionalObject, FieldWithType fwt, BindingFlag bindFlags)
		{
			return null;
		}

		internal ExprProperty BindToProperty(Expr pObject, PropWithType pwt, BindingFlag bindFlags, Expr args, ExprMemberGroup pMemGroup)
		{
			return null;
		}

		internal Expr bindUDUnop(ExpressionKind ek, Expr arg)
		{
			return null;
		}

		private ExprCall BindLiftedUDUnop(Expr arg, CType typeArg, MethPropWithInst mpwi)
		{
			return null;
		}

		private ExprCall BindUDUnopCall(Expr arg, CType typeArg, MethPropWithInst mpwi)
		{
			return null;
		}

		private GroupToArgsBinderResult BindMethodGroupToArgumentsCore(BindingFlag bindFlags, ExprMemberGroup grp, Expr args, int carg, NamedArgumentsKind namedArgumentsKind)
		{
			return null;
		}

		internal ExprWithArgs BindMethodGroupToArguments(BindingFlag bindFlags, ExprMemberGroup grp, Expr args)
		{
			return null;
		}

		private static NamedArgumentsKind FindNamedArgumentsType(Expr args)
		{
			return default(NamedArgumentsKind);
		}

		private static RuntimeBinderException BadOperatorTypesError(Expr pOperand1, Expr pOperand2)
		{
			return null;
		}

		private static ErrorCode GetStandardLvalueError(CheckLvalueKind kind)
		{
			return default(ErrorCode);
		}

		private void CheckLvalueProp(ExprProperty prop)
		{
		}

		private void CheckPropertyAccess(MethWithType mwt, PropWithType pwtSlot, CType type)
		{
		}

		private void CheckLvalue(Expr expr, CheckLvalueKind kind)
		{
		}

		private static void PostBindMethod(MethWithInst pMWI)
		{
		}

		private static void PostBindProperty(PropWithType pwt, out MethWithType pmwtGet, out MethWithType pmwtSet)
		{
			pmwtGet = null;
			pmwtSet = null;
		}

		private Expr AdjustMemberObject(SymWithType swt, Expr pObject)
		{
			return null;
		}

		private static bool IsMatchingStatic(SymWithType swt, Expr pObject)
		{
			return false;
		}

		private void verifyMethodArgs(ExprWithArgs call, CType callingObjectType)
		{
		}

		private void AdjustCallArgumentsForParams(CType callingObjectType, CType type, MethodOrPropertySymbol mp, TypeArray pTypeArgs, Expr argsPtr, out Expr newArgs)
		{
			newArgs = null;
		}

		internal CType ChooseArrayIndexType(Expr args)
		{
			return null;
		}

		internal static void FillInArgInfoFromArgList(ArgInfos argInfo, Expr args)
		{
		}

		private static bool TryGetExpandedParams(TypeArray @params, int count, out TypeArray ppExpandedParams)
		{
			ppExpandedParams = null;
			return false;
		}

		public static bool IsMethPropCallable(MethodOrPropertySymbol sym, bool requireUC)
		{
			return false;
		}

		private static bool IsConvInTable(List<UdConvInfo> convTable, MethodSymbol meth, AggregateType ats, bool fSrc, bool fDst)
		{
			return false;
		}

		private static bool isConstantInRange(ExprConstant exprSrc, CType typeDest)
		{
			return false;
		}

		private static bool isConstantInRange(ExprConstant exprSrc, CType typeDest, bool realsOk)
		{
			return false;
		}

		private static Name ExpressionKindName(ExpressionKind ek)
		{
			return null;
		}

		private static void CheckUnsafe(CType type)
		{
		}

		private static ExprWrap WrapShortLivedExpression(Expr expr)
		{
			return null;
		}

		private static ExprAssignment GenerateOptimizedAssignment(Expr op1, Expr op2)
		{
			return null;
		}

		internal static int CountArguments(Expr args)
		{
			return 0;
		}

		private static bool IsNullableConstructor(Expr expr, out ExprCall call)
		{
			call = null;
			return false;
		}

		private static Expr StripNullableConstructor(Expr pExpr)
		{
			return null;
		}

		private static Expr BindNubValue(Expr exprSrc)
		{
			return null;
		}

		private static ExprCall BindNubNew(Expr exprSrc)
		{
			return null;
		}

		private ExprBinOp BindUserDefinedBinOp(ExpressionKind ek, BinOpArgInfo info)
		{
			return null;
		}

		private bool GetSpecialBinopSignatures(List<BinOpFullSig> prgbofs, BinOpArgInfo info)
		{
			return false;
		}

		private bool GetStandardAndLiftedBinopSignatures(List<BinOpFullSig> rgbofs, BinOpArgInfo info)
		{
			return false;
		}

		private int FindBestSignatureInList(List<BinOpFullSig> binopSignatures, BinOpArgInfo info)
		{
			return 0;
		}

		private static ExprBinOp BindNullEqualityComparison(ExpressionKind ek, BinOpArgInfo info)
		{
			return null;
		}

		public Expr BindStandardBinop(ExpressionKind ek, Expr arg1, Expr arg2)
		{
			return null;
		}

		private Expr BindStandardBinopCore(BinOpArgInfo info, BinOpFullSig bofs, ExpressionKind ek, EXPRFLAG flags)
		{
			return null;
		}

		private ExprBinOp BindLiftedStandardBinOp(BinOpArgInfo info, BinOpFullSig bofs, ExpressionKind ek, EXPRFLAG flags)
		{
			return null;
		}

		private void LiftArgument(Expr pArgument, CType pParameterType, bool bConvertBeforeLift, out Expr ppLiftedArgument, out Expr ppNonLiftedArgument)
		{
			ppLiftedArgument = null;
			ppNonLiftedArgument = null;
		}

		private bool GetDelBinOpSigs(List<BinOpFullSig> prgbofs, BinOpArgInfo info)
		{
			return false;
		}

		private bool CanConvertArg1(BinOpArgInfo info, CType typeDst, out LiftFlags pgrflt, out CType ptypeSig1, out CType ptypeSig2)
		{
			pgrflt = default(LiftFlags);
			ptypeSig1 = null;
			ptypeSig2 = null;
			return false;
		}

		private bool CanConvertArg2(BinOpArgInfo info, CType typeDst, out LiftFlags pgrflt, out CType ptypeSig1, out CType ptypeSig2)
		{
			pgrflt = default(LiftFlags);
			ptypeSig1 = null;
			ptypeSig2 = null;
			return false;
		}

		private static void RecordBinOpSigFromArgs(List<BinOpFullSig> prgbofs, BinOpArgInfo info)
		{
		}

		private bool GetEnumBinOpSigs(List<BinOpFullSig> prgbofs, BinOpArgInfo info)
		{
			return false;
		}

		private static bool IsEnumArithmeticBinOp(ExpressionKind ek, BinOpArgInfo info)
		{
			return false;
		}

		private bool GetRefEqualSigs(List<BinOpFullSig> prgbofs, BinOpArgInfo info)
		{
			return false;
		}

		private int WhichBofsIsBetter(BinOpFullSig bofs1, BinOpFullSig bofs2, CType type1, CType type2)
		{
			return 0;
		}

		private static (ExpressionKind, UnaOpKind, EXPRFLAG) CalculateExprAndUnaryOpKinds(OperatorKind op, bool bChecked)
		{
			return default((ExpressionKind, UnaOpKind, EXPRFLAG));
		}

		public Expr BindStandardUnaryOperator(OperatorKind op, Expr pArgument)
		{
			return null;
		}

		private UnaryOperatorSignatureFindResult PopulateSignatureList(Expr pArgument, UnaOpKind unaryOpKind, UnaOpMask unaryOpMask, ExpressionKind exprKind, EXPRFLAG flags, List<UnaOpFullSig> pSignatures, out Expr ppResult)
		{
			ppResult = null;
			return default(UnaryOperatorSignatureFindResult);
		}

		private bool FindApplicableSignatures(Expr pArgument, UnaOpMask unaryOpMask, List<UnaOpFullSig> pSignatures)
		{
			return false;
		}

		private ExprOperator BindLiftedStandardUnop(ExpressionKind ek, EXPRFLAG flags, Expr arg, UnaOpFullSig uofs)
		{
			return null;
		}

		private int WhichUofsIsBetter(UnaOpFullSig uofs1, UnaOpFullSig uofs2, CType typeArg)
		{
			return 0;
		}

		private static ExprOperator BindIntBinOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static ExprOperator BindIntUnaOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg)
		{
			return null;
		}

		private static ExprOperator BindRealBinOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG _, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static ExprOperator BindRealUnaOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG _, Expr arg)
		{
			return null;
		}

		private Expr BindIncOp(ExpressionKind ek, EXPRFLAG flags, Expr arg, UnaOpFullSig uofs)
		{
			return null;
		}

		private Expr BindIncOpCore(ExpressionKind ek, EXPRFLAG flags, Expr exprVal, CType type)
		{
			return null;
		}

		private Expr LScalar(ExpressionKind ek, EXPRFLAG flags, Expr exprVal, CType type, ConstVal cv, CType typeTmp)
		{
			return null;
		}

		private ExprMulti BindNonliftedIncOp(ExpressionKind ek, EXPRFLAG flags, Expr arg, UnaOpFullSig uofs)
		{
			return null;
		}

		private ExprMulti BindLiftedIncOp(ExpressionKind ek, EXPRFLAG flags, Expr arg, UnaOpFullSig uofs)
		{
			return null;
		}

		private static ExprBinOp BindDecBinOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static ExprUnaryOp BindDecUnaOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg)
		{
			return null;
		}

		private static Expr BindStrBinOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static ExprBinOp BindShiftOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static ExprBinOp BindBoolBinOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private ExprOperator BindBoolBitwiseOp(ExpressionKind ek, EXPRFLAG flags, Expr expr1, Expr expr2)
		{
			return null;
		}

		private static Expr BindLiftedBoolBitwiseOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr expr1, Expr expr2)
		{
			return null;
		}

		private static Expr BindBoolUnaOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg)
		{
			return null;
		}

		private static ExprBinOp BindStrCmpOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static ExprBinOp BindRefCmpOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static Expr BindDelBinOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static Expr BindEnumBinOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private Expr BindLiftedEnumArithmeticBinOp(ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static Expr BindEnumUnaOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg)
		{
			return null;
		}

		private (BinOpKind, EXPRFLAG) GetBinopKindAndFlags(ExpressionKind ek)
		{
			return default((BinOpKind, EXPRFLAG));
		}

		private ExprOperator BindIntOp(ExpressionKind kind, EXPRFLAG flags, Expr op1, Expr op2, PredefinedType ptOp)
		{
			return null;
		}

		private ExprOperator BindIntegerNeg(EXPRFLAG flags, Expr op, PredefinedType ptOp)
		{
			return null;
		}

		private static ExprOperator BindFloatOp(ExpressionKind kind, Expr op1, Expr op2)
		{
			return null;
		}

		private static ExprConcat BindStringConcat(Expr op1, Expr op2)
		{
			return null;
		}

		private static RuntimeBinderException AmbiguousOperatorError(Expr op1, Expr op2)
		{
			return null;
		}

		private Expr BindUserBoolOp(ExpressionKind kind, ExprCall pCall)
		{
			return null;
		}

		private static AggregateType GetUserDefinedBinopArgumentType(CType type)
		{
			return null;
		}

		private static int GetUserDefinedBinopArgumentTypes(CType type1, CType type2, AggregateType[] rgats)
		{
			return 0;
		}

		private static bool UserDefinedBinaryOperatorCanBeLifted(ExpressionKind ek, MethodSymbol method, AggregateType ats, TypeArray Params)
		{
			return false;
		}

		private bool UserDefinedBinaryOperatorIsApplicable(List<CandidateFunctionMember> candidateList, ExpressionKind ek, MethodSymbol method, AggregateType ats, Expr arg1, Expr arg2, bool fDontLift)
		{
			return false;
		}

		private bool GetApplicableUserDefinedBinaryOperatorCandidates(List<CandidateFunctionMember> candidateList, ExpressionKind ek, AggregateType type, Expr arg1, Expr arg2, bool fDontLift)
		{
			return false;
		}

		private AggregateType GetApplicableUserDefinedBinaryOperatorCandidatesInBaseTypes(List<CandidateFunctionMember> candidateList, ExpressionKind ek, AggregateType type, Expr arg1, Expr arg2, bool fDontLift, AggregateType atsStop)
		{
			return null;
		}

		private ExprCall BindUDBinop(ExpressionKind ek, Expr arg1, Expr arg2, bool fDontLift, out MethPropWithInst ppmpwi)
		{
			ppmpwi = null;
			return null;
		}

		private ExprCall BindUDBinopCall(Expr arg1, Expr arg2, TypeArray Params, CType typeRet, MethPropWithInst mpwi)
		{
			return null;
		}

		private ExprCall BindLiftedUDBinop(ExpressionKind ek, Expr arg1, Expr arg2, TypeArray Params, MethPropWithInst mpwi)
		{
			return null;
		}

		private static AggregateType GetEnumBinOpType(ExpressionKind ek, CType argType1, CType argType2, out AggregateType ppEnumType)
		{
			ppEnumType = null;
			return null;
		}

		private static ExprBinOp CreateBinopForPredefMethodCall(ExpressionKind ek, PREDEFMETH predefMeth, CType RetType, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static ExprUnaryOp CreateUnaryOpForPredefMethodCall(ExpressionKind ek, PREDEFMETH predefMeth, CType pRetType, Expr pArg)
		{
			return null;
		}
	}
}
