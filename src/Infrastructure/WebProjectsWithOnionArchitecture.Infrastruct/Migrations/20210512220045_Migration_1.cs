using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Migrations
{
    public partial class Migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrmAccounts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    OdataEtag = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Statecode = table.Column<int>(type: "INTEGER", nullable: false),
                    Accountid = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmAccounts", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "CrmTasks",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    RegardingObjectidSalesOrderOdataBind = table.Column<string>(type: "TEXT", nullable: true),
                    Scheduledend = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    categoryOfTask = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmTasks", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "CrmUsers",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    OdataEtag = table.Column<string>(type: "TEXT", nullable: true),
                    homephone = table.Column<string>(type: "TEXT", nullable: true),
                    address2_addresstypecode = table.Column<int>(type: "INTEGER", nullable: false),
                    islicensed = table.Column<bool>(type: "INTEGER", nullable: false),
                    accessmode = table.Column<int>(type: "INTEGER", nullable: false),
                    _new_muhasebesorumlusu_value = table.Column<string>(type: "TEXT", nullable: true),
                    systemuserid = table.Column<string>(type: "TEXT", nullable: true),
                    issyncwithdirectory = table.Column<bool>(type: "INTEGER", nullable: false),
                    address2_shippingmethodcode = table.Column<int>(type: "INTEGER", nullable: false),
                    title = table.Column<string>(type: "TEXT", nullable: true),
                    address1_telephone1 = table.Column<string>(type: "TEXT", nullable: true),
                    domainname = table.Column<string>(type: "TEXT", nullable: true),
                    modifiedon = table.Column<DateTime>(type: "TEXT", nullable: false),
                    preferredaddresscode = table.Column<int>(type: "INTEGER", nullable: false),
                    displayinserviceviews = table.Column<bool>(type: "INTEGER", nullable: false),
                    defaultfilterspopulated = table.Column<bool>(type: "INTEGER", nullable: false),
                    _new_sekreteryasorumlusu_value = table.Column<string>(type: "TEXT", nullable: true),
                    address1_shippingmethodcode = table.Column<int>(type: "INTEGER", nullable: false),
                    preferredemailcode = table.Column<int>(type: "INTEGER", nullable: false),
                    lastname = table.Column<string>(type: "TEXT", nullable: true),
                    new_username = table.Column<string>(type: "TEXT", nullable: true),
                    new_portalyetkidzeyi = table.Column<int>(type: "INTEGER", nullable: true),
                    caltype = table.Column<int>(type: "INTEGER", nullable: false),
                    _new_ksorumlusu_value = table.Column<string>(type: "TEXT", nullable: true),
                    _calendarid_value = table.Column<string>(type: "TEXT", nullable: true),
                    firstname = table.Column<string>(type: "TEXT", nullable: true),
                    userlicensetype = table.Column<int>(type: "INTEGER", nullable: false),
                    new_kalanbakiye = table.Column<double>(type: "REAL", nullable: true),
                    _new_btsorumlusu_value = table.Column<string>(type: "TEXT", nullable: true),
                    yomifullname = table.Column<string>(type: "TEXT", nullable: true),
                    _businessunitid_value = table.Column<string>(type: "TEXT", nullable: true),
                    incomingemaildeliverymethod = table.Column<int>(type: "INTEGER", nullable: false),
                    middlename = table.Column<string>(type: "TEXT", nullable: true),
                    setupuser = table.Column<bool>(type: "INTEGER", nullable: false),
                    _new_takmyneticisi_value = table.Column<string>(type: "TEXT", nullable: true),
                    timezoneruleversionnumber = table.Column<int>(type: "INTEGER", nullable: true),
                    address1_addressid = table.Column<string>(type: "TEXT", nullable: true),
                    new_mazeretzni = table.Column<double>(type: "REAL", nullable: false),
                    createdon = table.Column<DateTime>(type: "TEXT", nullable: false),
                    address1_stateorprovince = table.Column<string>(type: "TEXT", nullable: true),
                    organizationid = table.Column<string>(type: "TEXT", nullable: true),
                    _new_kurumsal_sorumlusu_value = table.Column<string>(type: "TEXT", nullable: true),
                    defaultodbfoldername = table.Column<string>(type: "TEXT", nullable: true),
                    jobtitle = table.Column<string>(type: "TEXT", nullable: true),
                    _defaultmailbox_value = table.Column<string>(type: "TEXT", nullable: true),
                    new_bordroadsoyad = table.Column<string>(type: "TEXT", nullable: true),
                    outgoingemaildeliverymethod = table.Column<int>(type: "INTEGER", nullable: false),
                    versionnumber = table.Column<string>(type: "TEXT", nullable: true),
                    address1_line1 = table.Column<string>(type: "TEXT", nullable: true),
                    _new_lgilicoo_value = table.Column<string>(type: "TEXT", nullable: true),
                    _territoryid_value = table.Column<string>(type: "TEXT", nullable: true),
                    isintegrationuser = table.Column<bool>(type: "INTEGER", nullable: false),
                    utcconversiontimezonecode = table.Column<int>(type: "INTEGER", nullable: true),
                    address1_addresstypecode = table.Column<int>(type: "INTEGER", nullable: false),
                    new_timesheet = table.Column<bool>(type: "INTEGER", nullable: false),
                    _modifiedby_value = table.Column<string>(type: "TEXT", nullable: true),
                    new_ise_giris_tarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    _createdby_value = table.Column<string>(type: "TEXT", nullable: true),
                    address1_city = table.Column<string>(type: "TEXT", nullable: true),
                    preferredphonecode = table.Column<int>(type: "INTEGER", nullable: false),
                    new_timesheetsre = table.Column<int>(type: "INTEGER", nullable: true),
                    fullname = table.Column<string>(type: "TEXT", nullable: true),
                    _new_lgiligmy_value = table.Column<string>(type: "TEXT", nullable: true),
                    new_dogumgunu = table.Column<DateTime>(type: "TEXT", nullable: true),
                    invitestatuscode = table.Column<int>(type: "INTEGER", nullable: false),
                    isdisabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    address2_addressid = table.Column<string>(type: "TEXT", nullable: true),
                    emailrouteraccessapproval = table.Column<int>(type: "INTEGER", nullable: false),
                    address1_postalcode = table.Column<string>(type: "TEXT", nullable: true),
                    internalemailaddress = table.Column<string>(type: "TEXT", nullable: true),
                    _parentsystemuserid_value = table.Column<string>(type: "TEXT", nullable: true),
                    new_mezuniyetokulu = table.Column<string>(type: "TEXT", nullable: true),
                    isemailaddressapprovedbyo365admin = table.Column<bool>(type: "INTEGER", nullable: false),
                    _queueid_value = table.Column<string>(type: "TEXT", nullable: true),
                    _new_idari_islersorumlusu_value = table.Column<string>(type: "TEXT", nullable: true),
                    address1_composite = table.Column<string>(type: "TEXT", nullable: true),
                    ownerid = table.Column<string>(type: "TEXT", nullable: true),
                    nickname = table.Column<string>(type: "TEXT", nullable: true),
                    azureactivedirectorystringid = table.Column<string>(type: "TEXT", nullable: true),
                    address2_stateorprovince = table.Column<string>(type: "TEXT", nullable: true),
                    applicationiduri = table.Column<string>(type: "TEXT", nullable: true),
                    address1_county = table.Column<string>(type: "TEXT", nullable: true),
                    address2_country = table.Column<string>(type: "TEXT", nullable: true),
                    address2_postofficebox = table.Column<string>(type: "TEXT", nullable: true),
                    yammeruserid = table.Column<string>(type: "TEXT", nullable: true),
                    new_gendercode = table.Column<int>(type: "INTEGER", nullable: true),
                    new_language = table.Column<string>(type: "TEXT", nullable: true),
                    employeeid = table.Column<string>(type: "TEXT", nullable: true),
                    new_kangrubu = table.Column<int>(type: "INTEGER", nullable: true),
                    new_mezuniyetblm = table.Column<string>(type: "TEXT", nullable: true),
                    skills = table.Column<string>(type: "TEXT", nullable: true),
                    address2_composite = table.Column<string>(type: "TEXT", nullable: true),
                    entityimage = table.Column<string>(type: "TEXT", nullable: true),
                    windowsliveid = table.Column<string>(type: "TEXT", nullable: true),
                    address1_line3 = table.Column<string>(type: "TEXT", nullable: true),
                    disabledreason = table.Column<string>(type: "TEXT", nullable: true),
                    address2_utcoffset = table.Column<string>(type: "TEXT", nullable: true),
                    address1_line2 = table.Column<string>(type: "TEXT", nullable: true),
                    personalemailaddress = table.Column<string>(type: "TEXT", nullable: true),
                    address1_telephone2 = table.Column<string>(type: "TEXT", nullable: true),
                    _createdonbehalfby_value = table.Column<string>(type: "TEXT", nullable: true),
                    _new_gm2_value = table.Column<string>(type: "TEXT", nullable: true),
                    sharepointemailaddress = table.Column<string>(type: "TEXT", nullable: true),
                    yomifirstname = table.Column<string>(type: "TEXT", nullable: true),
                    exchangerate = table.Column<double>(type: "REAL", nullable: true),
                    yomimiddlename = table.Column<string>(type: "TEXT", nullable: true),
                    address2_line2 = table.Column<string>(type: "TEXT", nullable: true),
                    traversedpath = table.Column<string>(type: "TEXT", nullable: true),
                    _new_2onayc_value = table.Column<string>(type: "TEXT", nullable: true),
                    address1_country = table.Column<string>(type: "TEXT", nullable: true),
                    yomilastname = table.Column<string>(type: "TEXT", nullable: true),
                    address2_latitude = table.Column<string>(type: "TEXT", nullable: true),
                    address1_longitude = table.Column<string>(type: "TEXT", nullable: true),
                    address2_fax = table.Column<string>(type: "TEXT", nullable: true),
                    _new_gm1_value = table.Column<string>(type: "TEXT", nullable: true),
                    new_timesheettarih = table.Column<string>(type: "TEXT", nullable: true),
                    address1_latitude = table.Column<string>(type: "TEXT", nullable: true),
                    entityimage_timestamp = table.Column<string>(type: "TEXT", nullable: true),
                    new_isten_cikis_tarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    mobilephone = table.Column<string>(type: "TEXT", nullable: true),
                    photourl = table.Column<string>(type: "TEXT", nullable: true),
                    _siteid_value = table.Column<string>(type: "TEXT", nullable: true),
                    _transactioncurrencyid_value = table.Column<string>(type: "TEXT", nullable: true),
                    new_password = table.Column<string>(type: "TEXT", nullable: true),
                    new_tecrbesi = table.Column<string>(type: "TEXT", nullable: true),
                    passportlo = table.Column<string>(type: "TEXT", nullable: true),
                    _mobileofflineprofileid_value = table.Column<string>(type: "TEXT", nullable: true),
                    address1_name = table.Column<string>(type: "TEXT", nullable: true),
                    address2_telephone2 = table.Column<string>(type: "TEXT", nullable: true),
                    new_acildurumdaulalacakkii = table.Column<string>(type: "TEXT", nullable: true),
                    stageid = table.Column<string>(type: "TEXT", nullable: true),
                    address2_longitude = table.Column<string>(type: "TEXT", nullable: true),
                    salutation = table.Column<string>(type: "TEXT", nullable: true),
                    yammeremailaddress = table.Column<string>(type: "TEXT", nullable: true),
                    address2_city = table.Column<string>(type: "TEXT", nullable: true),
                    entityimageid = table.Column<string>(type: "TEXT", nullable: true),
                    address2_county = table.Column<string>(type: "TEXT", nullable: true),
                    address2_line1 = table.Column<string>(type: "TEXT", nullable: true),
                    address2_upszone = table.Column<string>(type: "TEXT", nullable: true),
                    address1_utcoffset = table.Column<string>(type: "TEXT", nullable: true),
                    _positionid_value = table.Column<string>(type: "TEXT", nullable: true),
                    passporthi = table.Column<string>(type: "TEXT", nullable: true),
                    address1_telephone3 = table.Column<string>(type: "TEXT", nullable: true),
                    _new_doumyeri_value = table.Column<string>(type: "TEXT", nullable: true),
                    address2_postalcode = table.Column<string>(type: "TEXT", nullable: true),
                    address2_telephone1 = table.Column<string>(type: "TEXT", nullable: true),
                    entityimage_url = table.Column<string>(type: "TEXT", nullable: true),
                    processid = table.Column<string>(type: "TEXT", nullable: true),
                    governmentid = table.Column<string>(type: "TEXT", nullable: true),
                    _modifiedonbehalfby_value = table.Column<string>(type: "TEXT", nullable: true),
                    new_jobtitleeng = table.Column<string>(type: "TEXT", nullable: true),
                    address2_line3 = table.Column<string>(type: "TEXT", nullable: true),
                    address2_name = table.Column<string>(type: "TEXT", nullable: true),
                    overriddencreatedon = table.Column<string>(type: "TEXT", nullable: true),
                    address1_upszone = table.Column<string>(type: "TEXT", nullable: true),
                    importsequencenumber = table.Column<string>(type: "TEXT", nullable: true),
                    mobilealertemail = table.Column<string>(type: "TEXT", nullable: true),
                    new_ceptelefonuzel = table.Column<string>(type: "TEXT", nullable: true),
                    address1_fax = table.Column<string>(type: "TEXT", nullable: true),
                    new_kullanici_rolu = table.Column<string>(type: "TEXT", nullable: true),
                    address2_telephone3 = table.Column<string>(type: "TEXT", nullable: true),
                    address1_postofficebox = table.Column<string>(type: "TEXT", nullable: true),
                    new_mezuniyetyl = table.Column<string>(type: "TEXT", nullable: true),
                    new_bakiyefark = table.Column<double>(type: "REAL", nullable: true),
                    new_ncekiyerleri = table.Column<string>(type: "TEXT", nullable: true),
                    applicationid = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmUsers", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    RegisterDateTime = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValueSql: "datetime('now','localtime')"),
                    LastLoginDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: true,defaultValue:true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Guid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrmAccounts");

            migrationBuilder.DropTable(
                name: "CrmTasks");

            migrationBuilder.DropTable(
                name: "CrmUsers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
