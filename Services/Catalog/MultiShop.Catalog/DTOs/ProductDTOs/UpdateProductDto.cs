﻿namespace MultiShop.Catalog.DTOs.ProductDTOs;

public class UpdateProductDto
{
    public string ProductId { get; set; }

    public string ProductName { get; set; }

    public decimal ProductPrice { get; set; }

    public int ProductStock { get; set; }

    public string ProductImageUrl { get; set; }

    public string ProductDescription { get; set; }

    public string CategoryId { get; set; }
}
