using System.Web.Mvc;
using Ninject;
using SikhUnit.BusinessLogic;
using SikhUnit.Cache;
using SikhUnit.Configuration;
using SikhUnit.DataAccess.Core;
using SikhUnit.DataAccess.Repository;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.Domain.Interface.Service;

namespace SikhUnit.Site
{
    public static class NinjectConfig
    {
        public static void RegisterInjections()
        {
            IKernel kernel = new StandardKernel();
         
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(kernel));
            
            kernel.Bind<IAlbumService>().To<AlbumService>();
            kernel.Bind<IAlbumRepository>().To<AlbumRepository>();
            kernel.Bind<IDbSetWrapper<Album>>().To<DbSetWrapper<Album>>();
            
            kernel.Bind<ISongService>().To<SongService>();
            kernel.Bind<ISongRepository>().To<SongRepository>();
            kernel.Bind<IDbSetWrapper<Song>>().To<DbSetWrapper<Song>>();

            kernel.Bind<ILiteratureService>().To<LiteratureService>();
            kernel.Bind<ILiteratureRepository>().To<LiteratureRepository>();
            kernel.Bind<IDbSetWrapper<Literature>>().To<DbSetWrapper<Literature>>();

            kernel.Bind<IOtherSiteService>().To<OtherSiteService>();
            kernel.Bind<IOtherSiteRepository>().To<OtherSiteRepository>();
            kernel.Bind<IDbSetWrapper<OtherSite>>().To<DbSetWrapper<OtherSite>>();

            kernel
                .Bind<IEntityCache>()
                .ToMethod(context => EntityCache.Instance(SiteConfiguration.DurationMinutes))
                .InSingletonScope();

            kernel.Bind<IEmailService>().To<EmailService>();

            kernel.Bind<IContactService>().To<ContactService>();
            kernel.Bind<IContactRepository>().To<ContactRepository>();
            kernel.Bind<IDbSetWrapper<Contact>>().To<DbSetWrapper<Contact>>();
        }
    }
}