namespace MercadoPago.Client.Order
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Subscription Sequence class.
    /// </summary>
    public class OrderSubscriptionSequenceRequest
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