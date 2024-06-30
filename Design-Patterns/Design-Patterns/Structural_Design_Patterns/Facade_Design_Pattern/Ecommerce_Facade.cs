using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design_Patterns.Structural_Design_Patterns.Facade_Design_Pattern.Ecommerce_Facade.Order;

namespace Design_Patterns.Structural_Design_Patterns.Facade_Design_Pattern
{
    public class Ecommerce_Facade
    {
        public class Order
        {
            // Subsytem Interface - 1
            public interface IProduct
            {
                void GetProductDetails();
            }

            // Subsytem Interface - 2
            public interface IPayment
            {
                void MakePayment();
            }

            // Subsytem Interface - 3
            public interface IInvoice
            {
                void SendInvoice();
            }

            // Subsystem 1
            public class Product : IProduct
            {
                public void GetProductDetails()
                {
                    Console.WriteLine(" 1.Fetching the Product Details\n");
                }
            }

            // Subsystem 2
            public class Payment : IPayment
            {
                public void MakePayment()
                {
                    Console.WriteLine("\n 2.Payment Done Successfully\n");
                }
            }

            // Subsystem 3
            public class Invoice : IInvoice
            {
                public void SendInvoice()
                {
                    Console.WriteLine("\n 3.Invoice Send Successfully \n");
                }
            }
        }

        // Facade
        public class OrderFacade
        {
            private IProduct _product;
            private IPayment _payment;
            private IInvoice _invoice;

            public OrderFacade()
            {
                _product = new Product();
                _payment = new Payment();
                _invoice = new Invoice();
            }

            public void PlaceOrder()
            {
                Console.WriteLine("\n---Place Order Started---\n");

                //Get the Product Details
                _product.GetProductDetails();

                //Make the Payment
                _payment.MakePayment();

                //Send the Invoice
                _invoice.SendInvoice();

                Console.WriteLine("\n---Order Placed Successfully---\n");
            }
        }

    }
}
