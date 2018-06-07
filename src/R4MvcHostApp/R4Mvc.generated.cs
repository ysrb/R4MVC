// <auto-generated />
// This file was generated by R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using R4Mvc;

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly R4Mvc.AdminAreaClass s_AdminArea = new R4Mvc.AdminAreaClass();
    public static R4Mvc.AdminAreaClass AdminArea => s_AdminArea;
    static readonly R4Mvc.MembersAreaClass s_Members = new R4Mvc.MembersAreaClass();
    public static R4Mvc.MembersAreaClass Members => s_Members;
    public static readonly R4MvcHostApp.Controllers.AccountController Account = new R4MvcHostApp.Controllers.R4MVC_AccountController();
    public static readonly R4MvcHostApp.Controllers.AdminController Admin = new R4MvcHostApp.Controllers.R4MVC_AdminController();
    public static readonly R4MvcHostApp.Features.Calculator.CalculatorController Calculator = new R4MvcHostApp.Features.Calculator.R4MVC_CalculatorController();
    public static readonly R4MvcHostApp.Controllers.HomeController Home = new R4MvcHostApp.Controllers.R4MVC_HomeController();
    public static readonly R4MvcHostApp.Controllers.ManageController Manage = new R4MvcHostApp.Controllers.R4MVC_ManageController();
    public static readonly R4Mvc.SharedController Shared = new R4Mvc.SharedController();
}

namespace R4Mvc
{
    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy()
        {
        }

        public static Dummy Instance = new Dummy();
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class SharedController
    {
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
                public readonly string Error = "Error";
                public readonly string View_File_With_Dots = "View.File.With.Dots";
                public readonly string _Layout = "_Layout";
                public readonly string _LoginPartial = "_LoginPartial";
                public readonly string _ValidationScriptsPartial = "_ValidationScriptsPartial";
            }

            public readonly string Error = "~/Views/Shared/Error.cshtml";
            public readonly string View_File_With_Dots = "~/Views/Shared/View.File.With.Dots.cshtml";
            public readonly string _Layout = "~/Views/Shared/_Layout.cshtml";
            public readonly string _LoginPartial = "~/Views/Shared/_LoginPartial.cshtml";
            public readonly string _ValidationScriptsPartial = "~/Views/Shared/_ValidationScriptsPartial.cshtml";
            static readonly _DisplayTemplatesClass s_DisplayTemplates = new _DisplayTemplatesClass();
            public _DisplayTemplatesClass DisplayTemplates => s_DisplayTemplates;
            public partial class _DisplayTemplatesClass
            {
                public readonly string Test = "Test";
            }

            static readonly _EditorTemplatesClass s_EditorTemplates = new _EditorTemplatesClass();
            public _EditorTemplatesClass EditorTemplates => s_EditorTemplates;
            public partial class _EditorTemplatesClass
            {
                public readonly string Test = "Test";
            }

            static readonly _OtherTemplatesClass s_OtherTemplates = new _OtherTemplatesClass();
            public _OtherTemplatesClass OtherTemplates => s_OtherTemplates;
            public partial class _OtherTemplatesClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames => s_ViewNames;
                public class _ViewNamesClass
                {
                    public readonly string Test = "Test";
                }

