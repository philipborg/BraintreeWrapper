// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\CustomerData\CustomerDataPage.json"
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using st=Starcounter.Templates;
using s=Starcounter;
using _GEN1_=System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_=System.CodeDom.Compiler.GeneratedCodeAttribute;
using _ScTemplate_=Starcounter.Templates.Template;
#pragma warning disable 0108
#pragma warning disable 1591

using __CuCustomer__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerJson;
using __CuCustomer2__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerJson.Input;
using __CCuFirstNam__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerJson.Input.FirstName;
using __CCuLastName__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerJson.Input.LastName;
using __CCuPhone__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerJson.Input.Phone;
using __CCuEmail__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerJson.Input.Email;
using __CCuFax__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerJson.Input.Fax;
using __CuCompanyJ__ = global::BrainTreePaymentMethod.CustomerDataPage.CompanyJson;
using __CuCompanyJ1__ = global::BrainTreePaymentMethod.CustomerDataPage.CompanyJson.JsonByExample;
using __CuCompanyJ2__ = global::BrainTreePaymentMethod.CustomerDataPage.CompanyJson.Input;
using __CCoCompanyN__ = global::BrainTreePaymentMethod.CustomerDataPage.CompanyJson.Input.CompanyName;
using __CuCreditCa__ = global::BrainTreePaymentMethod.CustomerDataPage.CreditCardJson;
using __CuCreditCa1__ = global::BrainTreePaymentMethod.CustomerDataPage.CreditCardJson.JsonByExample;
using __CuCreditCa2__ = global::BrainTreePaymentMethod.CustomerDataPage.CreditCardJson.Input;
using __CCrCardNumb__ = global::BrainTreePaymentMethod.CustomerDataPage.CreditCardJson.Input.CardNumber;
using __CCrExpiryMo__ = global::BrainTreePaymentMethod.CustomerDataPage.CreditCardJson.Input.ExpiryMonth;
using __CCrExpiryYe__ = global::BrainTreePaymentMethod.CustomerDataPage.CreditCardJson.Input.ExpiryYear;
using __CCrSecurity__ = global::BrainTreePaymentMethod.CustomerDataPage.CreditCardJson.Input.SecurityNumber;
using __CuCustomer3__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson;
using __CuCustomer4__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.JsonByExample;
using __CuCustomer5__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.Input;
using __CCuFirstNam1__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.Input.FirstNameName;
using __CCuLastName1__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.Input.LastNameName;
using __CCuEmailNam__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.Input.EmailName;
using __CCuAddress1__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.Input.Address1Name;
using __CCuZipPosta__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.Input.ZipPostalCodeName;
using __CCuTownName__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.Input.TownName;
using __CCuStateNam__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.Input.StateName;
using __CCuProvince__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.Input.ProvinceName;
using __Arr__ = global::Starcounter.Arr<global::BrainTreePaymentMethod.CustomerDataPage.ErrorsElementJson>;
using __CuCustomer1__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerJson.JsonByExample;
using __Customer2__ = global::BrainTreePaymentMethod.CustomerDataPage.Input;
using __CuHtml__ = global::BrainTreePaymentMethod.CustomerDataPage.Input.Html;
using __CAdCountryC1__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input.CountryCodeAlpha3;
using __Customer__ = global::BrainTreePaymentMethod.CustomerDataPage;
using __CuSchema__ = global::BrainTreePaymentMethod.CustomerDataPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __CAdSchema__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.JsonByExample.Schema;
using __TObject__ = global::Starcounter.Templates.TObject;
using __CCuSchema__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerJson.JsonByExample.Schema;
using __CCoSchema__ = global::BrainTreePaymentMethod.CustomerDataPage.CompanyJson.JsonByExample.Schema;
using __CCrSchema__ = global::BrainTreePaymentMethod.CustomerDataPage.CreditCardJson.JsonByExample.Schema;
using __CCuSchema1__ = global::BrainTreePaymentMethod.CustomerDataPage.CustomerLabelJson.JsonByExample.Schema;
using __CuErrorsEl__ = global::BrainTreePaymentMethod.CustomerDataPage.ErrorsElementJson;
using __Json__ = global::Starcounter.Json;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __CErSchema__ = global::BrainTreePaymentMethod.CustomerDataPage.ErrorsElementJson.JsonByExample.Schema;
using __CAdCountryC2__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input.CountryCodeNumeric;
using __CuErrorsEl1__ = global::BrainTreePaymentMethod.CustomerDataPage.ErrorsElementJson.JsonByExample;
using __CErError__ = global::BrainTreePaymentMethod.CustomerDataPage.ErrorsElementJson.Input.Error;
using __TArray__ = global::Starcounter.Templates.TArray<global::BrainTreePaymentMethod.CustomerDataPage.ErrorsElementJson>;
using __Customer1__ = global::BrainTreePaymentMethod.CustomerDataPage.JsonByExample;
using __CuAddressJ__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson;
using __CuAddressJ1__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.JsonByExample;
using __CuAddressJ2__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input;
using __CAdStreetAd__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input.StreetAddress;
using __CAdExtended__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input.ExtendedAddress;
using __CAdLocality__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input.Locality;
using __CAdRegion__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input.Region;
using __CAdPostalCo__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input.PostalCode;
using __CAdCountryN__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input.CountryName;
using __CAdCountryC__ = global::BrainTreePaymentMethod.CustomerDataPage.AddressJson.Input.CountryCodeAlpha2;
using __CuErrorsEl2__ = global::BrainTreePaymentMethod.CustomerDataPage.ErrorsElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CustomerDataPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Address : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Customer : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Company : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class CreditCard : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class CustomerLabel : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Errors : s::TemplateAttribute {
    }
    #line default
}
#line default

