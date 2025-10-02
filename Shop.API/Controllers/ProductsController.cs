using System.Collections.Generic;
using shop.API.Models;
using Microsoft.AspNetCore.Mvc;
using shop.API.Data;
using AutoMapper;
using shop.API.Dtos;

namespace shop.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepo _repository;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDto>> GetProducts()
        {
            var productItems = _repository.GetProducts();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(productItems));
        }

        [HttpGet("{id}", Name = "GetProductsById")]
        public ActionResult<ProductReadDto> GetProductsById(int id)
        {
            var productItem = _repository.GetProductsById(id);
            if (productItem != null)
            {
                return Ok(_mapper.Map<ProductReadDto>(productItem));
            }
            return NotFound();
        }

        //Post api/products
        [HttpPost]
        public ActionResult<ProductReadDto> CreateProduct(ProductCreateDto productCreateDto)
        {
            var productModel = _mapper.Map<Product>(productCreateDto);
            _repository.CreatProduct(productModel);
            _repository.SaveChanges();

            var productReadDto = _mapper.Map<ProductReadDto>(productModel);

            return CreatedAtRoute(nameof(GetProductsById), new { Id = productReadDto.Id }, productReadDto);

        }
        //Put api/products
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, ProductUpdateDto productUpdateDto)
        {
            var productModelFromRepo = _repository.GetProductsById(id);
            if (productModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(productUpdateDto, productModelFromRepo);

            _repository.UpdateProduct(productModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var productModelFromRepo = _repository.GetProductsById(id);
            if (productModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteProduct(productModelFromRepo);
            _repository.SaveChanges();

            return NoContent();

        }
    }
}
