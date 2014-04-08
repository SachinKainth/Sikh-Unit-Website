using System;
using System.Collections.Generic;
using System.Net;
using NUnit.Framework;
using SikhUnit.Cache;
using SikhUnit.Configuration;
using SikhUnit.DataAccess.Context;
using SikhUnit.DataAccess.Core;
using SikhUnit.DataAccess.Repository;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Service;

namespace SikhUnit.BusinessLogic.IntegrationTests
{
    [TestFixture]
    class OtherSiteServiceTests
    {
        [Test]
        public void GetAllOtherSites__AllCorrectOtherSiteURLs()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var otherSiteContext = new DatabaseContext();
            IOtherSiteService otherSiteService = 
                new OtherSiteService(
                    new OtherSiteRepository(otherSiteContext, new DbSetWrapper<OtherSite>(otherSiteContext), cache));

            List<OtherSite> otherSites = otherSiteService.GetAllOtherSites();

            foreach (var otherSite in otherSites)
            {
                using (var client = new HeadOnlyWebClient())
                {
                    client.HeadOnly = true;

                    try
                    {
                        client.DownloadString(otherSite.Url);
                        Assert.Pass();
                    }
                    catch (WebException e)
                    {
                        Assert.Fail("Url {0} is not working.", otherSite.Url);
                    }
                }
            }
        }
    }

    class HeadOnlyWebClient : WebClient
    {
        public bool HeadOnly { get; set; }
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest req = base.GetWebRequest(address);
            if (HeadOnly && req.Method == "GET")
            {
                req.Method = "HEAD";
            }
            return req;
        }
    }
}