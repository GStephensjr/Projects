#pragma checksum "C:\Users\Grego\OneDrive\Desktop\MSSA\Projects\Heirarchy Database GUI\Hierarchy GUI\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e008af9806e6f7c6a01c65718adb3260e85d855b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Grego\OneDrive\Desktop\MSSA\Projects\Heirarchy Database GUI\Hierarchy GUI\Views\_ViewImports.cshtml"
using Hierarchy_GUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e008af9806e6f7c6a01c65718adb3260e85d855b", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e571161546d5c731b814436184efdd9fc61693e", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 806, true);
            WriteLiteral(@"<form action=""action_page.php"">
    <div class=""container"">
        <h1>Register</h1>
        <p>Please fill in this form to create an account.</p>
        <hr>

        <label for=""email""><b>Email</b></label>
        <input type=""text"" placeholder=""Enter Email"" name=""email"" required>

        <label for=""psw""><b>Password</b></label>
        <input type=""password"" placeholder=""Enter Password"" name=""psw"" required>

        <label for=""psw-repeat""><b>Repeat Password</b></label>
        <input type=""password"" placeholder=""Repeat Password"" name=""psw-repeat"" required>
        <hr>

        <button type=""submit"" class=""registerbtn"">Register</button>
    </div>

    <div class=""container signin"">
        <p>Already have an account? <a href=""#"">Sign in</a>.</p>
    </div>
</form>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
