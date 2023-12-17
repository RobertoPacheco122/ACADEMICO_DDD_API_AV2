﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public abstract class BaseEntity {
        public int Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime? DataAtualizacao { get; set;}
    }
}
