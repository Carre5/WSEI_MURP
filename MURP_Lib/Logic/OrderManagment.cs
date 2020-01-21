using MURP_Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MURP_Lib.Logic
{
    public static class OrderManagment
    {
        public static List<Order> Orders;

        public static void CreateOrder(string companyEmail, string carRegistrationNumber)
        {
            if (!Validators.EmailValid(companyEmail))
            {
                throw new FormatException();
            }

            if (!Validators.CarRegistrationNumberValid(companyEmail))
            {
                throw new FormatException();
            }

            Company company = CompanyManagment.FindByEmail(companyEmail);
            Car car = CarManagment.FindByRegistrationNumber(carRegistrationNumber);

            DateTime now = DateTime.Now;
            string orderId = generateOrderID(now);

            Order order = new Order()
            {
                Order_ID = orderId,
                Creation_Date = now,
                Company = company,
                Assigned_Car = car,
                Status = Order_Status.NEW
            };

            Orders.Add(order);
        }

        private static string generateOrderID(DateTime Now)
        {
            return Now.ToString();
        }

        public static void SaveOrder(Order order, User user)
        {
            if (order != null && user != null)
            {
                order.Status = Order_Status.IN_PROGRESS;
                order.Assigned_User = user;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public static void ResolveOrder(Order order, Order_Rating rating)
        {
            if (order != null)
            {
                order.Status = Order_Status.RESOLVED;
                order.User_Rating = rating;
                order.Assigned_Car.Status = Car_Status.FREE;

                CompanyManagment.HandleRating(order.Company, rating);
            }
            else
            {
                throw new ArgumentNullException();
            }
            
        }
    }
}
