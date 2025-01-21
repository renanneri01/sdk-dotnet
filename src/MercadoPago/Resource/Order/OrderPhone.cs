namespace MercadoPago.Resource.Order
{
    using System;
    using System.Collections.Generic;
    using MercadoPago.Http;

    /// <summary>
    /// Phone class.
    /// </summary>
    public class OrderPhone
    {
        /// <summary>
        /// Area code.
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        public string Number { get; set; }
    }
}