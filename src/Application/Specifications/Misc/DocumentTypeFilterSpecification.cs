﻿using Inventory.Application.Specifications.Base;
using Inventory.Domain.Entities.Misc;

namespace Inventory.Application.Specifications.Misc
{
    public class DocumentTypeFilterSpecification : Specification<DocumentType>
    {
        public DocumentTypeFilterSpecification(string searchString)
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