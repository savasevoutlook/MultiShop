﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.DTOs.ProductDTOs;
using MultiShop.Catalog.Services.ProductServices;

namespace MultiShop.Catalog.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    #region Fields

    private readonly IProductService _productService;

    #endregion

    #region Ctor

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    #endregion

    #region Methods

    [HttpGet]
    public async Task<IActionResult> GetProductList()
    {
        var products = await _productService.GetAllProductsAsync();

        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(string id)
    {
        var product = await _productService.GetProductByIdAsync(id);

        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
    {
        await _productService.CreateProductAsync(createProductDto);

        return Ok("Ürün başarıyla eklendi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
    {
        await _productService.UpdateProductAsync(updateProductDto);

        return Ok("Ürün başarıyla güncellendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteProduct(string id)
    {
        await _productService.DeleteProductAsync(id);

        return Ok("Ürün başarıyla silindi.");
    }

    #endregion
}
