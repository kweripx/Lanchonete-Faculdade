using AutoMapper;
using VendasLanches03.DTO;
using VendasLanches03.Models;
using VendasLanches03.Repositories.Interfaces;

namespace VendasLanches03.Services
{
    public class CategoryService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoriaRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task AddCategory(CategoryDTO categoryDto)
        {
            var categoriesEntity = _mapper.Map<Categoria>(categoryDto);
            await _categoryRepository.Create(categoriesEntity);
            categoryDto.CategoriaId = categoriesEntity.CategoriaId;
        }
        public async Task UpdateCategory(CategoryDTO categoryDto)
        {
            var categoriesEntity = _mapper.Map<Categoria>(categoryDto);
            await _categoryRepository.Update(categoriesEntity);
        }

        public async Task DeleteCategory(int id)
        {
            var categoriesEntity =  _categoryRepository.GetCategoryById(id).Result;
            await _categoryRepository.Delete(categoriesEntity.CategoriaId);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categoriesEntity = await _categoryRepository.GetAll();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task<CategoryDTO> GetCategoryById(int id)
        {
            var categoriesEntity = await _categoryRepository.GetCategoryById(id);
            return _mapper.Map<CategoryDTO>(categoriesEntity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesProducts()
        {
            var categoriesEntity = await _categoryRepository.GetCategoriesProducts();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }
    }
}
