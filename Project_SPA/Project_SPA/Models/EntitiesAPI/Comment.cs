﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Project_SPA.Models.EntitiesAPI
{
    public partial class Comment
    {
        public int IdComment { get; set; }
        public string Comment1 { get; set; }
        public int IdUser { get; set; }
        public int IdNews { get; set; }

        public virtual News News { get; set; }
    }
}
