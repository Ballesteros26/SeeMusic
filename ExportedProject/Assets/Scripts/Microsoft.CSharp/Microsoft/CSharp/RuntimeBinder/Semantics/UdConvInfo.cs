namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal readonly struct UdConvInfo
	{
		public readonly MethWithType Meth;

		public readonly bool SrcImplicit;

		public readonly bool DstImplicit;

		public UdConvInfo(MethWithType mwt, bool srcImplicit, bool dstImplicit)
		{
			Meth = null;
			SrcImplicit = false;
			DstImplicit = false;
		}
	}
}
