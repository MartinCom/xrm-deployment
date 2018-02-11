using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System.ComponentModel;

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]
namespace Xrm.Deployment.Core
{

	/// <summary>
	/// Assembly that contains one or more plug-in types.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("pluginassembly")]
	public partial class PluginAssembly : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "pluginassembly";
			
            public const string ComponentState = "componentstate";
            public const string Content = "content";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string Culture = "culture";
            public const string CustomizationLevel = "customizationlevel";
            public const string Description = "description";
            public const string IntroducedVersion = "introducedversion";
            public const string IsHidden = "ishidden";
            public const string IsManaged = "ismanaged";
            public const string IsolationMode = "isolationmode";
            public const string Major = "major";
            public const string Minor = "minor";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string Name = "name";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string OverwriteTime = "overwritetime";
            public const string Path = "path";
            public const string PluginAssemblyId = "pluginassemblyid";
            public const string PluginAssemblyIdUnique = "pluginassemblyidunique";
            public const string PublicKeyToken = "publickeytoken";
            public const string SolutionId = "solutionid";
            public const string SourceHash = "sourcehash";
            public const string SourceType = "sourcetype";
            public const string SupportingSolutionId = "supportingsolutionid";
            public const string Version = "version";
            public const string VersionNumber = "versionnumber";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
            public enum ComponentState 
            {
                Published = 0,
                Unpublished = 1,
                Deleted = 2,
                DeletedUnpublished = 3,
            }		
            public enum IsManaged 
            {
                Managed = 1,
                Unmanaged = 0,
            }		
            public enum IsolationMode 
            {
                None = 1,
                Sandbox = 2,
            }		
            public enum SourceType 
            {
                Database = 0,
                Disk = 1,
                Normal = 2,
            }		
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public PluginAssembly() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "pluginassembly";
		
