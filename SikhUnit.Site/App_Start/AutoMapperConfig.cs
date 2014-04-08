using System.IO;
using AutoMapper;
using SikhUnit.Configuration;
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
            Mapper.CreateMap<Image, ImageViewModel>();
            Mapper.CreateMap<Literature, LiteratureViewModel>();
            Mapper.CreateMap<OtherSite, OtherSiteViewModel>();

            Mapper.CreateMap<MusicVideo, VideoViewModel>()
                .ForMember(n => n.ExtensionLessName, opt => opt.MapFrom(
                    m => Path.GetFileNameWithoutExtension(
                        Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.MusicVideosPath, m.Name))));
            
            Mapper.CreateMap<TalkVideo, VideoViewModel>()
                .ForMember(n => n.ExtensionLessName, opt => opt.MapFrom(
                    m => Path.GetFileNameWithoutExtension(
                        Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.TalkVideosPath, m.Name))));

            Mapper.CreateMap<ContactViewModel, Contact>();
        }
    }
}