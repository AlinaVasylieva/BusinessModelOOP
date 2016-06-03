using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUnitTests
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        public Order Retrieve(int orderId)
        {
            //Create the instance of Order
            //Pass the requested Id

            Order order = new Order(orderId);

            //Code tht retrieves the defined order
            //Temporary hard coded values to return
            //a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(0, 0, 1));
            }
            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //Code that retrieves the defined order fields
            //Temporary Hard-coded data

            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(0, 0, 1));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };

                orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();
                //Code that retrieves the order items
                //Temporary data

                if (orderId == 10)
                {
                    var orderDisplayItem = new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M,
                        OrderQuantity = 2
                    };
                    orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
                }

            }
            return orderDisplay;
        }

        public bool Save()
        {
            //Code that saves the defined customer
            return true;
        }
    }
}

