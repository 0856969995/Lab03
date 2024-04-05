using Lab03.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
    public class ProductController: Controller
    {
        private readonly IProductRepository _productRepository; 
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }

    }
}
