#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudAwesome.Dataverse.Core.EarlyBoundEntities
{
	
	
	/// <summary>
	/// Assembly that contains one or more plug-in types.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("pluginassembly")]
	public partial class PluginAssembly : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the pluginassembly entity
		/// </summary>
		public partial class Fields
		{
			public const string AuthType = "authtype";
			public const string AuthTypeName = "authtypename";
			public const string ComponentState = "componentstate";
			public const string Content = "content";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyname";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyname";
			public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
			public const string Culture = "culture";
			public const string CustomizationLevel = "customizationlevel";
			public const string Description = "description";
			public const string IntroducedVersion = "introducedversion";
			public const string IsCustomizable = "iscustomizable";
			public const string IsHidden = "ishidden";
			public const string IsManaged = "ismanaged";
			public const string IsManagedName = "ismanagedname";
			public const string IsolationMode = "isolationmode";
			public const string IsolationModeName = "isolationmodename";
			public const string IsPasswordSet = "ispasswordset";
			public const string Major = "major";
			public const string ManagedIdentityId = "managedidentityid";
			public const string ManagedIdentityIdName = "managedidentityidname";
			public const string Minor = "minor";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyname";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
			public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string PackageId = "packageid";
			public const string PackageIdName = "packageidname";
			public const string Password = "password";
			public const string Path = "path";
			public const string PluginAssembly_PluginType = "PluginAssembly_PluginType";
			public const string PluginAssemblyId = "pluginassemblyid";
			public const string Id = "pluginassemblyid";
			public const string PluginAssemblyIdUnique = "pluginassemblyidunique";
			public const string PluginPackage_PluginAssembly = "pluginpackage_pluginassembly";
			public const string PublicKeyToken = "publickeytoken";
			public const string SolutionId = "solutionid";
			public const string SourceHash = "sourcehash";
			public const string SourceType = "sourcetype";
			public const string SourceTypeName = "sourcetypename";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string Url = "url";
			public const string Username = "username";
			public const string Version = "version";
			public const string VersionNumber = "versionnumber";
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public PluginAssembly(System.Guid id) : 
				base(EntityLogicalName, id)
		{
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public PluginAssembly(string keyName, object keyValue) : 
				base(EntityLogicalName, keyName, keyValue)
		{
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public PluginAssembly(Microsoft.Xrm.Sdk.KeyAttributeCollection keyAttributes) : 
				base(EntityLogicalName, keyAttributes)
		{
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PluginAssembly() : 
				base(EntityLogicalName)
		{
		}
		
		public const string PrimaryIdAttribute = "pluginassemblyid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntitySchemaName = "PluginAssembly";
		
		public const string EntityLogicalName = "pluginassembly";
		
		public const string EntityLogicalCollectionName = "pluginassemblies";
		
		public const string EntitySetName = "pluginassemblies";
		
		/// <summary>
		/// Specifies mode of authentication with web sources like WebApp
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("authtype")]
		public virtual PluginAssembly_AuthType? AuthType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PluginAssembly_AuthType?)(EntityOptionSetEnum.GetEnum(this, "authtype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("authtype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("authtypename")]
		public string AuthTypeName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("authtype"))
				{
					return this.FormattedValues["authtype"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["authtype"] = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual ComponentState? ComponentState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ComponentState?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("componentstate", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		/// <summary>
		/// Bytes of the assembly, in Base64 format.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
		public string Content
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("content");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("content", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("createdby", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyname")]
		public string CreatedByName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("createdby"))
				{
					return this.FormattedValues["createdby"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["createdby"] = value;
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in assembly was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("createdon", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the pluginassembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("createdonbehalfby", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyname")]
		public string CreatedOnBehalfByName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("createdonbehalfby"))
				{
					return this.FormattedValues["createdonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["createdonbehalfby"] = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyyominame")]
		public string CreatedOnBehalfByYomiName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("createdonbehalfby"))
				{
					return this.FormattedValues["createdonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["createdonbehalfby"] = value;
			}
		}
		
		/// <summary>
		/// Culture code for the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("culture")]
		public string Culture
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("culture");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("culture", value);
			}
		}
		
		/// <summary>
		/// Customization Level.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("customizationlevel", value);
			}
		}
		
		/// <summary>
		/// Description of the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("description", value);
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("introducedversion", value);
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("iscustomizable", value);
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component should be hidden.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishidden")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsHidden
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("ishidden", value);
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component is managed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("ismanaged", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanagedname")]
		public string IsManagedName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("ismanaged"))
				{
					return this.FormattedValues["ismanaged"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["ismanaged"] = value;
			}
		}
		
		/// <summary>
		/// Information about how the plugin assembly is to be isolated at execution time; None / Sandboxed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isolationmode")]
		public virtual PluginAssembly_IsolationMode? IsolationMode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PluginAssembly_IsolationMode?)(EntityOptionSetEnum.GetEnum(this, "isolationmode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("isolationmode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isolationmodename")]
		public string IsolationModeName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("isolationmode"))
				{
					return this.FormattedValues["isolationmode"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["isolationmode"] = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispasswordset")]
		public System.Nullable<bool> IsPasswordSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ispasswordset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("ispasswordset", value);
			}
		}
		
		/// <summary>
		/// Major of the assembly version.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("major")]
		public System.Nullable<int> Major
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("major");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("major", value);
			}
		}
		
		/// <summary>
		/// Unique identifier for managedidentity associated with pluginassembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managedidentityid")]
		public Microsoft.Xrm.Sdk.EntityReference ManagedIdentityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("managedidentityid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("managedidentityid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managedidentityidname")]
		public string ManagedIdentityIdName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("managedidentityid"))
				{
					return this.FormattedValues["managedidentityid"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["managedidentityid"] = value;
			}
		}
		
		/// <summary>
		/// Minor of the assembly version.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minor")]
		public System.Nullable<int> Minor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("minor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("minor", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("modifiedby", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyname")]
		public string ModifiedByName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("modifiedby"))
				{
					return this.FormattedValues["modifiedby"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["modifiedby"] = value;
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in assembly was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("modifiedon", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the pluginassembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("modifiedonbehalfby", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
		public string ModifiedOnBehalfByName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("modifiedonbehalfby"))
				{
					return this.FormattedValues["modifiedonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["modifiedonbehalfby"] = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
		public string ModifiedOnBehalfByYomiName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("modifiedonbehalfby"))
				{
					return this.FormattedValues["modifiedonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["modifiedonbehalfby"] = value;
			}
		}
		
		/// <summary>
		/// Name of the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("name", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the plug-in assembly is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("organizationid", value);
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("overwritetime", value);
			}
		}
		
		/// <summary>
		/// Unique identifier for Plugin Package associated with Plug-in Assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("packageid")]
		public Microsoft.Xrm.Sdk.EntityReference PackageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("packageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("packageid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("packageidname")]
		public string PackageIdName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("packageid"))
				{
					return this.FormattedValues["packageid"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["packageid"] = value;
			}
		}
		
		/// <summary>
		/// User Password
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("password")]
		public string Password
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("password");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("password", value);
			}
		}
		
		/// <summary>
		/// File name of the plug-in assembly. Used when the source type is set to 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("path")]
		public string Path
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("path");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("path", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
		public System.Nullable<System.Guid> PluginAssemblyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("pluginassemblyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("pluginassemblyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.PluginAssemblyId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyidunique")]
		public System.Nullable<System.Guid> PluginAssemblyIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("pluginassemblyidunique");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("pluginassemblyidunique", value);
			}
		}
		
		/// <summary>
		/// Public key token of the assembly. This value can be obtained from the assembly by using reflection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publickeytoken")]
		public string PublicKeyToken
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("publickeytoken");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("publickeytoken", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("solutionid", value);
			}
		}
		
		/// <summary>
		/// Hash of the source of the assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcehash")]
		public string SourceHash
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sourcehash");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("sourcehash", value);
			}
		}
		
		/// <summary>
		/// Location of the assembly, for example 0=database, 1=on-disk.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcetype")]
		public virtual PluginAssembly_SourceType? SourceType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PluginAssembly_SourceType?)(EntityOptionSetEnum.GetEnum(this, "sourcetype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("sourcetype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcetypename")]
		public string SourceTypeName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				if (this.FormattedValues.Contains("sourcetype"))
				{
					return this.FormattedValues["sourcetype"];
				}
				else
				{
					return default(string);
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.FormattedValues["sourcetype"] = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supportingsolutionid")]
		public System.Nullable<System.Guid> SupportingSolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("supportingsolutionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("supportingsolutionid", value);
			}
		}
		
		/// <summary>
		/// Web Url
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("url")]
		public string Url
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("url");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("url", value);
			}
		}
		
		/// <summary>
		/// User Name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("username")]
		public string Username
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("username");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("username", value);
			}
		}
		
		/// <summary>
		/// Version number of the assembly. The value can be obtained from the assembly through reflection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
		public string Version
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("version");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("version", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetAttributeValue("versionnumber", value);
			}
		}
		
		/// <summary>
		/// 1:N pluginassembly_plugintype
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pluginassembly_plugintype")]
		public System.Collections.Generic.IEnumerable<CloudAwesome.Dataverse.Core.EarlyBoundEntities.PluginType> PluginAssembly_PluginType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CloudAwesome.Dataverse.Core.EarlyBoundEntities.PluginType>("pluginassembly_plugintype", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetRelatedEntities<CloudAwesome.Dataverse.Core.EarlyBoundEntities.PluginType>("pluginassembly_plugintype", null, value);
			}
		}
		
		/// <summary>
		/// N:1 pluginpackage_pluginassembly
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("packageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pluginpackage_pluginassembly")]
		public CloudAwesome.Dataverse.Core.EarlyBoundEntities.PluginPackage PluginPackage_PluginAssembly
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CloudAwesome.Dataverse.Core.EarlyBoundEntities.PluginPackage>("pluginpackage_pluginassembly", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SetRelatedEntity<CloudAwesome.Dataverse.Core.EarlyBoundEntities.PluginPackage>("pluginpackage_pluginassembly", null, value);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PluginAssembly(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (value != null && name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["pluginassemblyid"] = base.Id;
                        break;
                    case "pluginassemblyid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}
#pragma warning restore CS1591
