﻿using First.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
    }
}
