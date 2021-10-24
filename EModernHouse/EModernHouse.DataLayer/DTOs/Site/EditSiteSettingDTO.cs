namespace EModernHouse.DataLayer.DTOs.Site
{
    public class EditSiteSettingDTO : CreateSiteSettingDTO
    {
        public long SiteSettingId { get; set; }
        public string LogoImage { get; set; }
    }
}