﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.SSHDebugPS {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StringResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.SSHDebugPS.StringResources", typeof(StringResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting to the remote system failed due to authentication failure. Enter your updated connection info and try connecting again..
        /// </summary>
        internal static string AuthenticationFailureDescription {
            get {
                return ResourceManager.GetString("AuthenticationFailureDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication Failure.
        /// </summary>
        internal static string AuthenticationFailureHeader {
            get {
                return ResourceManager.GetString("AuthenticationFailureHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Command &apos;{0}&apos; failed with code &apos;{1}&apos;. {2}&quot;.
        /// </summary>
        internal static string CommandFailedMessageFormat {
            get {
                return ResourceManager.GetString("CommandFailedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft-SSHPortSupplier-FileCopy-.
        /// </summary>
        internal static string CopyFile_TempFilePrefix {
            get {
                return ResourceManager.GetString("CopyFile_TempFilePrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Docker (Linux Container) connection type allows Visual Studio to connect to Docker containers running locally or remotely (using SSH)..
        /// </summary>
        internal static string Docker_PSDescription {
            get {
                return ResourceManager.GetString("Docker_PSDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to docker exec {0} \&quot;{1}\&quot;.
        /// </summary>
        internal static string DockerExecCommandFormat {
            get {
                return ResourceManager.GetString("DockerExecCommandFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command failed to execute.
        /// </summary>
        internal static string Error_CommandFailed {
            get {
                return ResourceManager.GetString("Error_CommandFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection string provided is not formatted properly..
        /// </summary>
        internal static string Error_ContainerConnectionStringInvalidMessage {
            get {
                return ResourceManager.GetString("Error_ContainerConnectionStringInvalidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection String Format Invalid.
        /// </summary>
        internal static string Error_ContainerConnectionStringInvalidTitle {
            get {
                return ResourceManager.GetString("Error_ContainerConnectionStringInvalidTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to run &apos;/bin/sh&apos; on container &apos;{0}&apos; failed with output: &apos;{1}&apos;.
        /// </summary>
        internal static string Error_ContainerUnavailableMessage {
            get {
                return ResourceManager.GetString("Error_ContainerUnavailableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container unavailable.
        /// </summary>
        internal static string Error_ContainerUnavailableTitle {
            get {
                return ResourceManager.GetString("Error_ContainerUnavailableTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source file &apos;{0}&apos; not found..
        /// </summary>
        internal static string Error_CopyFile_SourceNotFound {
            get {
                return ResourceManager.GetString("Error_CopyFile_SourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to copy files..
        /// </summary>
        internal static string Error_CopyFileFailed {
            get {
                return ResourceManager.GetString("Error_CopyFileFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse exit code..
        /// </summary>
        internal static string Error_ExitCodeNotParseable {
            get {
                return ResourceManager.GetString("Error_ExitCodeNotParseable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified directory {0} could not be created or accessed..
        /// </summary>
        internal static string Error_InvalidDirectory {
            get {
                return ResourceManager.GetString("Error_InvalidDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}
        ///
        ///{1}.
        /// </summary>
        internal static string Error_ProcessListFailedFormat {
            get {
                return ResourceManager.GetString("Error_ProcessListFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to obtain process list.
        /// </summary>
        internal static string Error_ProcessListFailedTitle {
            get {
                return ResourceManager.GetString("Error_ProcessListFailedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsing &apos;/proc&apos; file system for processes failed. Output: &apos;{0}&apos;.
        /// </summary>
        internal static string Error_ProcFSError {
            get {
                return ResourceManager.GetString("Error_ProcFSError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;ps&apos; command failed with exit code &apos;{0}&apos;. Output: {1}.
        /// </summary>
        internal static string Error_PSErrorFormat {
            get {
                return ResourceManager.GetString("Error_PSErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to obtain process list..
        /// </summary>
        internal static string Error_PSFailed {
            get {
                return ResourceManager.GetString("Error_PSFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;ps&apos; command missing..
        /// </summary>
        internal static string Error_PSMissing {
            get {
                return ResourceManager.GetString("Error_PSMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot process command. Connection is not open..
        /// </summary>
        internal static string Error_ShellNotRunning {
            get {
                return ResourceManager.GetString("Error_ShellNotRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source file &apos;{0}&apos; not found.
        /// </summary>
        internal static string Error_SourceFileNotFound {
            get {
                return ResourceManager.GetString("Error_SourceFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter credentials to connect to {0}.
        /// </summary>
        internal static string HeaderTextFormat {
            get {
                return ResourceManager.GetString("HeaderTextFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;hostname&gt;.
        /// </summary>
        internal static string HostName_PlaceHolder {
            get {
                return ResourceManager.GetString("HostName_PlaceHolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;unknown&gt;.
        /// </summary>
        internal static string ProcessName_Unknown {
            get {
                return ResourceManager.GetString("ProcessName_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SSH (Secure Shell) Transport allows connecting Visual Studio to computers running an SSH server with a bash-like shell (ex: Linux, macOS, etc)..
        /// </summary>
        internal static string SSH_PSDescription {
            get {
                return ResourceManager.GetString("SSH_PSDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;username&gt;.
        /// </summary>
        internal static string UserName_PlaceHolder {
            get {
                return ResourceManager.GetString("UserName_PlaceHolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting to {0}....
        /// </summary>
        internal static string WaitingOp_Connecting {
            get {
                return ResourceManager.GetString("WaitingOp_Connecting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running command &apos;{0}&apos; on the remote system....
        /// </summary>
        internal static string WaitingOp_ExecutingCommand {
            get {
                return ResourceManager.GetString("WaitingOp_ExecutingCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running ps on the remote system....
        /// </summary>
        internal static string WaitingOp_ExecutingPS {
            get {
                return ResourceManager.GetString("WaitingOp_ExecutingPS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Obtaining user&apos;s home directory path from remote system....
        /// </summary>
        internal static string WaitingOp_HomeDirectory {
            get {
                return ResourceManager.GetString("WaitingOp_HomeDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating directory on remote system....
        /// </summary>
        internal static string WaitingOp_MakeDirectory {
            get {
                return ResourceManager.GetString("WaitingOp_MakeDirectory", resourceCulture);
            }
        }
    }
}
