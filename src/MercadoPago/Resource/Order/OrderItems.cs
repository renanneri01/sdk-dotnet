namespace MercadoPago.Resource.Order
{
    using System;
    using System.Collections.Generic;
    using MercadoPago.Http;

    /// <summary>
    /// Items class.
    /// </summary>
    public class OrderItems
    {
        /// <summary>
        /// ID of the item.
        /// </summary>        
        public string Id { get; set; }

        /// <summary>
        /// Title of the item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Unit price of the item.
        /// </summary>
        public string UnitPrice { get; set; }

        /// <summary>
        /// Description of the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Category Id of the item.
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// Type of the item.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Picture URL of the item.
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// Quantity of the item.
        /// </summary>
        public int Quantity { get; set; }
    }
}