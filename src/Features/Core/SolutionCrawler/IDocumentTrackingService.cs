// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Host;

namespace Microsoft.CodeAnalysis
{
    internal interface IDocumentTrackingService : IWorkspaceService
    {
        /// <summary>
        /// Get the <see cref="DocumentId"/> of the active document. May be null if there is no active document
        /// or the active document is not in the workspace.
        /// </summary>
        DocumentId GetActiveDocument();

        /// <summary>
        /// Get a read only collection of the <see cref="DocumentId"/>s of all the visible documents in the workspace.
        /// </summary>
        ImmutableArray<DocumentId> GetVisibleDocuments();

        event EventHandler<DocumentId> ActiveDocumentChanged;
    }
}
