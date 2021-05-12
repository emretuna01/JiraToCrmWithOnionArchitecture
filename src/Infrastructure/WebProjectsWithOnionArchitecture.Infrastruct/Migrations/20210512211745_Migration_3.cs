using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Migrations
{
    public partial class Migration_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.RenameColumn(
                name: "OrganizationId",
                table: "CrmUser",
                newName: "organizationid");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "CrmUser",
                newName: "yomimiddlename");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CrmUser",
                newName: "yomilastname");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "CrmUser",
                newName: "yomifullname");

            migrationBuilder.RenameColumn(
                name: "OdataContext",
                table: "CrmUser",
                newName: "yomifirstname");

            migrationBuilder.RenameColumn(
                name: "BusinessUnitId",
                table: "CrmUser",
                newName: "yammeruserid");

            migrationBuilder.AddColumn<string>(
                name: "OdataEtag",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_businessunitid_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_calendarid_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_createdby_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_createdonbehalfby_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_defaultmailbox_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_mobileofflineprofileid_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_modifiedby_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_modifiedonbehalfby_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_2onayc_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_btsorumlusu_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_doumyeri_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_gm1_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_gm2_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_idari_islersorumlusu_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_ksorumlusu_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_kurumsal_sorumlusu_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_lgilicoo_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_lgiligmy_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_muhasebesorumlusu_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_sekreteryasorumlusu_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_new_takmyneticisi_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_parentsystemuserid_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_positionid_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_queueid_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_siteid_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_territoryid_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_transactioncurrencyid_value",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "accessmode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "address1_addressid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "address1_addresstypecode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "address1_city",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_composite",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_country",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_county",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_fax",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_latitude",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_line1",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_line2",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_line3",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_longitude",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_name",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_postalcode",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_postofficebox",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "address1_shippingmethodcode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "address1_stateorprovince",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_telephone1",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_telephone2",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_telephone3",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_upszone",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address1_utcoffset",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_addressid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "address2_addresstypecode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "address2_city",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_composite",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_country",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_county",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_fax",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_latitude",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_line1",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_line2",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_line3",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_longitude",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_name",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_postalcode",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_postofficebox",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "address2_shippingmethodcode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "address2_stateorprovince",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_telephone1",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_telephone2",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_telephone3",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_upszone",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2_utcoffset",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "applicationid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "applicationiduri",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "azureactivedirectorystringid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "caltype",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "CrmUser",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "defaultfilterspopulated",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "defaultodbfoldername",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "disabledreason",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "displayinserviceviews",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "domainname",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "emailrouteraccessapproval",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "employeeid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "entityimage",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "entityimage_timestamp",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "entityimage_url",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "entityimageid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "exchangerate",
                table: "CrmUser",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstname",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fullname",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "governmentid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "homephone",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "importsequencenumber",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "incomingemaildeliverymethod",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "internalemailaddress",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "invitestatuscode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isdisabled",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isemailaddressapprovedbyo365admin",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isintegrationuser",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "islicensed",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "issyncwithdirectory",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "jobtitle",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "middlename",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mobilealertemail",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mobilephone",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedon",
                table: "CrmUser",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "new_acildurumdaulalacakkii",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "new_bakiyefark",
                table: "CrmUser",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_bordroadsoyad",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_ceptelefonuzel",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "new_dogumgunu",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "new_gendercode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "new_ise_giris_tarihi",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "new_isten_cikis_tarihi",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_jobtitleeng",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "new_kalanbakiye",
                table: "CrmUser",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "new_kangrubu",
                table: "CrmUser",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_kullanici_rolu",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_language",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "new_mazeretzni",
                table: "CrmUser",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "new_mezuniyetblm",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_mezuniyetokulu",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_mezuniyetyl",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_ncekiyerleri",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_password",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "new_portalyetkidzeyi",
                table: "CrmUser",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_tecrbesi",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "new_timesheet",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "new_timesheetsre",
                table: "CrmUser",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_timesheettarih",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "new_username",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nickname",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "outgoingemaildeliverymethod",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "overriddencreatedon",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ownerid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "passporthi",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "passportlo",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "personalemailaddress",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "photourl",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "preferredaddresscode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "preferredemailcode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "preferredphonecode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "processid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "salutation",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "setupuser",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sharepointemailaddress",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "skills",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "stageid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "systemuserid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "timezoneruleversionnumber",
                table: "CrmUser",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "traversedpath",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userlicensetype",
                table: "CrmUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "utcconversiontimezonecode",
                table: "CrmUser",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "versionnumber",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "windowsliveid",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "yammeremailaddress",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OdataEtag",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_businessunitid_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_calendarid_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_createdby_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_createdonbehalfby_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_defaultmailbox_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_mobileofflineprofileid_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_modifiedby_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_modifiedonbehalfby_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_2onayc_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_btsorumlusu_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_doumyeri_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_gm1_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_gm2_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_idari_islersorumlusu_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_ksorumlusu_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_kurumsal_sorumlusu_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_lgilicoo_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_lgiligmy_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_muhasebesorumlusu_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_sekreteryasorumlusu_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_new_takmyneticisi_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_parentsystemuserid_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_positionid_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_queueid_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_siteid_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_territoryid_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "_transactioncurrencyid_value",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "accessmode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_addressid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_addresstypecode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_city",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_composite",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_country",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_county",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_fax",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_latitude",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_line1",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_line2",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_line3",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_longitude",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_name",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_postalcode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_postofficebox",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_shippingmethodcode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_stateorprovince",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_telephone1",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_telephone2",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_telephone3",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_upszone",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address1_utcoffset",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_addressid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_addresstypecode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_city",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_composite",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_country",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_county",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_fax",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_latitude",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_line1",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_line2",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_line3",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_longitude",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_name",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_postalcode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_postofficebox",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_shippingmethodcode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_stateorprovince",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_telephone1",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_telephone2",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_telephone3",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_upszone",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "address2_utcoffset",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "applicationid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "applicationiduri",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "azureactivedirectorystringid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "caltype",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "createdon",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "defaultfilterspopulated",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "defaultodbfoldername",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "disabledreason",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "displayinserviceviews",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "domainname",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "emailrouteraccessapproval",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "employeeid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "entityimage",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "entityimage_timestamp",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "entityimage_url",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "entityimageid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "exchangerate",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "firstname",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "fullname",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "governmentid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "homephone",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "importsequencenumber",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "incomingemaildeliverymethod",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "internalemailaddress",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "invitestatuscode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "isdisabled",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "isemailaddressapprovedbyo365admin",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "isintegrationuser",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "islicensed",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "issyncwithdirectory",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "jobtitle",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "lastname",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "middlename",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "mobilealertemail",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "mobilephone",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "modifiedon",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_acildurumdaulalacakkii",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_bakiyefark",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_bordroadsoyad",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_ceptelefonuzel",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_dogumgunu",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_gendercode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_ise_giris_tarihi",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_isten_cikis_tarihi",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_jobtitleeng",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_kalanbakiye",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_kangrubu",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_kullanici_rolu",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_language",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_mazeretzni",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_mezuniyetblm",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_mezuniyetokulu",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_mezuniyetyl",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_ncekiyerleri",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_password",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_portalyetkidzeyi",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_tecrbesi",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_timesheet",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_timesheetsre",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_timesheettarih",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "new_username",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "nickname",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "outgoingemaildeliverymethod",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "overriddencreatedon",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "ownerid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "passporthi",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "passportlo",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "personalemailaddress",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "photourl",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "preferredaddresscode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "preferredemailcode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "preferredphonecode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "processid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "salutation",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "setupuser",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "sharepointemailaddress",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "skills",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "stageid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "systemuserid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "timezoneruleversionnumber",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "title",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "traversedpath",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "userlicensetype",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "utcconversiontimezonecode",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "versionnumber",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "windowsliveid",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "yammeremailaddress",
                table: "CrmUser");

            migrationBuilder.RenameColumn(
                name: "organizationid",
                table: "CrmUser",
                newName: "OrganizationId");

            migrationBuilder.RenameColumn(
                name: "yomimiddlename",
                table: "CrmUser",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "yomilastname",
                table: "CrmUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "yomifullname",
                table: "CrmUser",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "yomifirstname",
                table: "CrmUser",
                newName: "OdataContext");

            migrationBuilder.RenameColumn(
                name: "yammeruserid",
                table: "CrmUser",
                newName: "BusinessUnitId");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    CrmUserGuid = table.Column<Guid>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_User_CrmUser_CrmUserGuid",
                        column: x => x.CrmUserGuid,
                        principalTable: "CrmUser",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_CrmUserGuid",
                table: "User",
                column: "CrmUserGuid");
        }
    }
}
