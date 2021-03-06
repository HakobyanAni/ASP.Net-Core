﻿using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    public partial class StaffSkill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int JobId { get; set; }

        public virtual Job Job { get; set; }
    }
}
