namespace MercadoPago.Resource.Order
{
    using System;
    using System.Collections.Generic;
    using MercadoPago.Http;

    /// <summary>
    /// Identification class.
    /// </summary>
    public class OrderIdentification
    {
        /// <summary>
        /// Type of identification.
        /// </summary>        
        public string Type { get; set; }

        /// <summary>
        /// Unique number of that identification.
        /// </summary>
        public string Number { get; set; }
    }
}