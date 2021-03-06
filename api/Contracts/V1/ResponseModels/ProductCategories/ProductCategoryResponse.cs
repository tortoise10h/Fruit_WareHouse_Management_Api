﻿using System;

namespace api.Contracts.V1.ResponseModels.ProductCategories
{
    public class ProductCategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}
