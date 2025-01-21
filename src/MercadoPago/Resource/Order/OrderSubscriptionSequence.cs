namespace MercadoPago.Resource.Order
{
    using System;
    using System.Collections.Generic;
    using MercadoPago.Http;

    /// <summary>
    /// Subscription Sequence class.
    /// </summary>
    public class OrderSubscriptionSequence
    {
        /// <summary>
        /// Number.
        /// </summary>        
        public int Number { get; set; }

        /// <summary>
        /// Total.
        /// </summary>
        public int Total { get; set; }
    }
}