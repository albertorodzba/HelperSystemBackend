using System;
using System.Collections.Generic;

namespace HelperSystem.Domain.Models
{
    public partial class Allergie
    {
        public int IdAlergie { get; set; }
        public string AlergieName { get; set; } = null!;
    }
}
