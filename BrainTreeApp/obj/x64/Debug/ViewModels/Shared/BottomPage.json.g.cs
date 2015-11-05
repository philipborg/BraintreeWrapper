// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\Shared\BottomPage.json"
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

using __BottomPa__ = global::BrainTreeApp.ViewModels.Shared.BottomPage;
using __BoSchema__ = global::BrainTreeApp.ViewModels.Shared.BottomPage.JsonByExample.Schema;
using __BottomPa1__ = global::BrainTreeApp.ViewModels.Shared.BottomPage.JsonByExample;
using __BottomPa2__ = global::BrainTreeApp.ViewModels.Shared.BottomPage.Input;

namespace BrainTreeApp.ViewModels.Shared {

#line hidden
public partial class BottomPage : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BoSchema__ DefaultTemplate = new __BoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BottomPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BottomPage(__BoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BoSchema__ Template { get { return (__BoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__BottomPa__);
                ClassName = "BottomPage";
                Properties.ClearExposed();
            }
            public override object CreateInstance(s.Json parent) { return new __BottomPa__(this) { Parent = parent }; }
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
public class BottomPage_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108