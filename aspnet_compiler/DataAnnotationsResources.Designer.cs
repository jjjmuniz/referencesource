﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.16745
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Web.Compilation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CompilerResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CompilerResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Web.Compilation.CompilerResources", typeof(CompilerResources).Assembly);
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
        ///   Looks up a localized string similar to sep.
        /// </summary>
        internal static string _sep01_ {
            get {
                return ResourceManager.GetString("_sep01_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, the strong-name assembly will allow partially trusted callers..
        /// </summary>
        internal static string aptca_help {
            get {
                return ResourceManager.GetString("aptca_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a well formed IIS metabase path..
        /// </summary>
        internal static string bad_mdpath {
            get {
                return ResourceManager.GetString("bad_mdpath", resourceCulture);
            }
        }

        internal static string brand_text {
            get {
                return ResourceManager.GetString("brand_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, the precompiled application is fully rebuilt. Any previously compiled components will be re-compiled. This option is always enabled when targetDir is specified..
        /// </summary>
        internal static string c_help {
            get {
                return ResourceManager.GetString("c_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright (C) Microsoft Corporation. All rights reserved..
        /// </summary>
        internal static string copyright {
            get {
                return ResourceManager.GetString("copyright", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, the debug information is emitted during compilation..
        /// </summary>
        internal static string d_help {
            get {
                return ResourceManager.GetString("d_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, the assembly is not fully signed when created. .
        /// </summary>
        internal static string delaysign_help {
            get {
                return ResourceManager.GetString("delaysign_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory &apos;{0}&apos; doesn&apos;t exist..
        /// </summary>
        internal static string dir_not_exist {
            get {
                return ResourceManager.GetString("dir_not_exist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows extra debugging information that can help debug certain conditions..
        /// </summary>
        internal static string errorstack_help {
            get {
                return ResourceManager.GetString("errorstack_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following two commands are equivalent, and rely on the IIS metabase. The compiled application is deployed to c:\MyTarget:.
        /// </summary>
        internal static string example1 {
            get {
                return ResourceManager.GetString("example1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following command compiles the application /MyApp in-place. The effect is that no more compilations will be needed when HTTP requests are sent to it:.
        /// </summary>
        internal static string example2 {
            get {
                return ResourceManager.GetString("example2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following command does *not* rely on the IIS metabase, as it explicitly specifies the physical source directory of the application:.
        /// </summary>
        internal static string example3 {
            get {
                return ResourceManager.GetString("example3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Examples:.
        /// </summary>
        internal static string examples {
            get {
                return ResourceManager.GetString("examples", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrites the target directory if it already exists. Existing contents are lost..
        /// </summary>
        internal static string f_help {
            get {
                return ResourceManager.GetString("f_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, the compiled assemblies will be given fixed names..
        /// </summary>
        internal static string fixednames_help {
            get {
                return ResourceManager.GetString("fixednames_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The -{0} switch can only be used if a targetDir is specified..
        /// </summary>
        internal static string flag_requires_target {
            get {
                return ResourceManager.GetString("flag_requires_target", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Utility to precompile an ASP.NET application.
        /// </summary>
        internal static string header_text {
            get {
                return ResourceManager.GetString("header_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The -aptca switch can only be used if keyfile or keycontainer is specified..
        /// </summary>
        internal static string invalid_aptca {
            get {
                return ResourceManager.GetString("invalid_aptca", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The -delaysign switch can only be used if keyfile or keycontainer is specified..
        /// </summary>
        internal static string invalid_delaysign {
            get {
                return ResourceManager.GetString("invalid_delaysign", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The keyfile &apos;{0}&apos; cannot be found..
        /// </summary>
        internal static string invalid_keyfile {
            get {
                return ResourceManager.GetString("invalid_keyfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid path..
        /// </summary>
        internal static string invalid_path {
            get {
                return ResourceManager.GetString("invalid_path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid virtual path..
        /// </summary>
        internal static string invalid_vpath {
            get {
                return ResourceManager.GetString("invalid_vpath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies a strong name key container..
        /// </summary>
        internal static string keycontainer_help {
            get {
                return ResourceManager.GetString("keycontainer_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The physical path to the strong name key file..
        /// </summary>
        internal static string keyfile_help {
            get {
                return ResourceManager.GetString("keyfile_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The full IIS metabase path of the application. This switch cannot be combined with the -v or -p switches..
        /// </summary>
        internal static string m_help {
            get {
                return ResourceManager.GetString("m_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; switch needs to be followed by an argument..
        /// </summary>
        internal static string missing_arg {
            get {
                return ResourceManager.GetString("missing_arg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either -m or -v must be specified (but not both)..
        /// </summary>
        internal static string need_m_or_v {
            get {
                return ResourceManager.GetString("need_m_or_v", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The -m and -p switches cannot both be used..
        /// </summary>
        internal static string no_m_and_p {
            get {
                return ResourceManager.GetString("no_m_and_p", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Suppress compiler copyright message..
        /// </summary>
        internal static string nologo_help {
            get {
                return ResourceManager.GetString("nologo_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The physical path of the application to be compiled. If -p is missing, the IIS metabase is used to locate the app. This switch must be combined with -v..
        /// </summary>
        internal static string p_help {
            get {
                return ResourceManager.GetString("p_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prints this help text..
        /// </summary>
        internal static string questionmark_help {
            get {
                return ResourceManager.GetString("questionmark_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Run &apos;aspnet_compiler -?&apos; for a list of valid options..
        /// </summary>
        internal static string short_usage_text {
            get {
                return ResourceManager.GetString("short_usage_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Strong name verification failure, can not load file or assembly &apos;{0}&apos;. If the assembly is delay-signed, make sure verification is skipped for the public key token..
        /// </summary>
        internal static string Strongname_failure {
            get {
                return ResourceManager.GetString("Strongname_failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The physical path to which the application is compiled. If not specified, the application is precompiled in-place..
        /// </summary>
        internal static string targetDir_help {
            get {
                return ResourceManager.GetString("targetDir_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, the precompiled application is updatable..
        /// </summary>
        internal static string u_help {
            get {
                return ResourceManager.GetString("u_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected parameter: &apos;{0}&apos;..
        /// </summary>
        internal static string unexpected_param {
            get {
                return ResourceManager.GetString("unexpected_param", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown switch: &apos;{0}&apos;..
        /// </summary>
        internal static string unknown_switch {
            get {
                return ResourceManager.GetString("unknown_switch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:.
        /// </summary>
        internal static string usage {
            get {
                return ResourceManager.GetString("usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The virtual path of the application to be compiled (e.g. &quot;/MyApp&quot;). If -p is specified, the physical path is used to locate the application. Otherwise, the IIS metabase is used, and the application is assumed to be in the default site (under &quot;/LM/W3SVC/1/Root&quot;). This switch cannot be combined with the -m switch..
        /// </summary>
        internal static string v_help {
            get {
                return ResourceManager.GetString("v_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The virtual path of a directory that should be excluded from precompilation. This switch can be used multiple times..
        /// </summary>
        internal static string x_help {
            get {
                return ResourceManager.GetString("x_help", resourceCulture);
            }
        }
    }
}