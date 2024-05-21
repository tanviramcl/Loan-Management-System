﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanManagementSystem.Models
{
    public class EarlySatlement
    {
        public int ADVANCE_EARLY_SATALEMENT_ID { get; set; }
        public int DISBURSED_ID { get; set; }
        public double DUE_PRINCIPAL { get; set; }
        public double DUE_INTEREST { get; set; }
        public string EMPLOYEE_ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime EARLY_SATALEMENT_DATE { get; set; }
        public string LOAN_ID { get; set; }
        public string CHECK_NO { get; set; }
        
    }
}