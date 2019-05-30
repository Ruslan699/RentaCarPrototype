﻿using RentaTransport.AdminUI.Models;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.AdminUI.Utils
{
    public class MapperConfig : AutoMapper.Profile
    {
        public MapperConfig()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<CityViewModel, CityDTO>().ReverseMap();
        }
    }
}
