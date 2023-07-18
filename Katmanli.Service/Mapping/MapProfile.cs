using AutoMapper;
using Katmanli.Core;
using Katmanli.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli.Service.Mapping
{
    public class MapProfile : Profile

    {
        public MapProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDTO>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
        }
    }
}
