﻿using ETicaretApi.Application.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new() {
             new(){Id=Guid.NewGuid(),Name="Product1",Price=100,CreatedDate=DateTime.UtcNow,Stock=10},
             new(){Id=Guid.NewGuid(),Name="Product2",Price=150,CreatedDate=DateTime.UtcNow,Stock=15},
             new(){Id=Guid.NewGuid(),Name="Product3",Price=160,CreatedDate=DateTime.UtcNow,Stock=14},
             new(){Id=Guid.NewGuid(),Name="Product4",Price=170,CreatedDate=DateTime.UtcNow,Stock=13}});
            await _productWriteRepository.SaveAsync();
        }
    }
}
