﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.model
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public bool PaymentStatus { get; set; }
        /// <summary>
        /// PaymentType take his value from enum PaymentType
        /// </summary>
        public string PaymentType { get; set; } = null!;

        #region One2Many With Receptionist
        public long? ReceptionistId { get; set; }
        public virtual Receptionist Receptionist { get; set; } = null!;
        #endregion

        #region One2One With Apointment
        public int? ApointmentId { get; set; }
        public virtual Apointment Apointment { get; set; }=null!;
        #endregion
    }
}
