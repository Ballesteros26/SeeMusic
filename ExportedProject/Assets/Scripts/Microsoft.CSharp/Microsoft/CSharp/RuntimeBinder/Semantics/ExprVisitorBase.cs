namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal abstract class ExprVisitorBase
	{
		protected Expr Visit(Expr pExpr)
		{
			return null;
		}

		protected virtual Expr Dispatch(Expr pExpr)
		{
			return null;
		}

		private void VisitChildren(Expr pExpr)
		{
		}

		protected virtual Expr VisitEXPR(Expr pExpr)
		{
			return null;
		}

		protected virtual Expr VisitBINOP(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitLIST(ExprList pExpr)
		{
			return null;
		}

		protected virtual Expr VisitASSIGNMENT(ExprAssignment pExpr)
		{
			return null;
		}

		protected virtual Expr VisitARRAYINDEX(ExprArrayIndex pExpr)
		{
			return null;
		}

		protected virtual Expr VisitUNARYOP(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitUSERLOGOP(ExprUserLogicalOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitTYPEOF(ExprTypeOf pExpr)
		{
			return null;
		}

		protected virtual Expr VisitCAST(ExprCast pExpr)
		{
			return null;
		}

		protected virtual Expr VisitUSERDEFINEDCONVERSION(ExprUserDefinedConversion pExpr)
		{
			return null;
		}

		protected virtual Expr VisitZEROINIT(ExprZeroInit pExpr)
		{
			return null;
		}

		protected virtual Expr VisitMEMGRP(ExprMemberGroup pExpr)
		{
			return null;
		}

		protected virtual Expr VisitCALL(ExprCall pExpr)
		{
			return null;
		}

		protected virtual Expr VisitPROP(ExprProperty pExpr)
		{
			return null;
		}

		protected virtual Expr VisitFIELD(ExprField pExpr)
		{
			return null;
		}

		protected virtual Expr VisitLOCAL(ExprLocal pExpr)
		{
			return null;
		}

		protected virtual Expr VisitCONSTANT(ExprConstant pExpr)
		{
			return null;
		}

		protected virtual Expr VisitMULTIGET(ExprMultiGet pExpr)
		{
			return null;
		}

		protected virtual Expr VisitMULTI(ExprMulti pExpr)
		{
			return null;
		}

		protected virtual Expr VisitWRAP(ExprWrap pExpr)
		{
			return null;
		}

		protected virtual Expr VisitCONCAT(ExprConcat pExpr)
		{
			return null;
		}

		protected virtual Expr VisitARRINIT(ExprArrayInit pExpr)
		{
			return null;
		}

		protected virtual Expr VisitFIELDINFO(ExprFieldInfo pExpr)
		{
			return null;
		}

		protected virtual Expr VisitMETHODINFO(ExprMethodInfo pExpr)
		{
			return null;
		}

		protected virtual Expr VisitEQUALS(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitCOMPARE(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitEQ(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitNE(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitLE(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitGE(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitADD(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitSUB(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitDIV(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitBITAND(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitBITOR(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitLSHIFT(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitLOGAND(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitSEQUENCE(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitSAVE(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitINDIR(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitSTRINGEQ(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitDELEGATEEQ(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitDELEGATEADD(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitLT(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitMUL(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitBITXOR(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitRSHIFT(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitLOGOR(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitSTRINGNE(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitDELEGATENE(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitGT(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitMOD(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitSWAP(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitDELEGATESUB(ExprBinOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitTRUE(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitINC(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitLOGNOT(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitNEG(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitBITNOT(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitADDR(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitDECIMALNEG(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitDECIMALDEC(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitFALSE(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitDEC(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitUPLUS(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected virtual Expr VisitDECIMALINC(ExprUnaryOp pExpr)
		{
			return null;
		}
	}
}
