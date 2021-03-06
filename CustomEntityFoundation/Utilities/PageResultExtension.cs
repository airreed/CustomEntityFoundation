﻿using CustomEntityFoundation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomEntityFoundation.Utilities
{
    public static class PageResultExtension
    {
        /// <summary>
        /// Load data by pager
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pageResult"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public static PageResult<T> LoadData<T>(this PageResult<T> pageResult, IQueryable<T> query)
        {
            int page = pageResult.Page;
            int size = pageResult.Size;

            pageResult.Total = query.Count();
            pageResult.Items = query.Skip((page - 1) * size).Take(size).ToList();

            return pageResult;
        }
    }
}
