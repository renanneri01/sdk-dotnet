namespace MercadoPago.Client.Order
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Address class.
    /// </summary>
    public class OrderAddressRequest
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