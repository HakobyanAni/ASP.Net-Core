﻿using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    public partial class GithubProfile
    {
        public GithubProfile()
        {
            GithubRepository = new HashSet<GithubRepository>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Url { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string BlogOrWebsite { get; set; }
        public int StarsCount { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual ICollection<GithubRepository> GithubRepository { get; set; }
    }
}