		public const int EntityTypeCode = 4605;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("pluginassemblyid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				PluginAssemblyId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Bytes of the assembly, in Base64 format.
		/// </summary>
		[AttributeLogicalNameAttribute("content")]
		public string Content
		{
			get
			{
				return GetAttributeValue<string>("content");
			}
			set
			{
				OnPropertyChanging("Content");
				SetAttributeValue("content", value);
				OnPropertyChanged("Content");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the plug-in assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in assembly was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the pluginassembly.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Culture code for the plug-in assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("culture")]
		public string Culture
		{
			get
			{
				return GetAttributeValue<string>("culture");
			}
			set
			{
				OnPropertyChanging("Culture");
				SetAttributeValue("culture", value);
				OnPropertyChanged("Culture");
			}
		}
		
		/// <summary>
		/// Customization Level.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Description of the plug-in assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return GetAttributeValue<string>("description");
			}
			set
			{
				OnPropertyChanging("Description");
				SetAttributeValue("description", value);
				OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		[AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			get
			{
				return GetAttributeValue<string>("introducedversion");
			}
			set
			{
				OnPropertyChanging("IntroducedVersion");
				SetAttributeValue("introducedversion", value);
				OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component should be hidden.
		/// </summary>
		[AttributeLogicalNameAttribute("ishidden")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsHidden
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden");
			}
			set
			{
				OnPropertyChanging("IsHidden");
				SetAttributeValue("ishidden", value);
				OnPropertyChanged("IsHidden");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component is managed.
		/// </summary>
		[AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Information about how the plugin assembly is to be isolated at execution time; None / Sandboxed.
		/// </summary>
		[AttributeLogicalNameAttribute("isolationmode")]
		public Microsoft.Xrm.Sdk.OptionSetValue IsolationMode
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("isolationmode");
			}
			set
			{
				OnPropertyChanging("IsolationMode");
				SetAttributeValue("isolationmode", value);
				OnPropertyChanged("IsolationMode");
			}
		}
		
		/// <summary>
		/// Major of the assembly version.
		/// </summary>
		[AttributeLogicalNameAttribute("major")]
		public System.Nullable<int> Major
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("major");
			}
		}
		
		/// <summary>
		/// Minor of the assembly version.
		/// </summary>
		[AttributeLogicalNameAttribute("minor")]
		public System.Nullable<int> Minor
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("minor");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the plug-in assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in assembly was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the pluginassembly.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the plug-in assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return GetAttributeValue<string>("name");
			}
			set
			{
				OnPropertyChanging("Name");
				SetAttributeValue("name", value);
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the plug-in assembly is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// File name of the plug-in assembly. Used when the source type is set to 1.
		/// </summary>
		[AttributeLogicalNameAttribute("path")]
		public string Path
		{
			get
			{
				return GetAttributeValue<string>("path");
			}
			set
			{
				OnPropertyChanging("Path");
				SetAttributeValue("path", value);
				OnPropertyChanged("Path");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("pluginassemblyid")]
		public System.Nullable<System.Guid> PluginAssemblyId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("pluginassemblyid");
			}
			set
			{
				OnPropertyChanging("PluginAssemblyId");
				SetAttributeValue("pluginassemblyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("PluginAssemblyId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("pluginassemblyidunique")]
		public System.Nullable<System.Guid> PluginAssemblyIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("pluginassemblyidunique");
			}
		}
		
		/// <summary>
		/// Public key token of the assembly. This value can be obtained from the assembly by using reflection.
		/// </summary>
		[AttributeLogicalNameAttribute("publickeytoken")]
		public string PublicKeyToken
		{
			get
			{
				return GetAttributeValue<string>("publickeytoken");
			}
			set
			{
				OnPropertyChanging("PublicKeyToken");
				SetAttributeValue("publickeytoken", value);
				OnPropertyChanged("PublicKeyToken");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Hash of the source of the assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("sourcehash")]
		public string SourceHash
		{
			get
			{
				return GetAttributeValue<string>("sourcehash");
			}
			set
			{
				OnPropertyChanging("SourceHash");
				SetAttributeValue("sourcehash", value);
				OnPropertyChanged("SourceHash");
			}
		}
		
		/// <summary>
		/// Location of the assembly, for example 0=database, 1=on-disk.
		/// </summary>
		[AttributeLogicalNameAttribute("sourcetype")]
		public Microsoft.Xrm.Sdk.OptionSetValue SourceType
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("sourcetype");
			}
			set
			{
				OnPropertyChanging("SourceType");
				SetAttributeValue("sourcetype", value);
				OnPropertyChanged("SourceType");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("supportingsolutionid")]
		public System.Nullable<System.Guid> SupportingSolutionId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("supportingsolutionid");
			}
		}
		
		/// <summary>
		/// Version number of the assembly. The value can be obtained from the assembly through reflection.
		/// </summary>
		[AttributeLogicalNameAttribute("version")]
		public string Version
		{
			get
			{
				return GetAttributeValue<string>("version");
			}
			set
			{
				OnPropertyChanging("Version");
				SetAttributeValue("version", value);
				OnPropertyChanged("Version");
			}
		}
		
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N pluginassembly_plugintype
		/// </summary>
		[RelationshipSchemaNameAttribute("pluginassembly_plugintype")]
		public IEnumerable<PluginType> pluginassembly_plugintype
		{
			get
			{
				return GetRelatedEntities<PluginType>("pluginassembly_plugintype", null);
			}
			set
			{
				OnPropertyChanging("pluginassembly_plugintype");
				SetRelatedEntities<PluginType>("pluginassembly_plugintype", null, value);
				OnPropertyChanged("pluginassembly_plugintype");
			}
		}
	}

	/// <summary>
	/// Type that inherits from the IPlugin interface and is contained within a plug-in assembly.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("plugintype")]
	public partial class PluginType : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "plugintype";
			
            public const string AssemblyName = "assemblyname";
            public const string ComponentState = "componentstate";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string Culture = "culture";
            public const string CustomizationLevel = "customizationlevel";
            public const string CustomWorkflowActivityInfo = "customworkflowactivityinfo";
            public const string Description = "description";
            public const string FriendlyName = "friendlyname";
            public const string IsManaged = "ismanaged";
            public const string IsWorkflowActivity = "isworkflowactivity";
            public const string Major = "major";
            public const string Minor = "minor";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string Name = "name";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string OverwriteTime = "overwritetime";
            public const string PluginAssemblyId = "pluginassemblyid";
            public const string PluginAssemblyIdName = "pluginassemblyidName";
            public const string PluginTypeId = "plugintypeid";
            public const string PluginTypeIdUnique = "plugintypeidunique";
            public const string PublicKeyToken = "publickeytoken";
            public const string SolutionId = "solutionid";
            public const string SupportingSolutionId = "supportingsolutionid";
            public const string TypeName = "typename";
            public const string Version = "version";
            public const string VersionNumber = "versionnumber";
            public const string WorkflowActivityGroupName = "workflowactivitygroupname";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
            public enum ComponentState 
            {
                Published = 0,
                Unpublished = 1,
                Deleted = 2,
                DeletedUnpublished = 3,
            }		
            public enum IsManaged 
            {
                Managed = 1,
                Unmanaged = 0,
            }		
            public enum IsWorkflowActivity 
            {
                Yes = 1,
                No = 0,
            }		
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public PluginType() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "plugintype";
		
		public const int EntityTypeCode = 4602;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("plugintypeid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				PluginTypeId = value;
			}
		}
		
		/// <summary>
		/// Full path name of the plug-in assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("assemblyname")]
		public string AssemblyName
		{
			get
			{
				return GetAttributeValue<string>("assemblyname");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in type was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the plugintype.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Culture code for the plug-in assembly.
		/// </summary>
		[AttributeLogicalNameAttribute("culture")]
		public string Culture
		{
			get
			{
				return GetAttributeValue<string>("culture");
			}
		}
		
		/// <summary>
		/// Customization level of the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Serialized Custom Activity Type information, including required arguments. For more information, see SandboxCustomActivityInfo.
		/// </summary>
		[AttributeLogicalNameAttribute("customworkflowactivityinfo")]
		public string CustomWorkflowActivityInfo
		{
			get
			{
				return GetAttributeValue<string>("customworkflowactivityinfo");
			}
		}
		
		/// <summary>
		/// Description of the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return GetAttributeValue<string>("description");
			}
			set
			{
				OnPropertyChanging("Description");
				SetAttributeValue("description", value);
				OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// User friendly name for the plug-in.
		/// </summary>
		[AttributeLogicalNameAttribute("friendlyname")]
		public string FriendlyName
		{
			get
			{
				return GetAttributeValue<string>("friendlyname");
			}
			set
			{
				OnPropertyChanging("FriendlyName");
				SetAttributeValue("friendlyname", value);
				OnPropertyChanged("FriendlyName");
			}
		}
		
		[AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Indicates if the plug-in is a custom activity for workflows.
		/// </summary>
		[AttributeLogicalNameAttribute("isworkflowactivity")]
		public System.Nullable<bool> IsWorkflowActivity
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("isworkflowactivity");
			}
		}
		
		/// <summary>
		/// Major of the version number of the assembly for the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("major")]
		public System.Nullable<int> Major
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("major");
			}
		}
		
		/// <summary>
		/// Minor of the version number of the assembly for the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("minor")]
		public System.Nullable<int> Minor
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("minor");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in type was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the plugintype.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return GetAttributeValue<string>("name");
			}
			set
			{
				OnPropertyChanging("Name");
				SetAttributeValue("name", value);
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the plug-in type is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in assembly that contains this plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("pluginassemblyid")]
		public Microsoft.Xrm.Sdk.EntityReference PluginAssemblyId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pluginassemblyid");
			}
			set
			{
				OnPropertyChanging("PluginAssemblyId");
				SetAttributeValue("pluginassemblyid", value);
				OnPropertyChanged("PluginAssemblyId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("plugintypeid")]
		public System.Nullable<System.Guid> PluginTypeId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("plugintypeid");
			}
			set
			{
				OnPropertyChanging("PluginTypeId");
				SetAttributeValue("plugintypeid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("PluginTypeId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("plugintypeidunique")]
		public System.Nullable<System.Guid> PluginTypeIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("plugintypeidunique");
			}
		}
		
		/// <summary>
		/// Public key token of the assembly for the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("publickeytoken")]
		public string PublicKeyToken
		{
			get
			{
				return GetAttributeValue<string>("publickeytoken");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("supportingsolutionid")]
		public System.Nullable<System.Guid> SupportingSolutionId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("supportingsolutionid");
			}
		}
		
		/// <summary>
		/// Fully qualified type name of the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("typename")]
		public string TypeName
		{
			get
			{
				return GetAttributeValue<string>("typename");
			}
			set
			{
				OnPropertyChanging("TypeName");
				SetAttributeValue("typename", value);
				OnPropertyChanged("TypeName");
			}
		}
		
		/// <summary>
		/// Version number of the assembly for the plug-in type.
		/// </summary>
		[AttributeLogicalNameAttribute("version")]
		public string Version
		{
			get
			{
				return GetAttributeValue<string>("version");
			}
		}
		
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Group name of workflow custom activity.
		/// </summary>
		[AttributeLogicalNameAttribute("workflowactivitygroupname")]
		public string WorkflowActivityGroupName
		{
			get
			{
				return GetAttributeValue<string>("workflowactivitygroupname");
			}
			set
			{
				OnPropertyChanging("WorkflowActivityGroupName");
				SetAttributeValue("workflowactivitygroupname", value);
				OnPropertyChanged("WorkflowActivityGroupName");
			}
		}
		
		/// <summary>
		/// 1:N plugintype_sdkmessageprocessingstep
		/// </summary>
		[RelationshipSchemaNameAttribute("plugintype_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> plugintype_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntities<SdkMessageProcessingStep>("plugintype_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("plugintype_sdkmessageprocessingstep");
				SetRelatedEntities<SdkMessageProcessingStep>("plugintype_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("plugintype_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// 1:N plugintypeid_sdkmessageprocessingstep
		/// </summary>
		[RelationshipSchemaNameAttribute("plugintypeid_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> plugintypeid_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntities<SdkMessageProcessingStep>("plugintypeid_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
				SetRelatedEntities<SdkMessageProcessingStep>("plugintypeid_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 pluginassembly_plugintype
		/// </summary>
		[AttributeLogicalNameAttribute("pluginassemblyid")]
		[RelationshipSchemaNameAttribute("pluginassembly_plugintype")]
		public PluginAssembly pluginassembly_plugintype
		{
			get
			{
				return GetRelatedEntity<PluginAssembly>("pluginassembly_plugintype", null);
			}
			set
			{
				OnPropertyChanging("pluginassembly_plugintype");
				SetRelatedEntity<PluginAssembly>("pluginassembly_plugintype", null, value);
				OnPropertyChanged("pluginassembly_plugintype");
			}
		}
	}

	/// <summary>
	/// Message that is supported by the SDK.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessage")]
	public partial class SdkMessage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessage";
			
            public const string AutoTransact = "autotransact";
            public const string Availability = "availability";
            public const string CategoryName = "categoryname";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string Expand = "expand";
            public const string IsActive = "isactive";
            public const string IsPrivate = "isprivate";
            public const string IsReadOnly = "isreadonly";
            public const string IsValidForExecuteAsync = "isvalidforexecuteasync";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string Name = "name";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string SdkMessageId = "sdkmessageid";
            public const string SdkMessageIdUnique = "sdkmessageidunique";
            public const string Template = "template";
            public const string ThrottleSettings = "throttlesettings";
            public const string VersionNumber = "versionnumber";
            public const string WorkflowSdkStepEnabled = "workflowsdkstepenabled";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
            public enum AutoTransact 
            {
                Yes = 1,
                No = 0,
            }		
            public enum Expand 
            {
                Yes = 1,
                No = 0,
            }		
            public enum IsActive 
            {
                Yes = 1,
                No = 0,
            }		
            public enum IsPrivate 
            {
                Yes = 1,
                No = 0,
            }		
            public enum IsReadOnly 
            {
                Yes = 1,
                No = 0,
            }		
            public enum IsValidForExecuteAsync 
            {
                Yes = 1,
                No = 0,
            }		
            public enum Template 
            {
                Yes = 1,
                No = 0,
            }		
            public enum WorkflowSdkStepEnabled 
            {
                Yes = 1,
                No = 0,
            }		
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessage() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessage";
		
		public const int EntityTypeCode = 4606;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessageid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessageId = value;
			}
		}
		
		/// <summary>
		/// Information about whether the SDK message is automatically transacted.
		/// </summary>
		[AttributeLogicalNameAttribute("autotransact")]
		public System.Nullable<bool> AutoTransact
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("autotransact");
			}
			set
			{
				OnPropertyChanging("AutoTransact");
				SetAttributeValue("autotransact", value);
				OnPropertyChanged("AutoTransact");
			}
		}
		
		/// <summary>
		/// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
		/// </summary>
		[AttributeLogicalNameAttribute("availability")]
		public System.Nullable<int> Availability
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("availability");
			}
			set
			{
				OnPropertyChanging("Availability");
				SetAttributeValue("availability", value);
				OnPropertyChanged("Availability");
			}
		}
		
		/// <summary>
		/// If this is a categorized method, this is the name, otherwise None.
		/// </summary>
		[AttributeLogicalNameAttribute("categoryname")]
		public string CategoryName
		{
			get
			{
				return GetAttributeValue<string>("categoryname");
			}
			set
			{
				OnPropertyChanging("CategoryName");
				SetAttributeValue("categoryname", value);
				OnPropertyChanged("CategoryName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessage.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message should have its requests expanded per primary entity defined in its filters.
		/// </summary>
		[AttributeLogicalNameAttribute("expand")]
		public System.Nullable<bool> Expand
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("expand");
			}
			set
			{
				OnPropertyChanging("Expand");
				SetAttributeValue("expand", value);
				OnPropertyChanged("Expand");
			}
		}
		
		/// <summary>
		/// Information about whether the SDK message is active.
		/// </summary>
		[AttributeLogicalNameAttribute("isactive")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("isactive");
			}
			set
			{
				OnPropertyChanging("IsActive");
				SetAttributeValue("isactive", value);
				OnPropertyChanged("IsActive");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message is private.
		/// </summary>
		[AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> IsPrivate
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
			set
			{
				OnPropertyChanging("IsPrivate");
				SetAttributeValue("isprivate", value);
				OnPropertyChanged("IsPrivate");
			}
		}
		
		/// <summary>
		/// Identifies whether an SDK message will be ReadOnly or Read Write. false - ReadWrite, true - ReadOnly .
		/// </summary>
		[AttributeLogicalNameAttribute("isreadonly")]
		public System.Nullable<bool> IsReadOnly
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("isreadonly");
			}
			set
			{
				OnPropertyChanging("IsReadOnly");
				SetAttributeValue("isreadonly", value);
				OnPropertyChanged("IsReadOnly");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("isvalidforexecuteasync")]
		public System.Nullable<bool> IsValidForExecuteAsync
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("isvalidforexecuteasync");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessage.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the SDK message.
		/// </summary>
		[AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return GetAttributeValue<string>("name");
			}
			set
			{
				OnPropertyChanging("Name");
				SetAttributeValue("name", value);
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message entity.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageid")]
		public System.Nullable<System.Guid> SdkMessageId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageid");
			}
			set
			{
				OnPropertyChanging("SdkMessageId");
				SetAttributeValue("sdkmessageid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessageId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageidunique")]
		public System.Nullable<System.Guid> SdkMessageIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageidunique");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message is a template.
		/// </summary>
		[AttributeLogicalNameAttribute("template")]
		public System.Nullable<bool> Template
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("template");
			}
			set
			{
				OnPropertyChanging("Template");
				SetAttributeValue("template", value);
				OnPropertyChanged("Template");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("throttlesettings")]
		public string ThrottleSettings
		{
			get
			{
				return GetAttributeValue<string>("throttlesettings");
			}
		}
		
		/// <summary>
		/// Number that identifies a specific revision of the SDK message. 
		/// </summary>
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Whether or not the SDK message can be called from a workflow.
		/// </summary>
		[AttributeLogicalNameAttribute("workflowsdkstepenabled")]
		public System.Nullable<bool> WorkflowSdkStepEnabled
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("workflowsdkstepenabled");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageid_sdkmessageprocessingstep
		/// </summary>
		[RelationshipSchemaNameAttribute("sdkmessageid_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> sdkmessageid_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
				SetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageid_sdkmessagefilter
		/// </summary>
		[RelationshipSchemaNameAttribute("sdkmessageid_sdkmessagefilter")]
		public IEnumerable<SdkMessageFilter> sdkmessageid_sdkmessagefilter
		{
			get
			{
				return GetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null);
			}
			set
			{
				OnPropertyChanging("sdkmessageid_sdkmessagefilter");
				SetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null, value);
				OnPropertyChanged("sdkmessageid_sdkmessagefilter");
			}
		}
		
		/// <summary>
		/// 1:N message_sdkmessagepair
		/// </summary>
		[RelationshipSchemaNameAttribute("message_sdkmessagepair")]
		public IEnumerable<SdkMessagePair> message_sdkmessagepair
		{
			get
			{
				return GetRelatedEntities<SdkMessagePair>("message_sdkmessagepair", null);
			}
			set
			{
				OnPropertyChanging("message_sdkmessagepair");
				SetRelatedEntities<SdkMessagePair>("message_sdkmessagepair", null, value);
				OnPropertyChanged("message_sdkmessagepair");
			}
		}
	}

	/// <summary>
	/// Filter that defines which SDK messages are valid for each type of entity.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessagefilter")]
	public partial class SdkMessageFilter : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessagefilter";
			
            public const string Availability = "availability";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string IsCustomProcessingStepAllowed = "iscustomprocessingstepallowed";
            public const string IsVisible = "isvisible";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string PrimaryObjectTypeCode = "primaryobjecttypecode";
            public const string SdkMessageFilterId = "sdkmessagefilterid";
            public const string SdkMessageFilterIdUnique = "sdkmessagefilteridunique";
            public const string SdkMessageId = "sdkmessageid";
            public const string SdkMessageIdName = "sdkmessageidName";
            public const string SecondaryObjectTypeCode = "secondaryobjecttypecode";
            public const string VersionNumber = "versionnumber";
            public const string WorkflowSdkStepEnabled = "workflowsdkstepenabled";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
            public enum IsCustomProcessingStepAllowed 
            {
                Yes = 1,
                No = 0,
            }		
            public enum IsVisible 
            {
                Yes = 1,
                No = 0,
            }		
            public enum WorkflowSdkStepEnabled 
            {
                Yes = 1,
                No = 0,
            }		
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageFilter() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessagefilter";
		
		public const int EntityTypeCode = 4607;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessagefilterid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessageFilterId = value;
			}
		}
		
		/// <summary>
		/// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
		/// </summary>
		[AttributeLogicalNameAttribute("availability")]
		public System.Nullable<int> Availability
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("availability");
			}
			set
			{
				OnPropertyChanging("Availability");
				SetAttributeValue("availability", value);
				OnPropertyChanged("Availability");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message filter.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message filter was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessagefilter.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message filter.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Indicates whether a custom SDK message processing step is allowed.
		/// </summary>
		[AttributeLogicalNameAttribute("iscustomprocessingstepallowed")]
		public System.Nullable<bool> IsCustomProcessingStepAllowed
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("iscustomprocessingstepallowed");
			}
			set
			{
				OnPropertyChanging("IsCustomProcessingStepAllowed");
				SetAttributeValue("iscustomprocessingstepallowed", value);
				OnPropertyChanged("IsCustomProcessingStepAllowed");
			}
		}
		
		/// <summary>
		/// Indicates whether the filter should be visible.
		/// </summary>
		[AttributeLogicalNameAttribute("isvisible")]
		public System.Nullable<bool> IsVisible
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("isvisible");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message filter.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message filter was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessagefilter.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message filter is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Type of entity with which the SDK message filter is primarily associated.
		/// </summary>
		[AttributeLogicalNameAttribute("primaryobjecttypecode")]
		public string PrimaryObjectTypeCode
		{
			get
			{
				return GetAttributeValue<string>("primaryobjecttypecode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message filter entity.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagefilterid")]
		public System.Nullable<System.Guid> SdkMessageFilterId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagefilterid");
			}
			set
			{
				OnPropertyChanging("SdkMessageFilterId");
				SetAttributeValue("sdkmessagefilterid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessageFilterId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message filter.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagefilteridunique")]
		public System.Nullable<System.Guid> SdkMessageFilterIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagefilteridunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the related SDK message.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
			}
			set
			{
				OnPropertyChanging("SdkMessageId");
				SetAttributeValue("sdkmessageid", value);
				OnPropertyChanged("SdkMessageId");
			}
		}
		
		/// <summary>
		/// Type of entity with which the SDK message filter is secondarily associated.
		/// </summary>
		[AttributeLogicalNameAttribute("secondaryobjecttypecode")]
		public string SecondaryObjectTypeCode
		{
			get
			{
				return GetAttributeValue<string>("secondaryobjecttypecode");
			}
		}
		
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Whether or not the SDK message can be called from a workflow.
		/// </summary>
		[AttributeLogicalNameAttribute("workflowsdkstepenabled")]
		public System.Nullable<bool> WorkflowSdkStepEnabled
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("workflowsdkstepenabled");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessagefilterid_sdkmessageprocessingstep
		/// </summary>
		[RelationshipSchemaNameAttribute("sdkmessagefilterid_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> sdkmessagefilterid_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntities<SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
				SetRelatedEntities<SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageid_sdkmessagefilter
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageid")]
		[RelationshipSchemaNameAttribute("sdkmessageid_sdkmessagefilter")]
		public SdkMessage sdkmessageid_sdkmessagefilter
		{
			get
			{
				return GetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessagefilter", null);
			}
			set
			{
				OnPropertyChanging("sdkmessageid_sdkmessagefilter");
				SetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessagefilter", null, value);
				OnPropertyChanged("sdkmessageid_sdkmessagefilter");
			}
		}
	}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessagepair")]
	public partial class SdkMessagePair : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessagepair";
			
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string Endpoint = "endpoint";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string Namespace = "namespace";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string SdkMessageBindingInformation = "sdkmessagebindinginformation";
            public const string SdkMessageId = "sdkmessageid";
            public const string SdkMessageIdName = "sdkmessageidName";
            public const string SdkMessagePairId = "sdkmessagepairid";
            public const string SdkMessagePairIdUnique = "sdkmessagepairidunique";
            public const string VersionNumber = "versionnumber";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessagePair() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessagepair";
		
		public const int EntityTypeCode = 4613;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessagepairid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessagePairId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message pair.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message pair was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessagepair.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message filter.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Endpoint that the message pair is associated with.
		/// </summary>
		[AttributeLogicalNameAttribute("endpoint")]
		public string Endpoint
		{
			get
			{
				return GetAttributeValue<string>("endpoint");
			}
			set
			{
				OnPropertyChanging("Endpoint");
				SetAttributeValue("endpoint", value);
				OnPropertyChanged("Endpoint");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message pair.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message pair was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessagepair.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Namespace that the message pair is associated with.
		/// </summary>
		[AttributeLogicalNameAttribute("namespace")]
		public string Namespace
		{
			get
			{
				return GetAttributeValue<string>("namespace");
			}
			set
			{
				OnPropertyChanging("Namespace");
				SetAttributeValue("namespace", value);
				OnPropertyChanged("Namespace");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message pair is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessagebindinginformation")]
		public string SdkMessageBindingInformation
		{
			get
			{
				return GetAttributeValue<string>("sdkmessagebindinginformation");
			}
			set
			{
				OnPropertyChanging("SdkMessageBindingInformation");
				SetAttributeValue("sdkmessagebindinginformation", value);
				OnPropertyChanged("SdkMessageBindingInformation");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message with which the SDK message pair is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message pair entity.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagepairid")]
		public System.Nullable<System.Guid> SdkMessagePairId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagepairid");
			}
			set
			{
				OnPropertyChanging("SdkMessagePairId");
				SetAttributeValue("sdkmessagepairid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessagePairId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message pair.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagepairidunique")]
		public System.Nullable<System.Guid> SdkMessagePairIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagepairidunique");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N messagepair_sdkmessagerequest
		/// </summary>
		[RelationshipSchemaNameAttribute("messagepair_sdkmessagerequest")]
		public IEnumerable<SdkMessageRequest> messagepair_sdkmessagerequest
		{
			get
			{
				return GetRelatedEntities<SdkMessageRequest>("messagepair_sdkmessagerequest", null);
			}
			set
			{
				OnPropertyChanging("messagepair_sdkmessagerequest");
				SetRelatedEntities<SdkMessageRequest>("messagepair_sdkmessagerequest", null, value);
				OnPropertyChanged("messagepair_sdkmessagerequest");
			}
		}
		
		/// <summary>
		/// N:1 message_sdkmessagepair
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageid")]
		[RelationshipSchemaNameAttribute("message_sdkmessagepair")]
		public SdkMessage message_sdkmessagepair
		{
			get
			{
				return GetRelatedEntity<SdkMessage>("message_sdkmessagepair", null);
			}
		}
	}

	[DataContractAttribute()]
	public enum SdkMessageProcessingStepState
	{
		
		[EnumMemberAttribute()]
		Enabled = 0,
		
		[EnumMemberAttribute()]
		Disabled = 1,
	}

	/// <summary>
	/// Stage in the execution pipeline that a plug-in is to execute.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessageprocessingstep")]
	public partial class SdkMessageProcessingStep : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessageprocessingstep";
			
            public const string AsyncAutoDelete = "asyncautodelete";
            public const string CanUseReadOnlyConnection = "canusereadonlyconnection";
            public const string ComponentState = "componentstate";
            public const string Configuration = "configuration";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string Description = "description";
            public const string EventHandler = "eventhandler";
            public const string EventHandlerName = "eventhandlerName";
            public const string EventHandlerType = "eventhandlerType";
            public const string FilteringAttributes = "filteringattributes";
            public const string ImpersonatingUserId = "impersonatinguserid";
            public const string ImpersonatingUserIdName = "impersonatinguseridName";
            public const string IntroducedVersion = "introducedversion";
            public const string InvocationSource = "invocationsource";
            public const string IsCustomizable = "iscustomizable";
            public const string IsHidden = "ishidden";
            public const string IsManaged = "ismanaged";
            public const string Mode = "mode";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string Name = "name";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string OverwriteTime = "overwritetime";
            public const string PluginTypeId = "plugintypeid";
            public const string PluginTypeIdName = "plugintypeidName";
            public const string Rank = "rank";
            public const string SdkMessageFilterId = "sdkmessagefilterid";
            public const string SdkMessageFilterIdName = "sdkmessagefilteridName";
            public const string SdkMessageId = "sdkmessageid";
            public const string SdkMessageIdName = "sdkmessageidName";
            public const string SdkMessageProcessingStepId = "sdkmessageprocessingstepid";
            public const string SdkMessageProcessingStepIdUnique = "sdkmessageprocessingstepidunique";
            public const string SdkMessageProcessingStepSecureConfigId = "sdkmessageprocessingstepsecureconfigid";
            public const string SdkMessageProcessingStepSecureConfigIdName = "sdkmessageprocessingstepsecureconfigidName";
            public const string SolutionId = "solutionid";
            public const string Stage = "stage";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string SupportedDeployment = "supporteddeployment";
            public const string SupportingSolutionId = "supportingsolutionid";
            public const string VersionNumber = "versionnumber";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
            public enum AsyncAutoDelete 
            {
                Yes = 1,
                No = 0,
            }		
            public enum CanUseReadOnlyConnection 
            {
                Yes = 1,
                No = 0,
            }		
            public enum ComponentState 
            {
                Published = 0,
                Unpublished = 1,
                Deleted = 2,
                DeletedUnpublished = 3,
            }		
            public enum InvocationSource 
            {
                Internal = -1,
                Parent = 0,
                Child = 1,
            }		
            public enum IsManaged 
            {
                Managed = 1,
                Unmanaged = 0,
            }		
            public enum Mode 
            {
                Synchronous = 0,
                Asynchronous = 1,
            }		
            public enum Stage 
            {
                InitialPreoperationForinternaluseonly = 5,
                Prevalidation = 10,
                InternalPreoperationBeforeExternalPluginsForinternaluseonly = 15,
                Preoperation = 20,
                InternalPreoperationAfterExternalPluginsForinternaluseonly = 25,
                MainOperationForinternaluseonly = 30,
                InternalPostoperationBeforeExternalPluginsForinternaluseonly = 35,
                Postoperation = 40,
                InternalPostoperationAfterExternalPluginsForinternaluseonly = 45,
                PostoperationDeprecated = 50,
                FinalPostoperationForinternaluseonly = 55,
            }		
            public enum StateCode 
            {
                Enabled = 0,
                Disabled = 1,
            }		
            public enum StatusCode 
            {
                Enabled = 1,
                Disabled = 2,
            }		
            public enum SupportedDeployment 
            {
                ServerOnly = 0,
                MicrosoftDynamicsCRMClientforOutlookOnly = 1,
                Both = 2,
            }		
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageProcessingStep() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageprocessingstep";
		
		public const int EntityTypeCode = 4608;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessageProcessingStepId = value;
			}
		}
		
		/// <summary>
		/// Indicates whether the asynchronous system job is automatically deleted on completion.
		/// </summary>
		[AttributeLogicalNameAttribute("asyncautodelete")]
		public System.Nullable<bool> AsyncAutoDelete
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("asyncautodelete");
			}
			set
			{
				OnPropertyChanging("AsyncAutoDelete");
				SetAttributeValue("asyncautodelete", value);
				OnPropertyChanged("AsyncAutoDelete");
			}
		}
		
		/// <summary>
		/// Identifies whether a SDK Message Processing Step type will be ReadOnly or Read Write. false - ReadWrite, true - ReadOnly 
		/// </summary>
		[AttributeLogicalNameAttribute("canusereadonlyconnection")]
		public System.Nullable<bool> CanUseReadOnlyConnection
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("canusereadonlyconnection");
			}
			set
			{
				OnPropertyChanging("CanUseReadOnlyConnection");
				SetAttributeValue("canusereadonlyconnection", value);
				OnPropertyChanged("CanUseReadOnlyConnection");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.
		/// </summary>
		[AttributeLogicalNameAttribute("configuration")]
		public string Configuration
		{
			get
			{
				return GetAttributeValue<string>("configuration");
			}
			set
			{
				OnPropertyChanging("Configuration");
				SetAttributeValue("configuration", value);
				OnPropertyChanged("Configuration");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageprocessingstep.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Description of the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return GetAttributeValue<string>("description");
			}
			set
			{
				OnPropertyChanging("Description");
				SetAttributeValue("description", value);
				OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated event handler.
		/// </summary>
		[AttributeLogicalNameAttribute("eventhandler")]
		public Microsoft.Xrm.Sdk.EntityReference EventHandler
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("eventhandler");
			}
			set
			{
				OnPropertyChanging("EventHandler");
				SetAttributeValue("eventhandler", value);
				OnPropertyChanged("EventHandler");
			}
		}
		
		/// <summary>
		/// Comma-separated list of attributes. If at least one of these attributes is modified, the plug-in should execute.
		/// </summary>
		[AttributeLogicalNameAttribute("filteringattributes")]
		public string FilteringAttributes
		{
			get
			{
				return GetAttributeValue<string>("filteringattributes");
			}
			set
			{
				OnPropertyChanging("FilteringAttributes");
				SetAttributeValue("filteringattributes", value);
				OnPropertyChanged("FilteringAttributes");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user to impersonate context when step is executed.
		/// </summary>
		[AttributeLogicalNameAttribute("impersonatinguserid")]
		public Microsoft.Xrm.Sdk.EntityReference ImpersonatingUserId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("impersonatinguserid");
			}
			set
			{
				OnPropertyChanging("ImpersonatingUserId");
				SetAttributeValue("impersonatinguserid", value);
				OnPropertyChanged("ImpersonatingUserId");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		[AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			get
			{
				return GetAttributeValue<string>("introducedversion");
			}
			set
			{
				OnPropertyChanging("IntroducedVersion");
				SetAttributeValue("introducedversion", value);
				OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Identifies if a plug-in should be executed from a parent pipeline, a child pipeline, or both.
		/// </summary>
		[AttributeLogicalNameAttribute("invocationsource")]
		[System.ObsoleteAttribute()]
		public Microsoft.Xrm.Sdk.OptionSetValue InvocationSource
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invocationsource");
			}
			set
			{
				OnPropertyChanging("InvocationSource");
				SetAttributeValue("invocationsource", value);
				OnPropertyChanged("InvocationSource");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			set
			{
				OnPropertyChanging("IsCustomizable");
				SetAttributeValue("iscustomizable", value);
				OnPropertyChanged("IsCustomizable");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component should be hidden.
		/// </summary>
		[AttributeLogicalNameAttribute("ishidden")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsHidden
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden");
			}
			set
			{
				OnPropertyChanging("IsHidden");
				SetAttributeValue("ishidden", value);
				OnPropertyChanged("IsHidden");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component is managed.
		/// </summary>
		[AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Run-time mode of execution, for example, synchronous or asynchronous.
		/// </summary>
		[AttributeLogicalNameAttribute("mode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Mode
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("mode");
			}
			set
			{
				OnPropertyChanging("Mode");
				SetAttributeValue("mode", value);
				OnPropertyChanged("Mode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of SdkMessage processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return GetAttributeValue<string>("name");
			}
			set
			{
				OnPropertyChanging("Name");
				SetAttributeValue("name", value);
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message processing step is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type associated with the step.
		/// </summary>
		[AttributeLogicalNameAttribute("plugintypeid")]
		[System.ObsoleteAttribute()]
		public Microsoft.Xrm.Sdk.EntityReference PluginTypeId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid");
			}
			set
			{
				OnPropertyChanging("PluginTypeId");
				SetAttributeValue("plugintypeid", value);
				OnPropertyChanged("PluginTypeId");
			}
		}
		
		/// <summary>
		/// Processing order within the stage.
		/// </summary>
		[AttributeLogicalNameAttribute("rank")]
		public System.Nullable<int> Rank
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("rank");
			}
			set
			{
				OnPropertyChanging("Rank");
				SetAttributeValue("rank", value);
				OnPropertyChanged("Rank");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message filter.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagefilterid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageFilterId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagefilterid");
			}
			set
			{
				OnPropertyChanging("SdkMessageFilterId");
				SetAttributeValue("sdkmessagefilterid", value);
				OnPropertyChanged("SdkMessageFilterId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
			}
			set
			{
				OnPropertyChanging("SdkMessageId");
				SetAttributeValue("sdkmessageid", value);
				OnPropertyChanged("SdkMessageId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step entity.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepid");
			}
			set
			{
				OnPropertyChanging("SdkMessageProcessingStepId");
				SetAttributeValue("sdkmessageprocessingstepid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessageProcessingStepId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepidunique")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Sdk message processing step secure configuration.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageProcessingStepSecureConfigId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageprocessingstepsecureconfigid");
			}
			set
			{
				OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
				SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
				OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Stage in the execution pipeline that the SDK message processing step is in.
		/// </summary>
		[AttributeLogicalNameAttribute("stage")]
		public Microsoft.Xrm.Sdk.OptionSetValue Stage
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("stage");
			}
			set
			{
				OnPropertyChanging("Stage");
				SetAttributeValue("stage", value);
				OnPropertyChanged("Stage");
			}
		}
		
		/// <summary>
		/// Status of the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<SdkMessageProcessingStepState> StateCode
		{
			get
			{
				OptionSetValue optionSet = GetAttributeValue<OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((SdkMessageProcessingStepState)(System.Enum.ToObject(typeof(SdkMessageProcessingStepState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				OnPropertyChanging("StateCode");
				if ((value == null))
				{
					SetAttributeValue("statecode", null);
				}
				else
				{
					SetAttributeValue("statecode", new OptionSetValue(((int)(value))));
				}
				OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				OnPropertyChanging("StatusCode");
				SetAttributeValue("statuscode", value);
				OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Deployment that the SDK message processing step should be executed on; server, client, or both.
		/// </summary>
		[AttributeLogicalNameAttribute("supporteddeployment")]
		public Microsoft.Xrm.Sdk.OptionSetValue SupportedDeployment
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("supporteddeployment");
			}
			set
			{
				OnPropertyChanging("SupportedDeployment");
				SetAttributeValue("supporteddeployment", value);
				OnPropertyChanged("SupportedDeployment");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("supportingsolutionid")]
		public System.Nullable<System.Guid> SupportingSolutionId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("supportingsolutionid");
			}
		}
		
		/// <summary>
		/// Number that identifies a specific revision of the SDK message processing step. 
		/// </summary>
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		/// </summary>
		[RelationshipSchemaNameAttribute("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
		public IEnumerable<SdkMessageProcessingStepImage> sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		{
			get
			{
				return GetRelatedEntities<SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null);
			}
			set
			{
				OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
				SetRelatedEntities<SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value);
				OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
			}
		}
		
		/// <summary>
		/// N:1 plugintype_sdkmessageprocessingstep
		/// </summary>
		[AttributeLogicalNameAttribute("eventhandler")]
		[RelationshipSchemaNameAttribute("plugintype_sdkmessageprocessingstep")]
		public PluginType plugintype_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntity<PluginType>("plugintype_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("plugintype_sdkmessageprocessingstep");
				SetRelatedEntity<PluginType>("plugintype_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("plugintype_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 plugintypeid_sdkmessageprocessingstep
		/// </summary>
		[AttributeLogicalNameAttribute("plugintypeid")]
		[RelationshipSchemaNameAttribute("plugintypeid_sdkmessageprocessingstep")]
		public PluginType plugintypeid_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntity<PluginType>("plugintypeid_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
				SetRelatedEntity<PluginType>("plugintypeid_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessagefilterid_sdkmessageprocessingstep
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagefilterid")]
		[RelationshipSchemaNameAttribute("sdkmessagefilterid_sdkmessageprocessingstep")]
		public SdkMessageFilter sdkmessagefilterid_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntity<SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
				SetRelatedEntity<SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageid_sdkmessageprocessingstep
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageid")]
		[RelationshipSchemaNameAttribute("sdkmessageid_sdkmessageprocessingstep")]
		public SdkMessage sdkmessageid_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
				SetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		[RelationshipSchemaNameAttribute("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
		public SdkMessageProcessingStepSecureConfig sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntity<SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
				SetRelatedEntity<SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
			}
		}
	}

	/// <summary>
	/// Copy of an entity's attributes before or after the core system operation.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessageprocessingstepimage")]
	public partial class SdkMessageProcessingStepImage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessageprocessingstepimage";
			
            public const string Attributes1 = "attributes";
            public const string ComponentState = "componentstate";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string Description = "description";
            public const string EntityAlias = "entityalias";
            public const string ImageType = "imagetype";
            public const string IntroducedVersion = "introducedversion";
            public const string IsCustomizable = "iscustomizable";
            public const string IsManaged = "ismanaged";
            public const string MessagePropertyName = "messagepropertyname";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string Name = "name";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string OverwriteTime = "overwritetime";
            public const string RelatedAttributeName = "relatedattributename";
            public const string SdkMessageProcessingStepId = "sdkmessageprocessingstepid";
            public const string SdkMessageProcessingStepIdName = "sdkmessageprocessingstepidName";
            public const string SdkMessageProcessingStepImageId = "sdkmessageprocessingstepimageid";
            public const string SdkMessageProcessingStepImageIdUnique = "sdkmessageprocessingstepimageidunique";
            public const string SolutionId = "solutionid";
            public const string SupportingSolutionId = "supportingsolutionid";
            public const string VersionNumber = "versionnumber";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
            public enum ComponentState 
            {
                Published = 0,
                Unpublished = 1,
                Deleted = 2,
                DeletedUnpublished = 3,
            }		
            public enum ImageType 
            {
                PreImage = 0,
                PostImage = 1,
                Both = 2,
            }		
            public enum IsManaged 
            {
                Managed = 1,
                Unmanaged = 0,
            }		
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageProcessingStepImage() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageprocessingstepimage";
		
		public const int EntityTypeCode = 4615;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepimageid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessageProcessingStepImageId = value;
			}
		}
		
		/// <summary>
		/// Comma-separated list of attributes that are to be passed into the SDK message processing step image.
		/// </summary>
		[AttributeLogicalNameAttribute("attributes")]
		public string Attributes1
		{
			get
			{
				return GetAttributeValue<string>("attributes");
			}
			set
			{
				OnPropertyChanging("Attributes1");
				SetAttributeValue("attributes", value);
				OnPropertyChanged("Attributes1");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message processing step image.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step image was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageprocessingstepimage.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message processing step image.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Description of the SDK message processing step image.
		/// </summary>
		[AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return GetAttributeValue<string>("description");
			}
			set
			{
				OnPropertyChanging("Description");
				SetAttributeValue("description", value);
				OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Key name used to access the pre-image or post-image property bags in a step.
		/// </summary>
		[AttributeLogicalNameAttribute("entityalias")]
		public string EntityAlias
		{
			get
			{
				return GetAttributeValue<string>("entityalias");
			}
			set
			{
				OnPropertyChanging("EntityAlias");
				SetAttributeValue("entityalias", value);
				OnPropertyChanged("EntityAlias");
			}
		}
		
		/// <summary>
		/// Type of image requested.
		/// </summary>
		[AttributeLogicalNameAttribute("imagetype")]
		public Microsoft.Xrm.Sdk.OptionSetValue ImageType
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("imagetype");
			}
			set
			{
				OnPropertyChanging("ImageType");
				SetAttributeValue("imagetype", value);
				OnPropertyChanged("ImageType");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		[AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			get
			{
				return GetAttributeValue<string>("introducedversion");
			}
			set
			{
				OnPropertyChanging("IntroducedVersion");
				SetAttributeValue("introducedversion", value);
				OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			set
			{
				OnPropertyChanging("IsCustomizable");
				SetAttributeValue("iscustomizable", value);
				OnPropertyChanged("IsCustomizable");
			}
		}
		
		[AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Name of the property on the Request message.
		/// </summary>
		[AttributeLogicalNameAttribute("messagepropertyname")]
		public string MessagePropertyName
		{
			get
			{
				return GetAttributeValue<string>("messagepropertyname");
			}
			set
			{
				OnPropertyChanging("MessagePropertyName");
				SetAttributeValue("messagepropertyname", value);
				OnPropertyChanged("MessagePropertyName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageprocessingstepimage.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of SdkMessage processing step image.
		/// </summary>
		[AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return GetAttributeValue<string>("name");
			}
			set
			{
				OnPropertyChanging("Name");
				SetAttributeValue("name", value);
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message processing step is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Name of the related entity.
		/// </summary>
		[AttributeLogicalNameAttribute("relatedattributename")]
		public string RelatedAttributeName
		{
			get
			{
				return GetAttributeValue<string>("relatedattributename");
			}
			set
			{
				OnPropertyChanging("RelatedAttributeName");
				SetAttributeValue("relatedattributename", value);
				OnPropertyChanged("RelatedAttributeName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageProcessingStepId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageprocessingstepid");
			}
			set
			{
				OnPropertyChanging("SdkMessageProcessingStepId");
				SetAttributeValue("sdkmessageprocessingstepid", value);
				OnPropertyChanged("SdkMessageProcessingStepId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step image entity.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepimageid")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepImageId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepimageid");
			}
			set
			{
				OnPropertyChanging("SdkMessageProcessingStepImageId");
				SetAttributeValue("sdkmessageprocessingstepimageid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessageProcessingStepImageId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step image.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepimageidunique")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepImageIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepimageidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("supportingsolutionid")]
		public System.Nullable<System.Guid> SupportingSolutionId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("supportingsolutionid");
			}
		}
		
		/// <summary>
		/// Number that identifies a specific revision of the step image. 
		/// </summary>
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
		[RelationshipSchemaNameAttribute("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
		public SdkMessageProcessingStep sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		{
			get
			{
				return GetRelatedEntity<SdkMessageProcessingStep>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null);
			}
			set
			{
				OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
				SetRelatedEntity<SdkMessageProcessingStep>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value);
				OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
			}
		}
	}

	/// <summary>
	/// Non-public custom configuration that is passed to a plug-in's constructor.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessageprocessingstepsecureconfig")]
	public partial class SdkMessageProcessingStepSecureConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessageprocessingstepsecureconfig";
			
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string SdkMessageProcessingStepSecureConfigId = "sdkmessageprocessingstepsecureconfigid";
            public const string SdkMessageProcessingStepSecureConfigIdUnique = "sdkmessageprocessingstepsecureconfigidunique";
            public const string SecureConfig = "secureconfig";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageProcessingStepSecureConfig() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageprocessingstepsecureconfig";
		
		public const int EntityTypeCode = 4616;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessageProcessingStepSecureConfigId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageprocessingstepsecureconfig.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message processing step secure configuration.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageprocessingstepsecureconfig.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message processing step is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step secure configuration.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepSecureConfigId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepsecureconfigid");
			}
			set
			{
				OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
				SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigidunique")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepSecureConfigIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepsecureconfigidunique");
			}
		}
		
		/// <summary>
		/// Secure step-specific configuration for the plug-in type that is passed to the plug-in's constructor at run time.
		/// </summary>
		[AttributeLogicalNameAttribute("secureconfig")]
		public string SecureConfig
		{
			get
			{
				return GetAttributeValue<string>("secureconfig");
			}
			set
			{
				OnPropertyChanging("SecureConfig");
				SetAttributeValue("secureconfig", value);
				OnPropertyChanged("SecureConfig");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		/// </summary>
		[RelationshipSchemaNameAttribute("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		{
			get
			{
				return GetRelatedEntities<SdkMessageProcessingStep>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null);
			}
			set
			{
				OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
				SetRelatedEntities<SdkMessageProcessingStep>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null, value);
				OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
			}
		}
	}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessagerequest")]
	public partial class SdkMessageRequest : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessagerequest";
			
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string Name = "name";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string PrimaryObjectTypeCode = "primaryobjecttypecode";
            public const string SdkMessagePairId = "sdkmessagepairid";
            public const string SdkMessagePairIdName = "sdkmessagepairidName";
            public const string SdkMessageRequestId = "sdkmessagerequestid";
            public const string SdkMessageRequestIdUnique = "sdkmessagerequestidunique";
            public const string VersionNumber = "versionnumber";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageRequest() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessagerequest";
		
		public const int EntityTypeCode = 4609;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessagerequestid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessageRequestId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message request.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message request was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessagerequest.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message request.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message request.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message request was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessagerequest.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the SDK message request.
		/// </summary>
		[AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return GetAttributeValue<string>("name");
			}
			set
			{
				OnPropertyChanging("Name");
				SetAttributeValue("name", value);
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message request is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Type of entity with which the SDK request is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("primaryobjecttypecode")]
		public string PrimaryObjectTypeCode
		{
			get
			{
				return GetAttributeValue<string>("primaryobjecttypecode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message pair with which the SDK message request is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagepairid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessagePairId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagepairid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message request entity.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagerequestid")]
		public System.Nullable<System.Guid> SdkMessageRequestId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestid");
			}
			set
			{
				OnPropertyChanging("SdkMessageRequestId");
				SetAttributeValue("sdkmessagerequestid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessageRequestId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message request.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagerequestidunique")]
		public System.Nullable<System.Guid> SdkMessageRequestIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestidunique");
			}
		}
		
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N messagerequest_sdkmessageresponse
		/// </summary>
		[RelationshipSchemaNameAttribute("messagerequest_sdkmessageresponse")]
		public IEnumerable<SdkMessageResponse> messagerequest_sdkmessageresponse
		{
			get
			{
				return GetRelatedEntities<SdkMessageResponse>("messagerequest_sdkmessageresponse", null);
			}
			set
			{
				OnPropertyChanging("messagerequest_sdkmessageresponse");
				SetRelatedEntities<SdkMessageResponse>("messagerequest_sdkmessageresponse", null, value);
				OnPropertyChanged("messagerequest_sdkmessageresponse");
			}
		}
		
		/// <summary>
		/// 1:N messagerequest_sdkmessagerequestfield
		/// </summary>
		[RelationshipSchemaNameAttribute("messagerequest_sdkmessagerequestfield")]
		public IEnumerable<SdkMessageRequestField> messagerequest_sdkmessagerequestfield
		{
			get
			{
				return GetRelatedEntities<SdkMessageRequestField>("messagerequest_sdkmessagerequestfield", null);
			}
			set
			{
				OnPropertyChanging("messagerequest_sdkmessagerequestfield");
				SetRelatedEntities<SdkMessageRequestField>("messagerequest_sdkmessagerequestfield", null, value);
				OnPropertyChanged("messagerequest_sdkmessagerequestfield");
			}
		}
		
		/// <summary>
		/// N:1 messagepair_sdkmessagerequest
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagepairid")]
		[RelationshipSchemaNameAttribute("messagepair_sdkmessagerequest")]
		public SdkMessagePair messagepair_sdkmessagerequest
		{
			get
			{
				return GetRelatedEntity<SdkMessagePair>("messagepair_sdkmessagerequest", null);
			}
		}
	}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessagerequestfield")]
	public partial class SdkMessageRequestField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessagerequestfield";
			
            public const string ClrParser = "clrparser";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string FieldMask = "fieldmask";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string Name = "name";
            public const string Optional = "optional";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string ParameterBindingInformation = "parameterbindinginformation";
            public const string Parser = "parser";
            public const string Position = "position";
            public const string PublicName = "publicname";
            public const string SdkMessageRequestFieldId = "sdkmessagerequestfieldid";
            public const string SdkMessageRequestFieldIdUnique = "sdkmessagerequestfieldidunique";
            public const string SdkMessageRequestId = "sdkmessagerequestid";
            public const string SdkMessageRequestIdName = "sdkmessagerequestidName";
            public const string VersionNumber = "versionnumber";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
            public enum Optional 
            {
                Yes = 1,
                No = 0,
            }		
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageRequestField() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessagerequestfield";
		
		public const int EntityTypeCode = 4614;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessagerequestfieldid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessageRequestFieldId = value;
			}
		}
		
		/// <summary>
		/// Common language runtime (CLR)-based parser for the SDK message request field.
		/// </summary>
		[AttributeLogicalNameAttribute("clrparser")]
		public string ClrParser
		{
			get
			{
				return GetAttributeValue<string>("clrparser");
			}
			set
			{
				OnPropertyChanging("ClrParser");
				SetAttributeValue("clrparser", value);
				OnPropertyChanged("ClrParser");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message request field.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message request field was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessagerequestfield.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message request field.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Indicates how field contents are used during message processing. 1 - Primary entity, 2- Secondary entity
		/// </summary>
		[AttributeLogicalNameAttribute("fieldmask")]
		public System.Nullable<int> FieldMask
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("fieldmask");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message request field.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message request field was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessagerequestfield.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the SDK message request field.
		/// </summary>
		[AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return GetAttributeValue<string>("name");
			}
			set
			{
				OnPropertyChanging("Name");
				SetAttributeValue("name", value);
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Information about whether SDK message request field is optional.
		/// </summary>
		[AttributeLogicalNameAttribute("optional")]
		public System.Nullable<bool> Optional
		{
			get
			{
				return GetAttributeValue<System.Nullable<bool>>("optional");
			}
			set
			{
				OnPropertyChanging("Optional");
				SetAttributeValue("optional", value);
				OnPropertyChanged("Optional");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message request field is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		[AttributeLogicalNameAttribute("parameterbindinginformation")]
		public string ParameterBindingInformation
		{
			get
			{
				return GetAttributeValue<string>("parameterbindinginformation");
			}
			set
			{
				OnPropertyChanging("ParameterBindingInformation");
				SetAttributeValue("parameterbindinginformation", value);
				OnPropertyChanged("ParameterBindingInformation");
			}
		}
		
		/// <summary>
		/// Parser for the SDK message request field.
		/// </summary>
		[AttributeLogicalNameAttribute("parser")]
		public string Parser
		{
			get
			{
				return GetAttributeValue<string>("parser");
			}
			set
			{
				OnPropertyChanging("Parser");
				SetAttributeValue("parser", value);
				OnPropertyChanged("Parser");
			}
		}
		
		/// <summary>
		/// Position of the Sdk message request field
		/// </summary>
		[AttributeLogicalNameAttribute("position")]
		public System.Nullable<int> Position
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("position");
			}
		}
		
		/// <summary>
		/// Public name of the SDK message request field.
		/// </summary>
		[AttributeLogicalNameAttribute("publicname")]
		public string PublicName
		{
			get
			{
				return GetAttributeValue<string>("publicname");
			}
			set
			{
				OnPropertyChanging("PublicName");
				SetAttributeValue("publicname", value);
				OnPropertyChanged("PublicName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message request field entity.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagerequestfieldid")]
		public System.Nullable<System.Guid> SdkMessageRequestFieldId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestfieldid");
			}
			set
			{
				OnPropertyChanging("SdkMessageRequestFieldId");
				SetAttributeValue("sdkmessagerequestfieldid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessageRequestFieldId");
			}
		}
		
		/// <summary>
		/// Entity identifier of the SDK message request field.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagerequestfieldidunique")]
		public System.Nullable<System.Guid> SdkMessageRequestFieldIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestfieldidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message request with which the SDK message request field is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagerequestid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageRequestId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagerequestid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 messagerequest_sdkmessagerequestfield
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagerequestid")]
		[RelationshipSchemaNameAttribute("messagerequest_sdkmessagerequestfield")]
		public SdkMessageRequest messagerequest_sdkmessagerequestfield
		{
			get
			{
				return GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessagerequestfield", null);
			}
		}
	}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessageresponse")]
	public partial class SdkMessageResponse : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessageresponse";
			
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string SdkMessageRequestId = "sdkmessagerequestid";
            public const string SdkMessageRequestIdName = "sdkmessagerequestidName";
            public const string SdkMessageResponseId = "sdkmessageresponseid";
            public const string SdkMessageResponseIdUnique = "sdkmessageresponseidunique";
            public const string VersionNumber = "versionnumber";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageResponse() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageresponse";
		
		public const int EntityTypeCode = 4610;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessageresponseid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessageResponseId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message response.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message response was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageresponse.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message response.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message response.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message response was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageresponse.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message response is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message request with which the SDK message response is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagerequestid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageRequestId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagerequestid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response entity.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageresponseid")]
		public System.Nullable<System.Guid> SdkMessageResponseId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponseid");
			}
			set
			{
				OnPropertyChanging("SdkMessageResponseId");
				SetAttributeValue("sdkmessageresponseid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessageResponseId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageresponseidunique")]
		public System.Nullable<System.Guid> SdkMessageResponseIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponseidunique");
			}
		}
		
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N messageresponse_sdkmessageresponsefield
		/// </summary>
		[RelationshipSchemaNameAttribute("messageresponse_sdkmessageresponsefield")]
		public IEnumerable<SdkMessageResponseField> messageresponse_sdkmessageresponsefield
		{
			get
			{
				return GetRelatedEntities<SdkMessageResponseField>("messageresponse_sdkmessageresponsefield", null);
			}
			set
			{
				OnPropertyChanging("messageresponse_sdkmessageresponsefield");
				SetRelatedEntities<SdkMessageResponseField>("messageresponse_sdkmessageresponsefield", null, value);
				OnPropertyChanged("messageresponse_sdkmessageresponsefield");
			}
		}
		
		/// <summary>
		/// N:1 messagerequest_sdkmessageresponse
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessagerequestid")]
		[RelationshipSchemaNameAttribute("messagerequest_sdkmessageresponse")]
		public SdkMessageRequest messagerequest_sdkmessageresponse
		{
			get
			{
				return GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessageresponse", null);
			}
		}
	}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[DataContractAttribute()]
	[EntityLogicalNameAttribute("sdkmessageresponsefield")]
	public partial class SdkMessageResponseField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Fields
		public class Fields
		{
		    public const string SchemaName = "sdkmessageresponsefield";
			
            public const string ClrFormatter = "clrformatter";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyName";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyName";
            public const string CustomizationLevel = "customizationlevel";
            public const string Formatter = "formatter";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyName";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
            public const string Name = "name";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidName";
            public const string ParameterBindingInformation = "parameterbindinginformation";
            public const string Position = "position";
            public const string PublicName = "publicname";
            public const string SdkMessageResponseFieldId = "sdkmessageresponsefieldid";
            public const string SdkMessageResponseFieldIdUnique = "sdkmessageresponsefieldidunique";
            public const string SdkMessageResponseId = "sdkmessageresponseid";
            public const string SdkMessageResponseIdName = "sdkmessageresponseidName";
            public const string Value = "value";
            public const string VersionNumber = "versionnumber";
        }
		#endregion Fields

		#region Enums

		 public class Enums
        {
        }

		#endregion
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageResponseField() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageresponsefield";
		
		public const int EntityTypeCode = 4611;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		[AttributeLogicalNameAttribute("sdkmessageresponsefieldid")]
		public override Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				SdkMessageResponseFieldId = value;
			}
		}
		
		/// <summary>
		/// Common language runtime (CLR)-based formatter of the SDK message response field.
		/// </summary>
		[AttributeLogicalNameAttribute("clrformatter")]
		public string ClrFormatter
		{
			get
			{
				return GetAttributeValue<string>("clrformatter");
			}
			set
			{
				OnPropertyChanging("ClrFormatter");
				SetAttributeValue("clrformatter", value);
				OnPropertyChanged("ClrFormatter");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message response field.
		/// </summary>
		[AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message response field was created.
		/// </summary>
		[AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageresponsefield.
		/// </summary>
		[AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message response field.
		/// </summary>
		[AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Formatter for the SDK message response field.
		/// </summary>
		[AttributeLogicalNameAttribute("formatter")]
		public string Formatter
		{
			get
			{
				return GetAttributeValue<string>("formatter");
			}
			set
			{
				OnPropertyChanging("Formatter");
				SetAttributeValue("formatter", value);
				OnPropertyChanged("Formatter");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message response field.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message response field was last modified.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageresponsefield.
		/// </summary>
		[AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the SDK message response field.
		/// </summary>
		[AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return GetAttributeValue<string>("name");
			}
			set
			{
				OnPropertyChanging("Name");
				SetAttributeValue("name", value);
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message response field is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		[AttributeLogicalNameAttribute("parameterbindinginformation")]
		public string ParameterBindingInformation
		{
			get
			{
				return GetAttributeValue<string>("parameterbindinginformation");
			}
			set
			{
				OnPropertyChanging("ParameterBindingInformation");
				SetAttributeValue("parameterbindinginformation", value);
				OnPropertyChanged("ParameterBindingInformation");
			}
		}
		
		/// <summary>
		/// Position of the Sdk message response field
		/// </summary>
		[AttributeLogicalNameAttribute("position")]
		public System.Nullable<int> Position
		{
			get
			{
				return GetAttributeValue<System.Nullable<int>>("position");
			}
		}
		
		/// <summary>
		/// Public name of the SDK message response field.
		/// </summary>
		[AttributeLogicalNameAttribute("publicname")]
		public string PublicName
		{
			get
			{
				return GetAttributeValue<string>("publicname");
			}
			set
			{
				OnPropertyChanging("PublicName");
				SetAttributeValue("publicname", value);
				OnPropertyChanged("PublicName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response field entity.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageresponsefieldid")]
		public System.Nullable<System.Guid> SdkMessageResponseFieldId
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponsefieldid");
			}
			set
			{
				OnPropertyChanging("SdkMessageResponseFieldId");
				SetAttributeValue("sdkmessageresponsefieldid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				OnPropertyChanged("SdkMessageResponseFieldId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response field.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageresponsefieldidunique")]
		public System.Nullable<System.Guid> SdkMessageResponseFieldIdUnique
		{
			get
			{
				return GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponsefieldidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message response with which the SDK message response field is associated.
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageresponseid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageResponseId
		{
			get
			{
				return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageresponseid");
			}
		}
		
		/// <summary>
		/// Actual value of the SDK message response field.
		/// </summary>
		[AttributeLogicalNameAttribute("value")]
		public string Value
		{
			get
			{
				return GetAttributeValue<string>("value");
			}
			set
			{
				OnPropertyChanging("Value");
				SetAttributeValue("value", value);
				OnPropertyChanged("Value");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 messageresponse_sdkmessageresponsefield
		/// </summary>
		[AttributeLogicalNameAttribute("sdkmessageresponseid")]
		[RelationshipSchemaNameAttribute("messageresponse_sdkmessageresponsefield")]
		public SdkMessageResponse messageresponse_sdkmessageresponsefield
		{
			get
			{
				return GetRelatedEntity<SdkMessageResponse>("messageresponse_sdkmessageresponsefield", null);
			}
		}
	}

	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	public partial class XrmServiceContext : OrganizationServiceContext
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public XrmServiceContext(IOrganizationService service) : 
				base(service)
		{
		}

		/// <summary>
		/// Gets a binding to the set of all <see cref="PluginAssembly"/> entities.
		/// </summary>
		public IQueryable<PluginAssembly> PluginAssemblySet
		{
			get
			{
				return CreateQuery<PluginAssembly>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="PluginType"/> entities.
		/// </summary>
		public IQueryable<PluginType> PluginTypeSet
		{
			get
			{
				return CreateQuery<PluginType>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessage"/> entities.
		/// </summary>
		public IQueryable<SdkMessage> SdkMessageSet
		{
			get
			{
				return CreateQuery<SdkMessage>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageFilter"/> entities.
		/// </summary>
		public IQueryable<SdkMessageFilter> SdkMessageFilterSet
		{
			get
			{
				return CreateQuery<SdkMessageFilter>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessagePair"/> entities.
		/// </summary>
		public IQueryable<SdkMessagePair> SdkMessagePairSet
		{
			get
			{
				return CreateQuery<SdkMessagePair>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageProcessingStep"/> entities.
		/// </summary>
		public IQueryable<SdkMessageProcessingStep> SdkMessageProcessingStepSet
		{
			get
			{
				return CreateQuery<SdkMessageProcessingStep>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageProcessingStepImage"/> entities.
		/// </summary>
		public IQueryable<SdkMessageProcessingStepImage> SdkMessageProcessingStepImageSet
		{
			get
			{
				return CreateQuery<SdkMessageProcessingStepImage>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageProcessingStepSecureConfig"/> entities.
		/// </summary>
		public IQueryable<SdkMessageProcessingStepSecureConfig> SdkMessageProcessingStepSecureConfigSet
		{
			get
			{
				return CreateQuery<SdkMessageProcessingStepSecureConfig>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageRequest"/> entities.
		/// </summary>
		public IQueryable<SdkMessageRequest> SdkMessageRequestSet
		{
			get
			{
				return CreateQuery<SdkMessageRequest>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageRequestField"/> entities.
		/// </summary>
		public IQueryable<SdkMessageRequestField> SdkMessageRequestFieldSet
		{
			get
			{
				return CreateQuery<SdkMessageRequestField>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageResponse"/> entities.
		/// </summary>
		public IQueryable<SdkMessageResponse> SdkMessageResponseSet
		{
			get
			{
				return CreateQuery<SdkMessageResponse>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageResponseField"/> entities.
		/// </summary>
		public IQueryable<SdkMessageResponseField> SdkMessageResponseFieldSet
		{
			get
			{
				return CreateQuery<SdkMessageResponseField>();
			}
		}
	}
}
