using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Thayloilocnuoc.Models.Mapping;

namespace Thayloilocnuoc.Models
{
    public partial class ThayloilocnuocContext : DbContext
    {
        static ThayloilocnuocContext()
        {
            Database.SetInitializer<ThayloilocnuocContext>(null);
        }

        public ThayloilocnuocContext()
            : base("Name=ThayloilocnuocContext")
        {
        }

        public DbSet<tblAddress> tblAddresses { get; set; }
        public DbSet<tblAgency> tblAgencies { get; set; }
        public DbSet<tblBank> tblBanks { get; set; }
        public DbSet<tblConfig> tblConfigs { get; set; }
        public DbSet<tblConnectCriteria> tblConnectCriterias { get; set; }
        public DbSet<tblConnectImage> tblConnectImages { get; set; }
        public DbSet<tblConnectLoiloc> tblConnectLoilocs { get; set; }
        public DbSet<tblConnectManuProduct> tblConnectManuProducts { get; set; }
        public DbSet<tblConnectNew> tblConnectNews { get; set; }
        public DbSet<tblConnectWeb> tblConnectWebs { get; set; }
        public DbSet<tblContact> tblContacts { get; set; }
        public DbSet<tblCountOnline> tblCountOnlines { get; set; }
        public DbSet<tblCriteria> tblCriterias { get; set; }
        public DbSet<tblGroupAddress> tblGroupAddresses { get; set; }
        public DbSet<tblGroupAgency> tblGroupAgencies { get; set; }
        public DbSet<tblGroupCriteria> tblGroupCriterias { get; set; }
        public DbSet<tblGroupImage> tblGroupImages { get; set; }
        public DbSet<tblGroupNew> tblGroupNews { get; set; }
        public DbSet<tblGroupProduct> tblGroupProducts { get; set; }
        public DbSet<tblHistoryLogin> tblHistoryLogins { get; set; }
        public DbSet<tblHotline> tblHotlines { get; set; }
        public DbSet<tblImage> tblImages { get; set; }
        public DbSet<tblImageProduct> tblImageProducts { get; set; }
        public DbSet<tblInfoCriteria> tblInfoCriterias { get; set; }
        public DbSet<tblLoiloc> tblLoilocs { get; set; }
        public DbSet<tblManufacture> tblManufactures { get; set; }
        public DbSet<tblMap> tblMaps { get; set; }
        public DbSet<tblModule> tblModules { get; set; }
        public DbSet<tblNew> tblNews { get; set; }
        public DbSet<tblOrder> tblOrders { get; set; }
        public DbSet<tblOrderDetail> tblOrderDetails { get; set; }
        public DbSet<tblPartner> tblPartners { get; set; }
        public DbSet<tblProduct> tblProducts { get; set; }
        public DbSet<tblProductTag> tblProductTags { get; set; }
        public DbSet<tblRegister> tblRegisters { get; set; }
        public DbSet<tblRight> tblRights { get; set; }
        public DbSet<tblSupport> tblSupports { get; set; }
        public DbSet<tblUrl> tblUrls { get; set; }
        public DbSet<tblUser> tblUsers { get; set; }
        public DbSet<tblVideo> tblVideos { get; set; }
        public DbSet<tblWeb> tblWebs { get; set; }
        public DbSet<HistoryView> HistoryViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new tblAddressMap());
            modelBuilder.Configurations.Add(new tblAgencyMap());
            modelBuilder.Configurations.Add(new tblBankMap());
            modelBuilder.Configurations.Add(new tblConfigMap());
            modelBuilder.Configurations.Add(new tblConnectCriteriaMap());
            modelBuilder.Configurations.Add(new tblConnectImageMap());
            modelBuilder.Configurations.Add(new tblConnectLoilocMap());
            modelBuilder.Configurations.Add(new tblConnectManuProductMap());
            modelBuilder.Configurations.Add(new tblConnectNewMap());
            modelBuilder.Configurations.Add(new tblConnectWebMap());
            modelBuilder.Configurations.Add(new tblContactMap());
            modelBuilder.Configurations.Add(new tblCountOnlineMap());
            modelBuilder.Configurations.Add(new tblCriteriaMap());
            modelBuilder.Configurations.Add(new tblGroupAddressMap());
            modelBuilder.Configurations.Add(new tblGroupAgencyMap());
            modelBuilder.Configurations.Add(new tblGroupCriteriaMap());
            modelBuilder.Configurations.Add(new tblGroupImageMap());
            modelBuilder.Configurations.Add(new tblGroupNewMap());
            modelBuilder.Configurations.Add(new tblGroupProductMap());
            modelBuilder.Configurations.Add(new tblHistoryLoginMap());
            modelBuilder.Configurations.Add(new tblHotlineMap());
            modelBuilder.Configurations.Add(new tblImageMap());
            modelBuilder.Configurations.Add(new tblImageProductMap());
            modelBuilder.Configurations.Add(new tblInfoCriteriaMap());
            modelBuilder.Configurations.Add(new tblLoilocMap());
            modelBuilder.Configurations.Add(new tblManufactureMap());
            modelBuilder.Configurations.Add(new tblMapMap());
            modelBuilder.Configurations.Add(new tblModuleMap());
            modelBuilder.Configurations.Add(new tblNewMap());
            modelBuilder.Configurations.Add(new tblOrderMap());
            modelBuilder.Configurations.Add(new tblOrderDetailMap());
            modelBuilder.Configurations.Add(new tblPartnerMap());
            modelBuilder.Configurations.Add(new tblProductMap());
            modelBuilder.Configurations.Add(new tblProductTagMap());
            modelBuilder.Configurations.Add(new tblRegisterMap());
            modelBuilder.Configurations.Add(new tblRightMap());
            modelBuilder.Configurations.Add(new tblSupportMap());
            modelBuilder.Configurations.Add(new tblUrlMap());
            modelBuilder.Configurations.Add(new tblUserMap());
            modelBuilder.Configurations.Add(new tblVideoMap());
            modelBuilder.Configurations.Add(new tblWebMap());
            modelBuilder.Configurations.Add(new HistoryViewMap());
        }
    }
}
