﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CrmModel.Model
{
    public class CashDesk
    {
        public Queue<Cart> Queue { get; set; }
        public int MaxLenghtQueue { get; set; } = 100;
        public int GoneCustomer { get; set; }
        public Seller Seller { get; set; }
        public CrmContext Crm { get; set; }

        public CashDesk(int maxLenghtQueue, Seller seller, CrmContext crm)
        {
            if(maxLenghtQueue <= 0)
            {
                throw new ArgumentException("Queue cannot be less than 0 or be equal to 0.", nameof(maxLenghtQueue));
            }

            if(seller == null)
            {
                throw new ArgumentNullException("Sellers cannot be null.", nameof(seller));
            }

            MaxLenghtQueue = maxLenghtQueue;
            Queue = new Queue<Cart>();
            Seller = seller;
            Crm = crm;
        }

        public void Enqueue(Cart cart)
        {
            if(cart != null)
            {
                if (Queue.Count < MaxLenghtQueue)
                {
                    Queue.Enqueue(cart);
                }
                else
                {
                    GoneCustomer += 1;
                }
            }
        }

        public void ServeCustomer()
        {
            var currentCart = Queue.Peek();
            var check = MakeCheck(currentCart);
            Crm.Checks.Add(check);
            Queue.Dequeue();
        }

        public Check MakeCheck(Cart cart)
        {
            Check check = new Check()
            {
                Created = DateTime.Now,
                Seller = Seller,
                Customer = cart.Customer,
                SellerId = Seller.SellerId,
                CustomerId = cart.Customer.CustomerId
            };

            return check;
        }
    }
}
