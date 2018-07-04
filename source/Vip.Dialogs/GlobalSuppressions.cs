// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project. 
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc. 
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File". 
// You do not need to add suppressions to this file manually. 

using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope = "member",
        Target = "Vip.Dialogs.ComCtlv6ActivationContext.#_cookie")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "disposing", Scope = "member",
        Target = "Vip.Dialogs.ComCtlv6ActivationContext.#Dispose(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member",
        Target = "Vip.Dialogs.VistaFileDialog.#.ctor()")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member",
        Target = "Vip.Dialogs.VistaOpenFileDialog.#OpenFile()")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member",
        Target = "Vip.Dialogs.VistaSaveFileDialog.#OpenFile()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi",
        Scope = "member", Target = "Vip.Dialogs.VistaFileDialog.#SupportMultiDottedExtensions")]