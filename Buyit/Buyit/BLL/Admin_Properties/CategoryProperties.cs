﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin_Properties
{
    public class CategoryProperties
    {
        public string mainCategory { get; set; }
        public int mainCategoryID { get; set; }

        public string subCategory1 { get; set; }
        public int subCategory1_ID { get; set; }

        public string subCategory2 { get; set; }
        public int subCategory2_ID { get; set; }

        public string subCategory3 { get; set; }
        public int subCategory3_ID { get; set; }
    }
}
