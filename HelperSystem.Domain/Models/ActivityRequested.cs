﻿using System;
using System.Collections.Generic;

namespace HelperSystem.Domain.Models
{
    public partial class ActivityRequested
    {
        public long IdActivityRequested { get; set; }
        public long? FkIdJobOffer { get; set; }
        public int? FkIdActivity { get; set; }

        public virtual Activity? FkIdActivityNavigation { get; set; }
        public virtual JobOffer? FkIdJobOfferNavigation { get; set; }
    }
}
