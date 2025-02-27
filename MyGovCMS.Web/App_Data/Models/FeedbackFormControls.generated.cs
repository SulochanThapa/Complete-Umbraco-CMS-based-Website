//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.11.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "feedbackFormControls"
	/// <summary>Feedback Form Controls</summary>
	public partial interface IFeedbackFormControls : IPublishedContent
	{
		/// <summary>Error Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		global::System.Web.IHtmlString ErrorMessage { get; }

		/// <summary>Success Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		global::System.Web.IHtmlString SuccessMessage { get; }
	}

	/// <summary>Feedback Form Controls</summary>
	[PublishedModel("feedbackFormControls")]
	public partial class FeedbackFormControls : PublishedContentModel, IFeedbackFormControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const string ModelTypeAlias = "feedbackFormControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FeedbackFormControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public FeedbackFormControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Error Message: Enter the message to show on error
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("errorMessage")]
		public global::System.Web.IHtmlString ErrorMessage => GetErrorMessage(this);

		/// <summary>Static getter for Error Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static global::System.Web.IHtmlString GetErrorMessage(IFeedbackFormControls that) => that.Value<global::System.Web.IHtmlString>("errorMessage");

		///<summary>
		/// Success Message: Enter the message on success
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("successMessage")]
		public global::System.Web.IHtmlString SuccessMessage => GetSuccessMessage(this);

		/// <summary>Static getter for Success Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static global::System.Web.IHtmlString GetSuccessMessage(IFeedbackFormControls that) => that.Value<global::System.Web.IHtmlString>("successMessage");
	}
}
