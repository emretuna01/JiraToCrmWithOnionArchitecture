using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Common;

namespace WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities
{

    public class CrmAccountValue : BaseEntity
    {
        public string OdataEtag { get; set; }
        public int? customertypecode { get; set; }
        public int? industrycode { get; set; }
        public int address2_addresstypecode { get; set; }
        public int? new_gncellemearamas { get; set; }
        public bool merged { get; set; }
        public string new_adres { get; set; }
        public DateTime? new_sonaktivitetarihi { get; set; }
        public int territorycode { get; set; }
        public string _new_firmadepartman_value { get; set; }
        public int? new_letiimdili { get; set; }
        public string name { get; set; }
        public int importsequencenumber { get; set; }
        public string _owningbusinessunit_value { get; set; }
        public string _owninguser_value { get; set; }
        public string _primarycontactid_value { get; set; }
        public int? new_frsatkayna { get; set; }
        public DateTime? lastusedincampaign { get; set; }
        public int statecode { get; set; }
        public string _new_lkeid_value { get; set; }
        public bool donotpostalmail { get; set; }
        public string _ownerid_value { get; set; }
        public int accountratingcode { get; set; }
        public string _new_kategori_value { get; set; }
        public string new_cari_kod { get; set; }
        public int preferredcontactmethodcode { get; set; }public string _territoryid_value { get; set; }
        public string _new_ehirid_value { get; set; }
        public string _new_alt_kategori_value { get; set; }
        public string description { get; set; }
        public int customersizecode { get; set; }
        public string _new_sektorid_value { get; set; }
        public bool donotemail { get; set; }
        public DateTime openrevenue_date { get; set; }
        public string _new_ilce_value { get; set; }
        public bool new_belgekonumu { get; set; }
        public string new_lekodu { get; set; }
        public int address2_shippingmethodcode { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public string address1_addressid { get; set; }
        public int address2_freighttermscode { get; set; }
        public int statuscode { get; set; }
        public DateTime createdon { get; set; }
        public string new_verginumaras { get; set; }
        public string address1_stateorprovince { get; set; }
        public DateTime opendeals_date { get; set; }
        public bool donotsendmm { get; set; }
        public bool donotfax { get; set; }
        public string _new_projetakmlar_value { get; set; }
        public bool donotbulkpostalmail { get; set; }
        public string versionnumber { get; set; }
        public DateTime modifiedon { get; set; }
        public string telephone1 { get; set; }
        public bool donotphone { get; set; }
        public string _transactioncurrencyid_value { get; set; }
        public string accountid { get; set; }
        public bool donotbulkemail { get; set; }
        public bool creditonhold { get; set; }
        public double exchangerate { get; set; }
        public string new_cari_unvan { get; set; }
        public string _modifiedby_value { get; set; }
        public int businesstypecode { get; set; }
        public string _createdby_value { get; set; }
        public string new_id { get; set; }
        public int ownershipcode { get; set; }
        public bool? new_slavarm { get; set; }
        public string _modifiedonbehalfby_value { get; set; }
        public bool participatesinworkflow { get; set; }
        public int? new_etkinlisanskartisayisi { get; set; }
        public int accountclassificationcode { get; set; }
        public string address2_addressid { get; set; }
        public string _new_mteritemsilcisiid_value { get; set; }
        public string new_vergidairesi { get; set; }
        public DateTime? new_gncellemearamatarihi { get; set; }
        public string new_beldekodu { get; set; }
        public string address1_composite { get; set; }
        public string openrevenue_state { get; set; }
        public string address1_freighttermscode { get; set; }
        public string telephone3 { get; set; }
        public string shippingmethodcode { get; set; }
        public bool? new_gncellemearamasyapld { get; set; }
        public string address1_longitude { get; set; }
        public string opendeals_state { get; set; }
        public string address1_country { get; set; }
        public string _originatingleadid_value { get; set; }
        public bool? new_kontroledildi { get; set; }
        public string creditlimit_base { get; set; }
        public string websiteurl { get; set; }
        public string address1_postofficebox { get; set; }
        public string preferredappointmenttimecode { get; set; }
        public string timespentbymeonemailandmeetings { get; set; }
        public string address2_name { get; set; }
        public string address2_upszone { get; set; }
        public string primarysatoriid { get; set; }
        public string entityimage_url { get; set; }
        public string emailaddress2 { get; set; }
        public string new_sozlesme_bitis_tarihi { get; set; }
        public string address2_line1 { get; set; }
        public string _slaid_value { get; set; }
        public string address2_city { get; set; }
        public string address1_upszone { get; set; }
        public string stockexchange { get; set; }
        public string entityimage { get; set; }
        public string _preferredserviceid_value { get; set; }
        public string _masterid_value { get; set; }
        public string address2_latitude { get; set; }
        public string address2_utcoffset { get; set; }
        public string marketcap_base { get; set; }
        public int? new_durum { get; set; }
        public string telephone2 { get; set; }
        public string paymenttermscode { get; set; }
        public string address1_line1 { get; set; }
        public string _modifiedbyexternalparty_value { get; set; }
        public string entityimageid { get; set; }
        public string new_randevu_sure { get; set; }
        public string fax { get; set; }
        public string stageid { get; set; }
        public string utcconversiontimezonecode { get; set; }
        public string onholdtime { get; set; }
        public string address1_primarycontactname { get; set; }
        public string yominame { get; set; }
        public string _defaultpricelevelid_value { get; set; }
        public string new_le { get; set; }
        public string address2_telephone2 { get; set; }
        public string address2_composite { get; set; }
        public string address2_line3 { get; set; }
        public string _createdonbehalfby_value { get; set; }
        public string _createdbyexternalparty_value { get; set; }
        public string new_letiimdili2 { get; set; }
        public string openrevenue { get; set; }
        public string _new_etkinlikprogramid_value { get; set; }
        public string address1_utcoffset { get; set; }
        public string primarytwitterid { get; set; }
        public string sic { get; set; }
        public string ftpsiteurl { get; set; }
        public string address1_telephone2 { get; set; }
        public string tickersymbol { get; set; }
        public string address1_line2 { get; set; }
        public string numberofemployees { get; set; }
        public string aging60_base { get; set; }
        public string new_sozlesme_baslangic_tarihi { get; set; }
        public string new_yaz_nufusu { get; set; }
        public string revenue_base { get; set; }
        public string openrevenue_base { get; set; }
        public string marketingonly { get; set; }
        public string address2_telephone3 { get; set; }
        public string address1_line3 { get; set; }
        public string address1_latitude { get; set; }
        public string new_gizlilik { get; set; }
        public string address1_telephone1 { get; set; }
        public string accountnumber { get; set; }
        public string entityimage_timestamp { get; set; }
        public string _preferredsystemuserid_value { get; set; }
        public string address2_postalcode { get; set; }
        public string preferredappointmentdaycode { get; set; }
        public string processid { get; set; }
        public string address2_stateorprovince { get; set; }
        public string emailaddress3 { get; set; }
        public string new_verilen_ajanda_adedi { get; set; }
        public string new_firmaportaldzeyi { get; set; }
        public string _slainvokedid_value { get; set; }
        public string aging90 { get; set; }
        public string sharesoutstanding { get; set; }
        public string address1_shippingmethodcode { get; set; }
        public string address2_county { get; set; }
        public string aging60 { get; set; }
        public string marketcap { get; set; }
        public string new_telefon_sure { get; set; }
        public string accountcategorycode { get; set; }
        public string aging30_base { get; set; }
        public string new_mteritemsilcisi { get; set; }
        public string new_kis_nufusu { get; set; }
        public string address1_name { get; set; }
        public string opendeals { get; set; }
        public string overriddencreatedon { get; set; }
        public string aging30 { get; set; }
        public string new_faks2 { get; set; }
        public string address1_addresstypecode { get; set; }
        public string address1_fax { get; set; }
        public string traversedpath { get; set; }
        public string _parentaccountid_value { get; set; }
        public string _new_mahalle_value { get; set; }
        public string new_firmayldnm { get; set; }
        public string emailaddress1 { get; set; }
        public string address2_telephone1 { get; set; }
        public string address1_telephone3 { get; set; }
        public string new_button { get; set; }
        public string aging90_base { get; set; }
        public string new_onayltedariki { get; set; }
        public string address1_postalcode { get; set; }
        public string _preferredequipmentid_value { get; set; }
        public string _owningteam_value { get; set; }
        public string address2_fax { get; set; }
        public string lastonholdtime { get; set; }
        public string creditlimit { get; set; }
        public string new_ajanda_verilme_tarihi { get; set; }
        public string address2_country { get; set; }
        public string followemail { get; set; }
        public string address2_longitude { get; set; }
        public string address1_county { get; set; }
        public string address2_line2 { get; set; }
        public string revenue { get; set; }
        public string address2_primarycontactname { get; set; }
        public string address2_postofficebox { get; set; }
        public string address1_city { get; set; }
    }

    public class CrmAccountRoot :BaseEntity
    {
        public string OdataContext { get; set; }
        public string OdataNextLink { get; set; }
        public List<CrmAccountValue> CrmAccountList { get; set; }
    }



}
