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
	/// <summary>Annual Report List</summary>
	[PublishedModel("annualReportList")]
	public partial class AnnualReportList : PublishedContentModel, IHeaderControls, ISEocontrols, IVisibilityControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const string ModelTypeAlias = "annualReportList";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AnnualReportList, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public AnnualReportList(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Header Subtitle: Enter a subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("headerSubtitle")]
		public string HeaderSubtitle => global::Umbraco.Web.PublishedModels.HeaderControls.GetHeaderSubtitle(this);

		///<summary>
		/// Header Title: Enter the Title or Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("headerTitle")]
		public string HeaderTitle => global::Umbraco.Web.PublishedModels.HeaderControls.GetHeaderTitle(this);

		///<summary>
		/// Meta Description: Enter the Meta Description for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords: Enter the keywords for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("metaKeywords")]
		public global::System.Collections.Generic.IEnumerable<string> MetaKeywords => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaKeywords(this);

		///<summary>
		/// Meta Name: Enter the Meta Name for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("metaName")]
		public string MetaName => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaName(this);

		///<summary>
		/// Hide from XML Sitemap: Tick this if you want to hide this page from XML Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("hideFromXMLSitemap")]
		public bool HideFromXmlsitemap => global::Umbraco.Web.PublishedModels.VisibilityControls.GetHideFromXmlsitemap(this);

		///<summary>
		/// Umbraco Navi Hide: Tick this box if you want to hide this page from navigation or search results.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => global::Umbraco.Web.PublishedModels.VisibilityControls.GetUmbracoNaviHide(this);
	}
}
