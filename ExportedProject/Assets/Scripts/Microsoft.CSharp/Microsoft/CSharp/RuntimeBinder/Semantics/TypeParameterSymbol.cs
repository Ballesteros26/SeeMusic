namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class TypeParameterSymbol : Symbol
	{
		private bool _bIsMethodTypeParameter;

		private SpecCons _constraints;

		private TypeParameterType _pTypeParameterType;

		private int _nIndexInOwnParameters;

		private int _nIndexInTotalParameters;

		private TypeArray _pBounds;

		public bool Covariant;

		public bool Contravariant;

		public bool Invariant => false;

		public void SetTypeParameterType(TypeParameterType pType)
		{
		}

		public TypeParameterType GetTypeParameterType()
		{
			return null;
		}

		public bool IsMethodTypeParameter()
		{
			return false;
		}

		public void SetIsMethodTypeParameter(bool b)
		{
		}

		public int GetIndexInOwnParameters()
		{
			return 0;
		}

		public void SetIndexInOwnParameters(int index)
		{
		}

		public int GetIndexInTotalParameters()
		{
			return 0;
		}

		public void SetIndexInTotalParameters(int index)
		{
		}

		public void SetBounds(TypeArray pBounds)
		{
		}

		public TypeArray GetBounds()
		{
			return null;
		}

		public void SetConstraints(SpecCons constraints)
		{
		}

		public bool IsValueType()
		{
			return false;
		}

		public bool IsReferenceType()
		{
			return false;
		}

		public bool IsNonNullableValueType()
		{
			return false;
		}

		public bool HasNewConstraint()
		{
			return false;
		}

		public bool HasRefConstraint()
		{
			return false;
		}

		public bool HasValConstraint()
		{
			return false;
		}
	}
}
