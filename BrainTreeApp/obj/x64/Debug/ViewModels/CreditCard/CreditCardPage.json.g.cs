// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\CreditCard\CreditCardPage.json"
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

using __CreditCa__ = global::BrainTreeApp.ViewModels.CreditCard.CreditCardPage;
using __CrSchema__ = global::BrainTreeApp.ViewModels.CreditCard.CreditCardPage.JsonByExample.Schema;
using __CreditCa1__ = global::BrainTreeApp.ViewModels.CreditCard.CreditCardPage.JsonByExample;
using __CreditCa2__ = global::BrainTreeApp.ViewModels.CreditCard.CreditCardPage.Input;

namespace BrainTreeApp.ViewModels.CreditCard {

#line hidden
public partial class CreditCardPage : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CrSchema__ DefaultTemplate = new __CrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CreditCardPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CreditCardPage(__CrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CrSchema__ Template { get { return (__CrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__CreditCa__);
                ClassName = "CreditCardPage";
                Properties.ClearExposed();
            }
            public override object CreateInstance(s.Json parent) { return new __CreditCa__(this) { Parent = parent }; }
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CreditCardPage_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108