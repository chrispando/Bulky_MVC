using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Bulky.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        void Save();
    }
}