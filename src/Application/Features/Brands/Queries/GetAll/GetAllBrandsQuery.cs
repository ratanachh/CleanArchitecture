﻿using AutoMapper;
using Inventory.Application.Interfaces.Repositories;
using Inventory.Domain.Entities.Catalog;
using Inventory.Shared.Constants.Application;
using Inventory.Shared.Wrapper;
using LazyCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Inventory.Application.Features.Brands.Queries.GetAll
{
    public class GetAllBrandsQuery : IRequest<Result<List<GetAllBrandsResponse>>>
    {
        public GetAllBrandsQuery()
        {
        }
    }

    internal class GetAllBrandsCachedQueryHandler : IRequestHandler<GetAllBrandsQuery, Result<List<GetAllBrandsResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllBrandsCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllBrandsResponse>>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Brand>>> getAllBrands = () => _unitOfWork.Repository<Brand>().GetAllAsync();
            var brandList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllBrandsCacheKey, getAllBrands);
            var mappedBrands = _mapper.Map<List<GetAllBrandsResponse>>(brandList);
            return await Result<List<GetAllBrandsResponse>>.SuccessAsync(mappedBrands);
        }
    }
}