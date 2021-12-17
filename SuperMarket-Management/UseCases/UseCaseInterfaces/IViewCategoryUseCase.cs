using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewCategoryUseCase
    {
        public IEnumerable<Category> Execute();
    }
}