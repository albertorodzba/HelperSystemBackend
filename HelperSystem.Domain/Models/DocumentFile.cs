using System;
using System.Collections.Generic;

namespace HelperSystem.Domain.Models
{
    public partial class DocumentFile
    {
        public long IdFile { get; set; }
        public long? FkIdDocumentFolder { get; set; }
        public string FileUrl { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string IdFileGenerated { get; set; } = null!;

        public virtual DocumentFolder? FkIdDocumentFolderNavigation { get; set; }
    }
}
