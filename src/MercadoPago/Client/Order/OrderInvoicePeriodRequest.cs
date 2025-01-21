namespace MercadoPago.Client.Order
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Invoice Period class.
    /// </summary>
    public class OrderInvoicePeriodRequest
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