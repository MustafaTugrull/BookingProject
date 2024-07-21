﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Abstractions
{
    public interface IManager<T> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
        IEnumerable<T> GetAll();
        T GetByID(Guid id);
    }
}
