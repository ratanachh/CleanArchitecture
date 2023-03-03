using Inventory.Application.Specifications.Base;
using Inventory.Domain.Entities.Catalog;

namespace Inventory.Application.Specifications.Catalog
{
    public class BrandFilterSpecification : Specification<Brand>
    {
        public BrandFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) || p.Description.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}
