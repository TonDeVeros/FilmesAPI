using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using AutoMapper;

namespace FilmesAPI.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto> ();
            CreateMap<UpdateEnderecoDto, Endereco>();

        }
    }
}
