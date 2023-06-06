using System;
using System.Collections.Generic;

namespace HelperSystem.Domain.Models
{
    public partial class ApplicantAllergie
    {
        public long IdApplicantAllergie { get; set; }
        public int? FkIdApplicant { get; set; }
        public long? FkIdAllergie { get; set; }
    }
}
