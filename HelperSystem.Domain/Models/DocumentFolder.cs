using System;
using System.Collections.Generic;

namespace HelperSystem.Domain.Models
{
    public partial class DocumentFolder
    {
        public DocumentFolder()
        {
            DocumentFiles = new HashSet<DocumentFile>();
        }

        public long IdDocumentFolder { get; set; }
        public long? FkIdPersonalFolder { get; set; }
        public int? FkIdDocumentType { get; set; }
        public string FolderUrl { get; set; } = null!;
        public string IdFolderGenerated { get; set; } = null!;

        public virtual DocumentType? FkIdDocumentTypeNavigation { get; set; }
        public virtual PersonalFolder? FkIdPersonalFolderNavigation { get; set; }
        public virtual ICollection<DocumentFile> DocumentFiles { get; set; }
    }
}
