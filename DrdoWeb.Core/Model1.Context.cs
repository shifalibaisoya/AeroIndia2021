﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrdoWeb.Core
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gip_defexpo2020testingEntities : DbContext
    {
        public gip_defexpo2020testingEntities()
            : base("name=gip_defexpo2020testingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Exhibitorfeedback> Exhibitorfeedbacks { get; set; }
        public virtual DbSet<learning> learnings { get; set; }
        public virtual DbSet<Lofeedback> Lofeedbacks { get; set; }
        public virtual DbSet<Log4NetLog> Log4NetLog { get; set; }
        public virtual DbSet<Serilog> Serilogs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Admin_Users> tbl_Admin_Users { get; set; }
        public virtual DbSet<tbl_AllotementSpace> tbl_AllotementSpace { get; set; }
        public virtual DbSet<tbl_EmabssyList> tbl_EmabssyList { get; set; }
        public virtual DbSet<tbl_foreigndelegatemettingsetup> tbl_foreigndelegatemettingsetup { get; set; }
        public virtual DbSet<tbl_ForeignDelegateMettingSetupDetails> tbl_ForeignDelegateMettingSetupDetails { get; set; }
        public virtual DbSet<tbl_inner_mst_design> tbl_inner_mst_design { get; set; }
        public virtual DbSet<tbl_LODetails> tbl_LODetails { get; set; }
        public virtual DbSet<tbl_mst_Accomodation> tbl_mst_Accomodation { get; set; }
        public virtual DbSet<tbl_mst_agenda> tbl_mst_agenda { get; set; }
        public virtual DbSet<tbl_mst_AircraftRate> tbl_mst_AircraftRate { get; set; }
        public virtual DbSet<tbl_mst_B2B> tbl_mst_B2B { get; set; }
        public virtual DbSet<tbl_mst_B2BHall> tbl_mst_B2BHall { get; set; }
        public virtual DbSet<tbl_mst_BadgeCategory> tbl_mst_BadgeCategory { get; set; }
        public virtual DbSet<tbl_mst_BusinessVisitor> tbl_mst_BusinessVisitor { get; set; }
        public virtual DbSet<tbl_mst_Category> tbl_mst_Category { get; set; }
        public virtual DbSet<tbl_mst_Company> tbl_mst_Company { get; set; }
        public virtual DbSet<tbl_mst_ConfrenceHall> tbl_mst_ConfrenceHall { get; set; }
        public virtual DbSet<tbl_mst_ContractorBadge> tbl_mst_ContractorBadge { get; set; }
        public virtual DbSet<tbl_mst_ContractorCompany> tbl_mst_ContractorCompany { get; set; }
        public virtual DbSet<tbl_mst_Country> tbl_mst_Country { get; set; }
        public virtual DbSet<tbl_mst_defexpolist_2018> tbl_mst_defexpolist_2018 { get; set; }
        public virtual DbSet<tbl_mst_design> tbl_mst_design { get; set; }
        public virtual DbSet<tbl_mst_Directory> tbl_mst_Directory { get; set; }
        public virtual DbSet<tbl_mst_DiscussionContest> tbl_mst_DiscussionContest { get; set; }
        public virtual DbSet<tbl_mst_Embassy> tbl_mst_Embassy { get; set; }
        public virtual DbSet<tbl_mst_Enquiry> tbl_mst_Enquiry { get; set; }
        public virtual DbSet<tbl_mst_EquipmentOnRent> tbl_mst_EquipmentOnRent { get; set; }
        public virtual DbSet<tbl_mst_exhibitor_Catalouge> tbl_mst_exhibitor_Catalouge { get; set; }
        public virtual DbSet<tbl_mst_ExhibitorPasses> tbl_mst_ExhibitorPasses { get; set; }
        public virtual DbSet<tbl_mst_ExhibitorProduct> tbl_mst_ExhibitorProduct { get; set; }
        public virtual DbSet<tbl_mst_ExRep> tbl_mst_ExRep { get; set; }
        public virtual DbSet<tbl_mst_FAQ> tbl_mst_FAQ { get; set; }
        public virtual DbSet<tbl_mst_Form> tbl_mst_Form { get; set; }
        public virtual DbSet<tbl_mst_FriendsOfDefexpo> tbl_mst_FriendsOfDefexpo { get; set; }
        public virtual DbSet<tbl_mst_Gallery> tbl_mst_Gallery { get; set; }
        public virtual DbSet<tbl_mst_GeneralVisitor> tbl_mst_GeneralVisitor { get; set; }
        public virtual DbSet<tbl_mst_Hall> tbl_mst_Hall { get; set; }
        public virtual DbSet<tbl_mst_HallSize> tbl_mst_HallSize { get; set; }
        public virtual DbSet<tbl_mst_IdentityType> tbl_mst_IdentityType { get; set; }
        public virtual DbSet<tbl_mst_ImageUploader> tbl_mst_ImageUploader { get; set; }
        public virtual DbSet<tbl_mst_InterestArea> tbl_mst_InterestArea { get; set; }
        public virtual DbSet<tbl_mst_LoDetails> tbl_mst_LoDetails { get; set; }
        public virtual DbSet<tbl_mst_mainBusinessCompany> tbl_mst_mainBusinessCompany { get; set; }
        public virtual DbSet<tbl_mst_Media> tbl_mst_Media { get; set; }
        public virtual DbSet<tbl_mst_Media_Images> tbl_mst_Media_Images { get; set; }
        public virtual DbSet<tbl_mst_Menu> tbl_mst_Menu { get; set; }
        public virtual DbSet<tbl_mst_MouEvent> tbl_mst_MouEvent { get; set; }
        public virtual DbSet<tbl_mst_NodalOfficerRegistration> tbl_mst_NodalOfficerRegistration { get; set; }
        public virtual DbSet<tbl_mst_Organization> tbl_mst_Organization { get; set; }
        public virtual DbSet<tbl_mst_PassCategory> tbl_mst_PassCategory { get; set; }
        public virtual DbSet<tbl_mst_paymentRate> tbl_mst_paymentRate { get; set; }
        public virtual DbSet<tbl_mst_PhotoContext> tbl_mst_PhotoContext { get; set; }
        public virtual DbSet<tbl_mst_PowerRate> tbl_mst_PowerRate { get; set; }
        public virtual DbSet<tbl_mst_ProductCategory> tbl_mst_ProductCategory { get; set; }
        public virtual DbSet<tbl_mst_Registrationrate> tbl_mst_Registrationrate { get; set; }
        public virtual DbSet<tbl_mst_RegistrationRGera> tbl_mst_RegistrationRGera { get; set; }
        public virtual DbSet<tbl_mst_RegistrationTestUttam> tbl_mst_RegistrationTestUttam { get; set; }
        public virtual DbSet<tbl_mst_SeminarBooking> tbl_mst_SeminarBooking { get; set; }
        public virtual DbSet<tbl_mst_SeminarRegister> tbl_mst_SeminarRegister { get; set; }
        public virtual DbSet<tbl_mst_SpaceRate> tbl_mst_SpaceRate { get; set; }
        public virtual DbSet<tbl_mst_State> tbl_mst_State { get; set; }
        public virtual DbSet<tbl_mst_sub_subcategory> tbl_mst_sub_subcategory { get; set; }
        public virtual DbSet<tbl_mst_SubCategory> tbl_mst_SubCategory { get; set; }
        public virtual DbSet<tbl_mst_TradeAssociation> tbl_mst_TradeAssociation { get; set; }
        public virtual DbSet<tbl_mst_USDRate> tbl_mst_USDRate { get; set; }
        public virtual DbSet<tbl_mst_User> tbl_mst_User { get; set; }
        public virtual DbSet<tbl_mst_visitorsLogin> tbl_mst_visitorsLogin { get; set; }
        public virtual DbSet<tbl_mst_VisitorTicketCount> tbl_mst_VisitorTicketCount { get; set; }
        public virtual DbSet<tbl_mst_visitror_securekey> tbl_mst_visitror_securekey { get; set; }
        public virtual DbSet<tbl_mst_WebinarRegistration> tbl_mst_WebinarRegistration { get; set; }
        public virtual DbSet<tbl_mst_WebsiteUpdated> tbl_mst_WebsiteUpdated { get; set; }
        public virtual DbSet<tbl_SBILog> tbl_SBILog { get; set; }
        public virtual DbSet<tbl_spaceBooking_otp> tbl_spaceBooking_otp { get; set; }
        public virtual DbSet<tbl_trn_AircraftDetail> tbl_trn_AircraftDetail { get; set; }
        public virtual DbSet<tbl_trn_B2BAcceptReq> tbl_trn_B2BAcceptReq { get; set; }
        public virtual DbSet<tbl_trn_EmbassyDiplomats> tbl_trn_EmbassyDiplomats { get; set; }
        public virtual DbSet<tbl_trn_ExhibitDetail> tbl_trn_ExhibitDetail { get; set; }
        public virtual DbSet<tbl_trn_hallotp> tbl_trn_hallotp { get; set; }
        public virtual DbSet<tbl_trn_InaugralDinner> tbl_trn_InaugralDinner { get; set; }
        public virtual DbSet<tbl_trn_LoFeedback_form> tbl_trn_LoFeedback_form { get; set; }
        public virtual DbSet<tbl_trn_OTP> tbl_trn_OTP { get; set; }
        public virtual DbSet<tbl_trn_PassStatus> tbl_trn_PassStatus { get; set; }
        public virtual DbSet<tbl_trn_Payment> tbl_trn_Payment { get; set; }
        public virtual DbSet<tbl_trn_PowerReq> tbl_trn_PowerReq { get; set; }
        public virtual DbSet<tbl_trn_PullPushPayment> tbl_trn_PullPushPayment { get; set; }
        public virtual DbSet<tbl_trn_SpaceLog> tbl_trn_SpaceLog { get; set; }
        public virtual DbSet<tbl_trn_Subscribe> tbl_trn_Subscribe { get; set; }
        public virtual DbSet<tbl_trn_WeaponDisp> tbl_trn_WeaponDisp { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }
        public virtual DbSet<vw_PassStatus> vw_PassStatus { get; set; }
    }
}
