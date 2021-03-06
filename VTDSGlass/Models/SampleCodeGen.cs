﻿#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;   
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.Configuration;
using Glass.Sitecore.Mapper.FieldTypes;
using Sitecore.Globalization;



namespace VTDSGlass
{

    public interface IGlassBase
    {

        [SitecoreId]
        Guid Id { get; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid Template_Id { get; }

    }

    public abstract class GlassBase : IGlassBase
    {

        [SitecoreId]
        public virtual Guid Id { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual Guid Template_Id { get; set; }
    }
}
namespace VTDSGlass
{
    /// <summary>
    /// ITemplate1 Interface
    /// <para></para>
    /// <para>Path: /sitecore/templates/Development/Template1</para>	
    /// <para>ID: 48345c0a-39cb-49e7-8772-26695ad1524a</para>	
    /// </summary>
    public interface ITemplate1 : IGlassBase
    {
        string Title { get; set; }
    }


    /// <summary>
    /// Template1
    /// <para></para>
    /// <para>Path: /sitecore/templates/Development/Template1</para>	
    /// <para>ID: 48345c0a-39cb-49e7-8772-26695ad1524a</para>	
    /// </summary>
    [SitecoreClass(TemplateId = "48345c0a-39cb-49e7-8772-26695ad1524a")]
    public partial class Template1 : GlassBase, ITemplate1
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
        [SitecoreField("Title")]
        public virtual string Title { get; set; }
    }

}
namespace VTDSGlass
{
    /// <summary>
    /// ITemplate2 Interface
    /// <para></para>
    /// <para>Path: /sitecore/templates/Development/Template2</para>	
    /// <para>ID: f58fd58d-cd61-4fb0-83c4-43312f06fcfc</para>	
    /// </summary>
    public interface ITemplate2 : IGlassBase
    {

    }


    /// <summary>
    /// Template2
    /// <para></para>
    /// <para>Path: /sitecore/templates/Development/Template2</para>	
    /// <para>ID: f58fd58d-cd61-4fb0-83c4-43312f06fcfc</para>	
    /// </summary>
    [SitecoreClass(TemplateId = "f58fd58d-cd61-4fb0-83c4-43312f06fcfc")]
    public partial class Template2 : GlassBase, ITemplate2
    {

    }

}
