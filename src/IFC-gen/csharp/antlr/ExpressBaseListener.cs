//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Express.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Express {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IExpressListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class ExpressBaseListener : IExpressListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.schemaDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchemaDeclaration([NotNull] ExpressParser.SchemaDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.schemaDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchemaDeclaration([NotNull] ExpressParser.SchemaDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.typeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeDeclaration([NotNull] ExpressParser.TypeDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.typeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeDeclaration([NotNull] ExpressParser.TypeDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.typeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeName([NotNull] ExpressParser.TypeNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.typeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeName([NotNull] ExpressParser.TypeNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.valueType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValueType([NotNull] ExpressParser.ValueTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.valueType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValueType([NotNull] ExpressParser.ValueTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.collectionValueType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollectionValueType([NotNull] ExpressParser.CollectionValueTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.collectionValueType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollectionValueType([NotNull] ExpressParser.CollectionValueTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayDecl([NotNull] ExpressParser.ArrayDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayDecl([NotNull] ExpressParser.ArrayDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SetDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetDecl([NotNull] ExpressParser.SetDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SetDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetDecl([NotNull] ExpressParser.SetDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ListDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterListDecl([NotNull] ExpressParser.ListDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ListDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitListDecl([NotNull] ExpressParser.ListDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayOfArrayDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayOfArrayDecl([NotNull] ExpressParser.ArrayOfArrayDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayOfArrayDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayOfArrayDecl([NotNull] ExpressParser.ArrayOfArrayDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SetOfSetsDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetOfSetsDecl([NotNull] ExpressParser.SetOfSetsDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SetOfSetsDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetOfSetsDecl([NotNull] ExpressParser.SetOfSetsDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ListOfListsDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterListOfListsDecl([NotNull] ExpressParser.ListOfListsDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ListOfListsDecl</c>
	/// labeled alternative in <see cref="ExpressParser.collectionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitListOfListsDecl([NotNull] ExpressParser.ListOfListsDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.setParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetParameters([NotNull] ExpressParser.SetParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.setParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetParameters([NotNull] ExpressParser.SetParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.enumeration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumeration([NotNull] ExpressParser.EnumerationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.enumeration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumeration([NotNull] ExpressParser.EnumerationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect([NotNull] ExpressParser.SelectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect([NotNull] ExpressParser.SelectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.idList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdList([NotNull] ExpressParser.IdListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.idList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdList([NotNull] ExpressParser.IdListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.typeDeclarationBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeDeclarationBody([NotNull] ExpressParser.TypeDeclarationBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.typeDeclarationBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeDeclarationBody([NotNull] ExpressParser.TypeDeclarationBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.ruleDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRuleDeclaration([NotNull] ExpressParser.RuleDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.ruleDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRuleDeclaration([NotNull] ExpressParser.RuleDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRule([NotNull] ExpressParser.RuleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRule([NotNull] ExpressParser.RuleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] ExpressParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] ExpressParser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom([NotNull] ExpressParser.AtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom([NotNull] ExpressParser.AtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.boolExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolExpr([NotNull] ExpressParser.BoolExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.boolExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolExpr([NotNull] ExpressParser.BoolExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.funcCallExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFuncCallExpr([NotNull] ExpressParser.FuncCallExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.funcCallExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFuncCallExpr([NotNull] ExpressParser.FuncCallExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.funcParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFuncParameters([NotNull] ExpressParser.FuncParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.funcParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFuncParameters([NotNull] ExpressParser.FuncParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.queryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueryExpr([NotNull] ExpressParser.QueryExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.queryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueryExpr([NotNull] ExpressParser.QueryExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.mulDivExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDivExpr([NotNull] ExpressParser.MulDivExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.mulDivExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDivExpr([NotNull] ExpressParser.MulDivExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.addSubExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSubExpr([NotNull] ExpressParser.AddSubExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.addSubExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSubExpr([NotNull] ExpressParser.AddSubExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.entityDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEntityDeclaration([NotNull] ExpressParser.EntityDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.entityDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEntityDeclaration([NotNull] ExpressParser.EntityDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.entityDeclarationBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEntityDeclarationBody([NotNull] ExpressParser.EntityDeclarationBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.entityDeclarationBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEntityDeclarationBody([NotNull] ExpressParser.EntityDeclarationBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SupertypeDecl</c>
	/// labeled alternative in <see cref="ExpressParser.supertypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSupertypeDecl([NotNull] ExpressParser.SupertypeDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SupertypeDecl</c>
	/// labeled alternative in <see cref="ExpressParser.supertypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSupertypeDecl([NotNull] ExpressParser.SupertypeDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SupertypesDecl</c>
	/// labeled alternative in <see cref="ExpressParser.supertypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSupertypesDecl([NotNull] ExpressParser.SupertypesDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SupertypesDecl</c>
	/// labeled alternative in <see cref="ExpressParser.supertypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSupertypesDecl([NotNull] ExpressParser.SupertypesDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SubtypeDecl</c>
	/// labeled alternative in <see cref="ExpressParser.subtypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubtypeDecl([NotNull] ExpressParser.SubtypeDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SubtypeDecl</c>
	/// labeled alternative in <see cref="ExpressParser.subtypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubtypeDecl([NotNull] ExpressParser.SubtypeDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SubtypesDecl</c>
	/// labeled alternative in <see cref="ExpressParser.subtypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubtypesDecl([NotNull] ExpressParser.SubtypesDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SubtypesDecl</c>
	/// labeled alternative in <see cref="ExpressParser.subtypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubtypesDecl([NotNull] ExpressParser.SubtypesDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute([NotNull] ExpressParser.AttributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute([NotNull] ExpressParser.AttributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.optional"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptional([NotNull] ExpressParser.OptionalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.optional"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptional([NotNull] ExpressParser.OptionalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefinition([NotNull] ExpressParser.DefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefinition([NotNull] ExpressParser.DefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.oneOf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOneOf([NotNull] ExpressParser.OneOfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.oneOf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOneOf([NotNull] ExpressParser.OneOfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.inverseDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInverseDeclaration([NotNull] ExpressParser.InverseDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.inverseDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInverseDeclaration([NotNull] ExpressParser.InverseDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.inverseAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInverseAttribute([NotNull] ExpressParser.InverseAttributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.inverseAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInverseAttribute([NotNull] ExpressParser.InverseAttributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.deriveDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeriveDeclaration([NotNull] ExpressParser.DeriveDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.deriveDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeriveDeclaration([NotNull] ExpressParser.DeriveDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.uniqueDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUniqueDeclaration([NotNull] ExpressParser.UniqueDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.uniqueDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUniqueDeclaration([NotNull] ExpressParser.UniqueDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.uniqueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUniqueStatement([NotNull] ExpressParser.UniqueStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.uniqueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUniqueStatement([NotNull] ExpressParser.UniqueStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] ExpressParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] ExpressParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.functionDeclarationBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclarationBody([NotNull] ExpressParser.FunctionDeclarationBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.functionDeclarationBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclarationBody([NotNull] ExpressParser.FunctionDeclarationBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPath([NotNull] ExpressParser.PathContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPath([NotNull] ExpressParser.PathContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.propertyAccessor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPropertyAccessor([NotNull] ExpressParser.PropertyAccessorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.propertyAccessor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPropertyAccessor([NotNull] ExpressParser.PropertyAccessorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExpressParser.setAccessor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetAccessor([NotNull] ExpressParser.SetAccessorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExpressParser.setAccessor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetAccessor([NotNull] ExpressParser.SetAccessorContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Express
