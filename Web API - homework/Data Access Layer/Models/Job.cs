﻿using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    public partial class Job
    {
        public Job()
        {
            StaffSkill = new HashSet<StaffSkill>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public DateTime? Deadline { get; set; }
        public string EmploymentTerm { get; set; }
        public string TimeType { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Responsibilities { get; set; }
        public string RequiredQualifications { get; set; }
        public string AdditionalInformation { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<StaffSkill> StaffSkill { get; set; }
    }
}
