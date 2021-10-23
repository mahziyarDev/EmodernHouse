using System.Collections.Generic;
using EModernHouse.DataLayer.Entities.Site;

namespace EModernHouse.DataLayer.DTOs.Filter
{
    public class siteSettingFilterDTO : BasePaging  
    {
        public List<SiteSetting> SiteSettings { get; set; }
        public string Name { get; set; }
    }
}