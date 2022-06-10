﻿using AutoMapper;
using ExpoCenter.Dominio.Entidades;
using ExpoCenter.Mvc.Models;

namespace ExpoCenter.Mvc.Mapping
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<Participante, ParticipanteViewModel>().ReverseMap();
            CreateMap<Participante, ParticipanteCreateViewModel>().ReverseMap();
            
            CreateMap<Evento, EventoViewModel>().ReverseMap();
            CreateMap<Evento, EventoGridViewModel>().ReverseMap();
        }
    }
}
