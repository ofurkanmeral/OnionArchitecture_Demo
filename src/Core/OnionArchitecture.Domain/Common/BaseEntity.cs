﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string CreatedUsername { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedUsername { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
