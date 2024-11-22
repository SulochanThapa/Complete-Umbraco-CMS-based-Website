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
	// Mixin Content Type with alias "localeInfoControls"
	/// <summary>Locale Info Controls</summary>
	public partial interface ILocaleInfoControls : IPublishedContent
	{
		/// <summary>Alternative Mobile No</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		string AlternativeMobileNo { get; }

		/// <summary>Email</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		string Email { get; }

		/// <summary>Fax No</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		string FaxNo { get; }

		/// <summary>Secretary Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		string SecretaryName { get; }

		/// <summary>Secretary Phone No</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		string SecretaryPhoneNo { get; }
	}

	/// <summary>Locale Info Controls</summary>
	[PublishedModel("localeInfoControls")]
	public partial class LocaleInfoControls : PublishedContentModel, ILocaleInfoControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const string ModelTypeAlias = "localeInfoControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LocaleInfoControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public LocaleInfoControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Alternative Mobile No
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("alternativeMobileNo")]
		public string AlternativeMobileNo => GetAlternativeMobileNo(this);

		/// <summary>Static getter for Alternative Mobile No</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static string GetAlternativeMobileNo(ILocaleInfoControls that) => that.Value<string>("alternativeMobileNo");

		///<summary>
		/// Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("email")]
		public string Email => GetEmail(this);

		/// <summary>Static getter for Email</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static string GetEmail(ILocaleInfoControls that) => that.Value<string>("email");

		///<summary>
		/// Fax No
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("faxNo")]
		public string FaxNo => GetFaxNo(this);

		/// <summary>Static getter for Fax No</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static string GetFaxNo(ILocaleInfoControls that) => that.Value<string>("faxNo");

		///<summary>
		/// Secretary Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("secretaryName")]
		public string SecretaryName => GetSecretaryName(this);

		/// <summary>Static getter for Secretary Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static string GetSecretaryName(ILocaleInfoControls that) => that.Value<string>("secretaryName");

		///<summary>
		/// Secretary Phone No
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("secretaryPhoneNo")]
		public string SecretaryPhoneNo => GetSecretaryPhoneNo(this);

		/// <summary>Static getter for Secretary Phone No</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static string GetSecretaryPhoneNo(ILocaleInfoControls that) => that.Value<string>("secretaryPhoneNo");
	}
}
