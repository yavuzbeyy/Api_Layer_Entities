using AutoMapper;
using Katmanli.Core;
using Katmanli.Core.DTOs;
using Katmanli.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Katmanli.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _service;

        public ProductsController(IMapper mapper, IService<Product> service)
        {
            this._mapper = mapper;
            this._service = service;
        }


        /// GET api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();

            var productsDtos = _mapper.Map<List<ProductDTO>>(products);

            return CreateActionResult(CustomResponseDto<List<ProductDTO>>.Success(200, productsDtos));
        }

        /// GET api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);

            var productsDto = _mapper.Map<ProductDTO>(product);

            return CreateActionResult(CustomResponseDto<ProductDTO>.Success(200, productsDto));
        }


        [HttpPost()]
        public async Task<IActionResult> Save(ProductDTO productDto)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));
            var productsDto = _mapper.Map<ProductDTO>(product);
            return CreateActionResult(CustomResponseDto<ProductDTO>.Success(201, productsDto));
        }

        [HttpPut()]
        public async Task<IActionResult> Update(ProductUpdateDto productDto)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }


        //DELETE api/products
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var product = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(product);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
