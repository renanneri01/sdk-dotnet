namespace MercadoPago.Resource.Order
{
    using System;
    using System.Collections.Generic;
    using MercadoPago.Http;

    /// <summary>
    /// Address class.
    /// </summary>
    public class OrderAddress
    {
        /// <summary>
        /// Street Name.
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// Street Number.
        /// </summary>        
        public string StreetNumber { get; set; }
    }
}