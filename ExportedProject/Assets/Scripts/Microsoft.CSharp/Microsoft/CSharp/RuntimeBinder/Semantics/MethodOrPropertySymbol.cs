using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal abstract class MethodOrPropertySymbol : ParentSymbol
	{
		public uint modOptCount;

		public new bool isStatic;

		public bool isOverride;

		public bool isOperator;

		public bool isParamArray;

		public bool isHideByName;

		private bool[] _optionalParameterIndex;

		private bool[] _defaultParameterIndex;

		private ConstVal[] _defaultParameters;

		private CType[] _defaultParameterConstValTypes;

		private bool[] _marshalAsIndex;

		private UnmanagedType[] _marshalAsBuffer;

		public SymWithType swtSlot;

		public CType RetType;

		private TypeArray _Params;

		public List<Name> ParameterNames { get; private set; }

		public TypeArray Params
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MethodOrPropertySymbol()
		{
		}

		public bool IsParameterOptional(int index)
		{
			return false;
		}

		public void SetOptionalParameter(int index)
		{
		}

		public bool HasOptionalParameters()
		{
			return false;
		}

		public bool HasDefaultParameterValue(int index)
		{
			return false;
		}

		public void SetDefaultParameterValue(int index, CType type, ConstVal cv)
		{
		}

		public ConstVal GetDefaultParameterValue(int index)
		{
			return default(ConstVal);
		}

		public CType GetDefaultParameterValueConstValType(int index)
		{
			return null;
		}

		private bool IsMarshalAsParameter(int index)
		{
			return false;
		}

		public void SetMarshalAsParameter(int index, UnmanagedType umt)
		{
		}

		private UnmanagedType GetMarshalAsParameterValue(int index)
		{
			return default(UnmanagedType);
		}

		public bool MarshalAsObject(int index)
		{
			return false;
		}

		public AggregateSymbol getClass()
		{
			return null;
		}

		public bool IsExpImpl()
		{
			return false;
		}
	}
}
