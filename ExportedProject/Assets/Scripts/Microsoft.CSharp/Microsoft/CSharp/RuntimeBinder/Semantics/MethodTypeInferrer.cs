using System;
using System.Collections.Generic;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class MethodTypeInferrer
	{
		private enum NewInferenceResult
		{
			InferenceFailed = 0,
			MadeProgress = 1,
			NoProgress = 2,
			Success = 3
		}

		[Flags]
		private enum Dependency
		{
			Unknown = 0,
			NotDependent = 1,
			DependsMask = 0x10,
			Indirect = 0x12
		}

		private readonly ExpressionBinder _binder;

		private readonly TypeArray _pMethodTypeParameters;

		private readonly TypeArray _pMethodFormalParameterTypes;

		private readonly ArgInfos _pMethodArguments;

		private readonly List<CType>[] _pExactBounds;

		private readonly List<CType>[] _pUpperBounds;

		private readonly List<CType>[] _pLowerBounds;

		private readonly CType[] _pFixedResults;

		private Dependency[][] _ppDependencies;

		private bool _dependenciesDirty;

		public static bool Infer(ExpressionBinder binder, MethodSymbol pMethod, TypeArray pMethodFormalParameterTypes, ArgInfos pMethodArguments, out TypeArray ppInferredTypeArguments)
		{
			ppInferredTypeArguments = null;
			return false;
		}

		private MethodTypeInferrer(ExpressionBinder exprBinder, TypeArray pMethodFormalParameterTypes, ArgInfos pMethodArguments, TypeArray pMethodTypeParameters)
		{
		}

		private TypeArray GetResults()
		{
			return null;
		}

		private bool IsUnfixed(int iParam)
		{
			return false;
		}

		private bool IsUnfixed(TypeParameterType pParam)
		{
			return false;
		}

		private bool AllFixed()
		{
			return false;
		}

		private void AddLowerBound(TypeParameterType pParam, CType pBound)
		{
		}

		private void AddUpperBound(TypeParameterType pParam, CType pBound)
		{
		}

		private void AddExactBound(TypeParameterType pParam, CType pBound)
		{
		}

		private bool HasBound(int iParam)
		{
			return false;
		}

		private bool InferTypeArgs()
		{
			return false;
		}

		private static bool IsReallyAType(CType pType)
		{
			return false;
		}

		private void InferTypeArgsFirstPhase()
		{
		}

		private bool InferTypeArgsSecondPhase()
		{
			return false;
		}

		private NewInferenceResult DoSecondPhase()
		{
			return default(NewInferenceResult);
		}

		private NewInferenceResult FixNondependentParameters()
		{
			return default(NewInferenceResult);
		}

		private NewInferenceResult FixDependentParameters()
		{
			return default(NewInferenceResult);
		}

		private void InitializeDependencies()
		{
		}

		private bool DependsOn(int iParam, int jParam)
		{
			return false;
		}

		private bool DependsTransitivelyOn(int iParam, int jParam)
		{
			return false;
		}

		private void DeduceAllDependencies()
		{
		}

		private bool DeduceDependencies()
		{
			return false;
		}

		private void SetUnknownsToNotDependent()
		{
		}

		private void SetIndirectsToUnknown()
		{
		}

		private void UpdateDependenciesAfterFix(int iParam)
		{
		}

		private bool DependsOnAny(int iParam)
		{
			return false;
		}

		private bool AnyDependsOn(int iParam)
		{
			return false;
		}

		private void ExactInference(CType pSource, CType pDest)
		{
		}

		private bool ExactTypeParameterInference(CType pSource, CType pDest)
		{
			return false;
		}

		private bool ExactArrayInference(CType pSource, CType pDest)
		{
			return false;
		}

		private bool ExactNullableInference(CType pSource, CType pDest)
		{
			return false;
		}

		private bool ExactConstructedInference(CType pSource, CType pDest)
		{
			return false;
		}

		private void ExactTypeArgumentInference(AggregateType pSource, AggregateType pDest)
		{
		}

		private void LowerBoundInference(CType pSource, CType pDest)
		{
		}

		private bool LowerBoundTypeParameterInference(CType pSource, CType pDest)
		{
			return false;
		}

		private bool LowerBoundArrayInference(CType pSource, CType pDest)
		{
			return false;
		}

		private bool LowerBoundConstructedInference(CType pSource, CType pDest)
		{
			return false;
		}

		private bool LowerBoundClassInference(CType pSource, AggregateType pDest)
		{
			return false;
		}

		private bool LowerBoundInterfaceInference(CType pSource, AggregateType pDest)
		{
			return false;
		}

		private void LowerBoundTypeArgumentInference(AggregateType pSource, AggregateType pDest)
		{
		}

		private void UpperBoundInference(CType pSource, CType pDest)
		{
		}

		private bool UpperBoundTypeParameterInference(CType pSource, CType pDest)
		{
			return false;
		}

		private bool UpperBoundArrayInference(CType pSource, CType pDest)
		{
			return false;
		}

		private bool UpperBoundConstructedInference(CType pSource, CType pDest)
		{
			return false;
		}

		private bool UpperBoundClassInference(AggregateType pSource, CType pDest)
		{
			return false;
		}

		private bool UpperBoundInterfaceInference(AggregateType pSource, CType pDest)
		{
			return false;
		}

		private void UpperBoundTypeArgumentInference(AggregateType pSource, AggregateType pDest)
		{
		}

		private bool Fix(int iParam)
		{
			return false;
		}
	}
}
