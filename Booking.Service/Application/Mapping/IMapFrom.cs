﻿using AutoMapper;

namespace Booking.Service.Application.Mapping
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
