using AutoMapper;
using SikhUnit.Domain.Entity;
using SikhUnit.Site.Models;

namespace SikhUnit.Site
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Album, AlbumViewModel>();
            Mapper.CreateMap<Song, SongViewModel>();
            Mapper.CreateMap<Literature, LiteratureViewModel>();
            Mapper.CreateMap<OtherSite, OtherSiteViewModel>();
            Mapper.CreateMap<ContactViewModel, Contact>();
        }
    }
}