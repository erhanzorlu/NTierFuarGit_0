﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Request:BaseEntity
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int DelayTime { get; set; }

        public override string ToString()
        {
            return $"{Name} - Fiyatı : {UnitPrice:C2} Tahmini teslim süresi : {DelayTime} gün";
        }



        //Relational Properties


        public virtual List<CustomerRequest> CustomerRequests { get; set; }
        public virtual List<RequestIssue> RequestIssues { get; set; }

    }
}
