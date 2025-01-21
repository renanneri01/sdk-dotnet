namespace MercadoPago.Resource.Order
{
    using System;
    using System.Collections.Generic;
    using MercadoPago.Http;

    /// <summary>
    /// Invoice Period class.
    /// </summary>
    public class OrderInvoicePeriod
    {
        /// <summary>
        /// Type of invoice.
        /// </summary>        
        public string Type { get; set; }

        /// <summary>
        /// Period of invoice.
        /// </summary>        
        public int Period { get; set; }
    }
}