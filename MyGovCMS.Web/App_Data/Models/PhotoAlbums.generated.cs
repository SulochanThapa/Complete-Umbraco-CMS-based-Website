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
	// Mixin Content Type with alias "photoAlbums"
	/// <summary>Photo Albums</summary>
	public partial interface IPhotoAlbums : IPublishedContent
	{
		/// <summary>Album Cover</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		global::Umbraco.Core.Models.PublishedContent.IPublishedContent AlbumCover { get; }

		/// <summary>Album Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		string AlbumDescription { get; }

		/// <summary>Album Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		string AlbumTitle { get; }

		/// <summary>Photos Folder</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		global::Umbraco.Core.Models.PublishedContent.IPublishedContent PhotosFolder { get; }
	}

	/// <summary>Photo Albums</summary>
	[PublishedModel("photoAlbums")]
	public partial class PhotoAlbums : PublishedContentModel, IPhotoAlbums
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const string ModelTypeAlias = "photoAlbums";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PhotoAlbums, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public PhotoAlbums(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Album Cover
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("albumCover")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent AlbumCover => GetAlbumCover(this);

		/// <summary>Static getter for Album Cover</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static global::Umbraco.Core.Models.PublishedContent.IPublishedContent GetAlbumCover(IPhotoAlbums that) => that.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("albumCover");

		///<summary>
		/// Album Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("albumDescription")]
		public string AlbumDescription => GetAlbumDescription(this);

		/// <summary>Static getter for Album Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static string GetAlbumDescription(IPhotoAlbums that) => that.Value<string>("albumDescription");

		///<summary>
		/// Album Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("albumTitle")]
		public string AlbumTitle => GetAlbumTitle(this);

		/// <summary>Static getter for Album Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static string GetAlbumTitle(IPhotoAlbums that) => that.Value<string>("albumTitle");

		///<summary>
		/// Photos Folder: Select the folder with the photos
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("photosFolder")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent PhotosFolder => GetPhotosFolder(this);

		/// <summary>Static getter for Photos Folder</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static global::Umbraco.Core.Models.PublishedContent.IPublishedContent GetPhotosFolder(IPhotoAlbums that) => that.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("photosFolder");
	}
}
