﻿using api.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class PurchaseProposalForm: BaseEntity
    {
        public int Id { get; set; }
        public DateTime Deadline { get; set; }
        public PurchaseProposalFormStatus Status { get; set; }
        public string Description { get; set; }

        public ICollection<PurchaseProposalDetail> PurchaseProposalDetails { get; set; }
    }
}