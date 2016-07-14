﻿namespace FSharp.Editing.VisualStudio.ProjectSystem

open System.ComponentModel.Composition
open Microsoft.VisualStudio.Text.Editor
open Microsoft.VisualStudio.Utilities

[<Export(typeof<IWpfTextViewCreationListener>)>]
[<ContentType("F#")>]
[<TextViewRole(PredefinedTextViewRoles.Interactive)>]
type ActiveViewRegistratorListener [<ImportingConstructor>]([<Import>] openDocumentsTracker: IVSOpenDocumentsTracker) = 
    interface IWpfTextViewCreationListener with
        member __.TextViewCreated view = openDocumentsTracker.RegisterView view