namespace BrainTreePaymentMethod {

#line hidden
public partial class CustomerDataPage : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CuSchema__ DefaultTemplate = new __CuSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CustomerDataPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CustomerDataPage(__CuSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CuSchema__ Template { get { return (__CuSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Html__;
    private __CuAddressJ__ __bf__Address__;
    private __CuCustomer__ __bf__Customer__;
    private __CuCompanyJ__ __bf__Company__;
    private __CuCreditCa__ __bf__CreditCard__;
    private __CuCustomer3__ __bf__CustomerLabel__;
    private __Arr__ __bf__Errors__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__Customer__);
                ClassName = "CustomerDataPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "";
                Html.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Address = Add<__CAdSchema__>("Address");
                Address.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__Address__ = (__CuAddressJ__)_v_; }, false);
                Customer = Add<__CCuSchema__>("Customer");
                Customer.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__Customer__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__Customer__ = (__CuCustomer__)_v_; }, false);
                Company = Add<__CCoSchema__>("Company");
                Company.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__Company__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__Company__ = (__CuCompanyJ__)_v_; }, false);
                CreditCard = Add<__CCrSchema__>("CreditCard");
                CreditCard.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__CreditCard__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__CreditCard__ = (__CuCreditCa__)_v_; }, false);
                CustomerLabel = Add<__CCuSchema1__>("CustomerLabel");
                CustomerLabel.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__CustomerLabel__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__CustomerLabel__ = (__CuCustomer3__)_v_; }, false);
                Errors = Add<__TArray__>("Errors");
                Errors.SetCustomGetElementType((arr) => { return __CuErrorsEl__.DefaultTemplate;});
                Errors.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__Errors__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__Errors__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Customer__(this) { Parent = parent }; }
            public __TString__ Html;
            public __CAdSchema__ Address;
            public __CCuSchema__ Customer;
            public __CCoSchema__ Company;
            public __CCrSchema__ CreditCard;
            public __CCuSchema1__ CustomerLabel;
            public __TArray__ Errors;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
