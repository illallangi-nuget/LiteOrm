﻿namespace Illallangi.LiteOrm
{
    using System.Collections.Generic;

    public interface IRepository<T> where T : class
    {
        int Import(params T[] objs);

        IEnumerable<T> Create(params T[] objs);

        IEnumerable<T> Retrieve(T obj = null);

        T Update(T obj);

        void Delete(params T[] objs);
    }
}