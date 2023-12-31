﻿using DomainModel;
using Intarfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repository
{
    public class BookingReposSQL : IRepository<Booking>
    {
        private DataContext db;
        public BookingReposSQL(DataContext db)
        {
            this.db = db;
        }

        public void Create(Booking item)
        {
            db.Booking.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Booking GetItem(int id)
        {
            return db.Booking.Find(id);
        }

        public List<Booking> GetList()
        {
            return db.Booking.ToList();
        }

        public void Update(Booking item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