#line 2 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.Html.Getter(this); }
#line 2 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Html.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __CuAddressJ__ Address {
#line 13 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return (__CuAddressJ__)Template.Address.Getter(this); }
#line 13 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Address.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __CuCustomer__ Customer {
#line 20 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return (__CuCustomer__)Template.Customer.Getter(this); }
#line 20 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Customer.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __CuCompanyJ__ Company {
#line 23 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return (__CuCompanyJ__)Template.Company.Getter(this); }
#line 23 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Company.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __CuCreditCa__ CreditCard {
#line 29 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return (__CuCreditCa__)Template.CreditCard.Getter(this); }
#line 29 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.CreditCard.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __CuCustomer3__ CustomerLabel {
#line 39 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return (__CuCustomer3__)Template.CustomerLabel.Getter(this); }
#line 39 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.CustomerLabel.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Errors {
#line 45 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.Errors.Getter(this); }
#line 45 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Errors.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class AddressJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CAdSchema__ DefaultTemplate = new __CAdSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AddressJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AddressJson(__CAdSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CAdSchema__ Template { get { return (__CAdSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__StreetAddress__;
        private System.String __bf__ExtendedAddress__;
        private System.String __bf__Locality__;
        private System.String __bf__Region__;
        private System.String __bf__PostalCode__;
        private System.String __bf__CountryName__;
        private System.String __bf__CountryCodeAlpha2__;
        private System.String __bf__CountryCodeAlpha3__;
        private System.String __bf__CountryCodeNumeric__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CuAddressJ__);
                    ClassName = "AddressJson";
                    Properties.ClearExposed();
                    StreetAddress = Add<__TString__>("StreetAddress$");
                    StreetAddress.DefaultValue = "";
                    StreetAddress.Editable = true;
                    StreetAddress.SetCustomAccessors((_p_) => { return ((__CuAddressJ__)_p_).__bf__StreetAddress__; }, (_p_, _v_) => { ((__CuAddressJ__)_p_).__bf__StreetAddress__ = (System.String)_v_; }, false);
                    ExtendedAddress = Add<__TString__>("ExtendedAddress$");
                    ExtendedAddress.DefaultValue = "";
                    ExtendedAddress.Editable = true;
                    ExtendedAddress.SetCustomAccessors((_p_) => { return ((__CuAddressJ__)_p_).__bf__ExtendedAddress__; }, (_p_, _v_) => { ((__CuAddressJ__)_p_).__bf__ExtendedAddress__ = (System.String)_v_; }, false);
                    Locality = Add<__TString__>("Locality$");
                    Locality.DefaultValue = "";
                    Locality.Editable = true;
                    Locality.SetCustomAccessors((_p_) => { return ((__CuAddressJ__)_p_).__bf__Locality__; }, (_p_, _v_) => { ((__CuAddressJ__)_p_).__bf__Locality__ = (System.String)_v_; }, false);
                    Region = Add<__TString__>("Region$");
                    Region.DefaultValue = "";
                    Region.Editable = true;
                    Region.SetCustomAccessors((_p_) => { return ((__CuAddressJ__)_p_).__bf__Region__; }, (_p_, _v_) => { ((__CuAddressJ__)_p_).__bf__Region__ = (System.String)_v_; }, false);
                    PostalCode = Add<__TString__>("PostalCode$");
                    PostalCode.DefaultValue = "";
                    PostalCode.Editable = true;
                    PostalCode.SetCustomAccessors((_p_) => { return ((__CuAddressJ__)_p_).__bf__PostalCode__; }, (_p_, _v_) => { ((__CuAddressJ__)_p_).__bf__PostalCode__ = (System.String)_v_; }, false);
                    CountryName = Add<__TString__>("CountryName$");
                    CountryName.DefaultValue = "";
                    CountryName.Editable = true;
                    CountryName.SetCustomAccessors((_p_) => { return ((__CuAddressJ__)_p_).__bf__CountryName__; }, (_p_, _v_) => { ((__CuAddressJ__)_p_).__bf__CountryName__ = (System.String)_v_; }, false);
                    CountryCodeAlpha2 = Add<__TString__>("CountryCodeAlpha2$");
                    CountryCodeAlpha2.DefaultValue = "";
                    CountryCodeAlpha2.Editable = true;
                    CountryCodeAlpha2.SetCustomAccessors((_p_) => { return ((__CuAddressJ__)_p_).__bf__CountryCodeAlpha2__; }, (_p_, _v_) => { ((__CuAddressJ__)_p_).__bf__CountryCodeAlpha2__ = (System.String)_v_; }, false);
                    CountryCodeAlpha3 = Add<__TString__>("CountryCodeAlpha3$");
                    CountryCodeAlpha3.DefaultValue = "";
                    CountryCodeAlpha3.Editable = true;
                    CountryCodeAlpha3.SetCustomAccessors((_p_) => { return ((__CuAddressJ__)_p_).__bf__CountryCodeAlpha3__; }, (_p_, _v_) => { ((__CuAddressJ__)_p_).__bf__CountryCodeAlpha3__ = (System.String)_v_; }, false);
                    CountryCodeNumeric = Add<__TString__>("CountryCodeNumeric$");
                    CountryCodeNumeric.DefaultValue = "";
                    CountryCodeNumeric.Editable = true;
                    CountryCodeNumeric.SetCustomAccessors((_p_) => { return ((__CuAddressJ__)_p_).__bf__CountryCodeNumeric__; }, (_p_, _v_) => { ((__CuAddressJ__)_p_).__bf__CountryCodeNumeric__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CuAddressJ__(this) { Parent = parent }; }
                public __TString__ StreetAddress;
                public __TString__ ExtendedAddress;
                public __TString__ Locality;
                public __TString__ Region;
                public __TString__ PostalCode;
                public __TString__ CountryName;
                public __TString__ CountryCodeAlpha2;
                public __TString__ CountryCodeAlpha3;
                public __TString__ CountryCodeNumeric;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String StreetAddress {
#line 4 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.StreetAddress.Getter(this); }
#line 4 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.StreetAddress.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ExtendedAddress {
#line 5 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.ExtendedAddress.Getter(this); }
#line 5 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.ExtendedAddress.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Locality {
#line 6 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.Locality.Getter(this); }
#line 6 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Locality.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Region {
#line 7 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.Region.Getter(this); }
#line 7 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Region.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PostalCode {
#line 8 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.PostalCode.Getter(this); }
#line 8 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.PostalCode.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CountryName {
#line 9 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.CountryName.Getter(this); }
#line 9 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.CountryName.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CountryCodeAlpha2 {
#line 10 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.CountryCodeAlpha2.Getter(this); }
#line 10 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.CountryCodeAlpha2.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CountryCodeAlpha3 {
#line 11 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.CountryCodeAlpha3.Getter(this); }
#line 11 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.CountryCodeAlpha3.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CountryCodeNumeric {
#line 13 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.CountryCodeNumeric.Getter(this); }
#line 13 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.CountryCodeNumeric.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class StreetAddress : Input<__CuAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ExtendedAddress : Input<__CuAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Locality : Input<__CuAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Region : Input<__CuAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class PostalCode : Input<__CuAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CountryName : Input<__CuAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CountryCodeAlpha2 : Input<__CuAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CountryCodeAlpha3 : Input<__CuAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CountryCodeNumeric : Input<__CuAddressJ__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CustomerJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCuSchema__ DefaultTemplate = new __CCuSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerJson(__CCuSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCuSchema__ Template { get { return (__CCuSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__FirstName__;
        private System.String __bf__LastName__;
        private System.String __bf__Phone__;
        private System.String __bf__Email__;
        private System.String __bf__Fax__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CuCustomer__);
                    ClassName = "CustomerJson";
                    Properties.ClearExposed();
                    FirstName = Add<__TString__>("FirstName$");
                    FirstName.DefaultValue = "";
                    FirstName.Editable = true;
                    FirstName.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__FirstName__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__FirstName__ = (System.String)_v_; }, false);
                    LastName = Add<__TString__>("LastName$");
                    LastName.DefaultValue = "";
                    LastName.Editable = true;
                    LastName.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__LastName__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__LastName__ = (System.String)_v_; }, false);
                    Phone = Add<__TString__>("Phone$");
                    Phone.DefaultValue = "";
                    Phone.Editable = true;
                    Phone.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__Phone__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__Phone__ = (System.String)_v_; }, false);
                    Email = Add<__TString__>("Email$");
                    Email.DefaultValue = "";
                    Email.Editable = true;
                    Email.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__Email__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__Email__ = (System.String)_v_; }, false);
                    Fax = Add<__TString__>("Fax$");
                    Fax.DefaultValue = "";
                    Fax.Editable = true;
                    Fax.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__Fax__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__Fax__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CuCustomer__(this) { Parent = parent }; }
                public __TString__ FirstName;
                public __TString__ LastName;
                public __TString__ Phone;
                public __TString__ Email;
                public __TString__ Fax;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FirstName {
#line 15 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.FirstName.Getter(this); }
#line 15 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.FirstName.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String LastName {
#line 16 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.LastName.Getter(this); }
#line 16 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.LastName.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Phone {
#line 17 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.Phone.Getter(this); }
#line 17 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Phone.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Email {
#line 18 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.Email.Getter(this); }
#line 18 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Email.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Fax {
#line 20 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.Fax.Getter(this); }
#line 20 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Fax.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class FirstName : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class LastName : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Phone : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Email : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Fax : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CompanyJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCoSchema__ DefaultTemplate = new __CCoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CompanyJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CompanyJson(__CCoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCoSchema__ Template { get { return (__CCoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__CompanyName__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CuCompanyJ__);
                    ClassName = "CompanyJson";
                    Properties.ClearExposed();
                    CompanyName = Add<__TString__>("CompanyName$");
                    CompanyName.DefaultValue = "";
                    CompanyName.Editable = true;
                    CompanyName.SetCustomAccessors((_p_) => { return ((__CuCompanyJ__)_p_).__bf__CompanyName__; }, (_p_, _v_) => { ((__CuCompanyJ__)_p_).__bf__CompanyName__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CuCompanyJ__(this) { Parent = parent }; }
                public __TString__ CompanyName;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CompanyName {
#line 23 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.CompanyName.Getter(this); }
#line 23 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.CompanyName.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CompanyName : Input<__CuCompanyJ__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CreditCardJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCrSchema__ DefaultTemplate = new __CCrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CreditCardJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CreditCardJson(__CCrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCrSchema__ Template { get { return (__CCrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__CardNumber__;
        private System.String __bf__ExpiryMonth__;
        private System.String __bf__ExpiryYear__;
        private System.String __bf__SecurityNumber__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CuCreditCa__);
                    ClassName = "CreditCardJson";
                    Properties.ClearExposed();
                    CardNumber = Add<__TString__>("CardNumber$");
                    CardNumber.DefaultValue = "";
                    CardNumber.Editable = true;
                    CardNumber.SetCustomAccessors((_p_) => { return ((__CuCreditCa__)_p_).__bf__CardNumber__; }, (_p_, _v_) => { ((__CuCreditCa__)_p_).__bf__CardNumber__ = (System.String)_v_; }, false);
                    ExpiryMonth = Add<__TString__>("ExpiryMonth$");
                    ExpiryMonth.DefaultValue = "";
                    ExpiryMonth.Editable = true;
                    ExpiryMonth.SetCustomAccessors((_p_) => { return ((__CuCreditCa__)_p_).__bf__ExpiryMonth__; }, (_p_, _v_) => { ((__CuCreditCa__)_p_).__bf__ExpiryMonth__ = (System.String)_v_; }, false);
                    ExpiryYear = Add<__TString__>("ExpiryYear$");
                    ExpiryYear.DefaultValue = "";
                    ExpiryYear.Editable = true;
                    ExpiryYear.SetCustomAccessors((_p_) => { return ((__CuCreditCa__)_p_).__bf__ExpiryYear__; }, (_p_, _v_) => { ((__CuCreditCa__)_p_).__bf__ExpiryYear__ = (System.String)_v_; }, false);
                    SecurityNumber = Add<__TString__>("SecurityNumber$");
                    SecurityNumber.DefaultValue = "";
                    SecurityNumber.Editable = true;
                    SecurityNumber.SetCustomAccessors((_p_) => { return ((__CuCreditCa__)_p_).__bf__SecurityNumber__; }, (_p_, _v_) => { ((__CuCreditCa__)_p_).__bf__SecurityNumber__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CuCreditCa__(this) { Parent = parent }; }
                public __TString__ CardNumber;
                public __TString__ ExpiryMonth;
                public __TString__ ExpiryYear;
                public __TString__ SecurityNumber;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CardNumber {
#line 25 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.CardNumber.Getter(this); }
#line 25 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.CardNumber.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ExpiryMonth {
#line 26 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.ExpiryMonth.Getter(this); }
#line 26 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.ExpiryMonth.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ExpiryYear {
#line 27 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.ExpiryYear.Getter(this); }
#line 27 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.ExpiryYear.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String SecurityNumber {
#line 29 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.SecurityNumber.Getter(this); }
#line 29 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.SecurityNumber.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CardNumber : Input<__CuCreditCa__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ExpiryMonth : Input<__CuCreditCa__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ExpiryYear : Input<__CuCreditCa__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class SecurityNumber : Input<__CuCreditCa__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CustomerLabelJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCuSchema1__ DefaultTemplate = new __CCuSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerLabelJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerLabelJson(__CCuSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCuSchema1__ Template { get { return (__CCuSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__FirstNameName__;
        private System.String __bf__LastNameName__;
        private System.String __bf__EmailName__;
        private System.String __bf__Address1Name__;
        private System.String __bf__ZipPostalCodeName__;
        private System.String __bf__TownName__;
        private System.String __bf__StateName__;
        private System.String __bf__ProvinceName__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CuCustomer3__);
                    ClassName = "CustomerLabelJson";
                    Properties.ClearExposed();
                    FirstNameName = Add<__TString__>("FirstNameName$");
                    FirstNameName.DefaultValue = "";
                    FirstNameName.Editable = true;
                    FirstNameName.SetCustomAccessors((_p_) => { return ((__CuCustomer3__)_p_).__bf__FirstNameName__; }, (_p_, _v_) => { ((__CuCustomer3__)_p_).__bf__FirstNameName__ = (System.String)_v_; }, false);
                    LastNameName = Add<__TString__>("LastNameName$");
                    LastNameName.DefaultValue = "";
                    LastNameName.Editable = true;
                    LastNameName.SetCustomAccessors((_p_) => { return ((__CuCustomer3__)_p_).__bf__LastNameName__; }, (_p_, _v_) => { ((__CuCustomer3__)_p_).__bf__LastNameName__ = (System.String)_v_; }, false);
                    EmailName = Add<__TString__>("EmailName$");
                    EmailName.DefaultValue = "";
                    EmailName.Editable = true;
                    EmailName.SetCustomAccessors((_p_) => { return ((__CuCustomer3__)_p_).__bf__EmailName__; }, (_p_, _v_) => { ((__CuCustomer3__)_p_).__bf__EmailName__ = (System.String)_v_; }, false);
                    Address1Name = Add<__TString__>("Address1Name$");
                    Address1Name.DefaultValue = "";
                    Address1Name.Editable = true;
                    Address1Name.SetCustomAccessors((_p_) => { return ((__CuCustomer3__)_p_).__bf__Address1Name__; }, (_p_, _v_) => { ((__CuCustomer3__)_p_).__bf__Address1Name__ = (System.String)_v_; }, false);
                    ZipPostalCodeName = Add<__TString__>("ZipPostalCodeName$");
                    ZipPostalCodeName.DefaultValue = "";
                    ZipPostalCodeName.Editable = true;
                    ZipPostalCodeName.SetCustomAccessors((_p_) => { return ((__CuCustomer3__)_p_).__bf__ZipPostalCodeName__; }, (_p_, _v_) => { ((__CuCustomer3__)_p_).__bf__ZipPostalCodeName__ = (System.String)_v_; }, false);
                    TownName = Add<__TString__>("TownName$");
                    TownName.DefaultValue = "";
                    TownName.Editable = true;
                    TownName.SetCustomAccessors((_p_) => { return ((__CuCustomer3__)_p_).__bf__TownName__; }, (_p_, _v_) => { ((__CuCustomer3__)_p_).__bf__TownName__ = (System.String)_v_; }, false);
                    StateName = Add<__TString__>("StateName$");
                    StateName.DefaultValue = "";
                    StateName.Editable = true;
                    StateName.SetCustomAccessors((_p_) => { return ((__CuCustomer3__)_p_).__bf__StateName__; }, (_p_, _v_) => { ((__CuCustomer3__)_p_).__bf__StateName__ = (System.String)_v_; }, false);
                    ProvinceName = Add<__TString__>("ProvinceName$");
                    ProvinceName.DefaultValue = "";
                    ProvinceName.Editable = true;
                    ProvinceName.SetCustomAccessors((_p_) => { return ((__CuCustomer3__)_p_).__bf__ProvinceName__; }, (_p_, _v_) => { ((__CuCustomer3__)_p_).__bf__ProvinceName__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CuCustomer3__(this) { Parent = parent }; }
                public __TString__ FirstNameName;
                public __TString__ LastNameName;
                public __TString__ EmailName;
                public __TString__ Address1Name;
                public __TString__ ZipPostalCodeName;
                public __TString__ TownName;
                public __TString__ StateName;
                public __TString__ ProvinceName;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FirstNameName {
#line 31 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.FirstNameName.Getter(this); }
#line 31 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.FirstNameName.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String LastNameName {
#line 32 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.LastNameName.Getter(this); }
#line 32 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.LastNameName.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EmailName {
#line 33 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.EmailName.Getter(this); }
#line 33 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.EmailName.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Address1Name {
#line 34 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.Address1Name.Getter(this); }
#line 34 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Address1Name.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ZipPostalCodeName {
#line 35 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.ZipPostalCodeName.Getter(this); }
#line 35 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.ZipPostalCodeName.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String TownName {
#line 36 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.TownName.Getter(this); }
#line 36 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.TownName.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String StateName {
#line 37 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.StateName.Getter(this); }
#line 37 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.StateName.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ProvinceName {
#line 39 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.ProvinceName.Getter(this); }
#line 39 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.ProvinceName.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class FirstNameName : Input<__CuCustomer3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class LastNameName : Input<__CuCustomer3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class EmailName : Input<__CuCustomer3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Address1Name : Input<__CuCustomer3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ZipPostalCodeName : Input<__CuCustomer3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class TownName : Input<__CuCustomer3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class StateName : Input<__CuCustomer3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ProvinceName : Input<__CuCustomer3__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class ErrorsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CErSchema__ DefaultTemplate = new __CErSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ErrorsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ErrorsElementJson(__CErSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CErSchema__ Template { get { return (__CErSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Error__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CuErrorsEl__);
                    ClassName = "ErrorsElementJson";
                    Properties.ClearExposed();
                    Error = Add<__TString__>("Error");
                    Error.DefaultValue = "";
                    Error.SetCustomAccessors((_p_) => { return ((__CuErrorsEl__)_p_).__bf__Error__; }, (_p_, _v_) => { ((__CuErrorsEl__)_p_).__bf__Error__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CuErrorsEl__(this) { Parent = parent }; }
                public __TString__ Error;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Error {
#line 43 "ViewModels\CustomerData\CustomerDataPage.json"
    get {
#line hidden
        return Template.Error.Getter(this); }
#line 43 "ViewModels\CustomerData\CustomerDataPage.json"
    set {
#line hidden
        Template.Error.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Error : Input<__CuErrorsEl__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Customer__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108