﻿using AdvancedProgramming.Data;
using System.Data.Entity;

namespace AdvancedProgramming.Repository
{
    public interface IRepositoryProduct : IRepositoryBase<Product>
    {
    }

    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        public RepositoryProduct() : base()
        {
        }

        // Implement any specific methods for Product if needed
    }

}
