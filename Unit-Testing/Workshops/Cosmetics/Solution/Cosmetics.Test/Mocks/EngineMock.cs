﻿using System.Collections.Generic;
using Cosmetics.Contracts;
using Cosmetics.Engine;

namespace Cosmetics.Test.Mocks
{
    internal class EngineMock : CosmeticsEngine
    {
        public EngineMock(ICosmeticsFactory factory, IShoppingCart shoppingCart)
            : base(factory, shoppingCart)
        {
        }

        public IDictionary<string, ICategory> Categories
        {
            get
            {
                return base.categories;
            }
        }

        public IDictionary<string, IProduct> Products
        {
            get
            {
                return base.products;
            }
        }
    }
}