                public readonly string Test = "~/Views/Shared/OtherTemplates/Test.cshtml";
            }
        }

        static readonly ViewsClass s_Views = new ViewsClass();
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class AdminArea_SharedController
    {
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
                public readonly string _Layout = "_Layout";
            }

            public readonly string _Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
        }

        static readonly ViewsClass s_Views = new ViewsClass();
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class AdminAreaClass
    {
        public readonly string Name = "Admin";
        public readonly R4MvcHostApp.Areas.Admin.MisplacedFeature.MisplacedFeatureController MisplacedFeature = new R4MvcHostApp.Areas.Admin.MisplacedFeature.R4MVC_MisplacedFeatureController();
        public readonly R4MvcHostApp.Areas.Admin.Controllers.PagesController Pages = new R4MvcHostApp.Areas.Admin.Controllers.R4MVC_PagesController();
        public readonly R4MvcHostApp.Areas.Admin.Features.TaxCalculator.TaxCalculatorController TaxCalculator = new R4MvcHostApp.Areas.Admin.Features.TaxCalculator.R4MVC_TaxCalculatorController();
        public readonly R4MvcHostApp.Areas.Admin.Controllers.UsersController Users = new R4MvcHostApp.Areas.Admin.Controllers.R4MVC_UsersController();
        public readonly R4Mvc.AdminArea_SharedController Shared = new R4Mvc.AdminArea_SharedController();
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class MembersAreaClass
    {
        public readonly string Name = "Members";
        public readonly R4MvcHostApp.Areas.Members.Awards.AwardsController Awards = new R4MvcHostApp.Areas.Members.Awards.R4MVC_AwardsController();
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
public static partial class Links
{
    public const string UrlPath = "~";
    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
    public static partial class css
    {
        public const string UrlPath = "~/css";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static partial class library_css
        {
            public const string UrlPath = "~/css/library.css";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static readonly string library_css_ = Url("library.css");
        }

        public static readonly string _site_css = Url(".site.css");
        public static readonly string site_css = Url("site.css");
        public static readonly string site_min_css = Url("site.min.css");
    }

    public static partial class images
    {
        public const string UrlPath = "~/images";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static readonly string banner1_svg = Url("banner1.svg");
        public static readonly string banner2_svg = Url("banner2.svg");
        public static readonly string banner3_svg = Url("banner3.svg");
        public static readonly string banner4_svg = Url("banner4.svg");
    }

    public static partial class js
    {
        public const string UrlPath = "~/js";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static partial class library_js
        {
            public const string UrlPath = "~/js/library.js";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static readonly string library_js_ = Url("library.js");
        }

        public static readonly string site_js = Url("site.js");
        public static readonly string site_min_js = Url("site.min.js");
    }

    public static partial class lib
    {
        public const string UrlPath = "~/lib";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static partial class bootstrap
        {
            public const string UrlPath = "~/lib/bootstrap";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static partial class dist
            {
                public const string UrlPath = "~/lib/bootstrap/dist";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static partial class css
                {
                    public const string UrlPath = "~/lib/bootstrap/dist/css";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string bootstrap_theme_css = Url("bootstrap-theme.css");
                    public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
                    public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
                    public static readonly string bootstrap_theme_min_css_map = Url("bootstrap-theme.min.css.map");
                    public static readonly string bootstrap_css = Url("bootstrap.css");
                    public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
                    public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
                    public static readonly string bootstrap_min_css_map = Url("bootstrap.min.css.map");
                }

                public static partial class fonts
                {
                    public const string UrlPath = "~/lib/bootstrap/dist/fonts";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
                    public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
                    public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
                    public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
                    public static readonly string glyphicons_halflings_regular_woff2 = Url("glyphicons-halflings-regular.woff2");
                }

                public static partial class js
                {
                    public const string UrlPath = "~/lib/bootstrap/dist/js";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string bootstrap_js = Url("bootstrap.js");
                    public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
                    public static readonly string npm_js = Url("npm.js");
                }
            }

            public static readonly string _bower_json = Url(".bower.json");
            public static readonly string LICENSE = Url("LICENSE");
        }

        public static partial class jquery
        {
            public const string UrlPath = "~/lib/jquery";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static partial class dist
            {
                public const string UrlPath = "~/lib/jquery/dist";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static readonly string jquery_js = Url("jquery.js");
                public static readonly string jquery_min_js = Url("jquery.min.js");
                public static readonly string jquery_min_map = Url("jquery.min.map");
            }

            public static partial class validation
            {
                public const string UrlPath = "~/lib/jquery-validation";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static partial class dist
                {
                    public const string UrlPath = "~/lib/jquery-validation/dist";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string additional_methods_js = Url("additional-methods.js");
                    public static readonly string additional_methods_min_js = Url("additional-methods.min.js");
                    public static readonly string jquery_validate_js = Url("jquery.validate.js");
                    public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
                }

                public static partial class unobtrusive
                {
                    public const string UrlPath = "~/lib/jquery-validation-unobtrusive";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string _bower_json = Url(".bower.json");
                    public static readonly string jquery_validate_unobtrusive_js = Url("jquery.validate.unobtrusive.js");
                    public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
                }

                public static readonly string _bower_json = Url(".bower.json");
            }

            public static partial class validation_unobtrusive
            {
                public const string UrlPath = "~/lib/jquery-validation-unobtrusive";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static readonly string _bower_json = Url(".bower.json");
                public static readonly string jquery_validate_unobtrusive_js = Url("jquery.validate.unobtrusive.js");
                public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
            }

            public static readonly string _bower_json = Url(".bower.json");
        }

        public static partial class jquery_validation
        {
            public const string UrlPath = "~/lib/jquery-validation";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static partial class dist
            {
                public const string UrlPath = "~/lib/jquery-validation/dist";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static readonly string additional_methods_js = Url("additional-methods.js");
                public static readonly string additional_methods_min_js = Url("additional-methods.min.js");
                public static readonly string jquery_validate_js = Url("jquery.validate.js");
                public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
            }

            public static partial class unobtrusive
            {
                public const string UrlPath = "~/lib/jquery-validation-unobtrusive";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static readonly string _bower_json = Url(".bower.json");
                public static readonly string jquery_validate_unobtrusive_js = Url("jquery.validate.unobtrusive.js");
                public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
            }

            public static readonly string _bower_json = Url(".bower.json");
        }

        public static partial class jquery_validation_unobtrusive
        {
            public const string UrlPath = "~/lib/jquery-validation-unobtrusive";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static readonly string _bower_json = Url(".bower.json");
            public static readonly string jquery_validate_unobtrusive_js = Url("jquery.validate.unobtrusive.js");
            public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        }
    }

    public static readonly string favicon_ico = Url("favicon.ico");
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal static class R4MvcHelpers
{
    private static string ProcessVirtualPathDefault(string virtualPath) => virtualPath;
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult : ActionResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult : JsonResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_ContentResult : ContentResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_ContentResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_FileResult : FileResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_FileResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult : RedirectResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult : RedirectToActionResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult(string area, string controller, string action, string protocol = null): base(" ", " ", " ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult : RedirectToRouteResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}
#pragma warning restore 1591, 3008, 3009, 0108
