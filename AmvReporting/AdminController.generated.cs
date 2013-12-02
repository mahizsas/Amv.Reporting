// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace AmvReporting.Controllers
{
    public partial class AdminController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AdminController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult EditReport()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditReport);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DeleteReport()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteReport);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AdminController Actions { get { return MVC.Admin; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Admin";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Admin";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string CreateReport = "CreateReport";
            public readonly string EditReport = "EditReport";
            public readonly string DeleteReport = "DeleteReport";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string CreateReport = "CreateReport";
            public const string EditReport = "EditReport";
            public const string DeleteReport = "DeleteReport";
        }


        static readonly ActionParamsClass_CreateReport s_params_CreateReport = new ActionParamsClass_CreateReport();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CreateReport CreateReportParams { get { return s_params_CreateReport; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CreateReport
        {
            public readonly string command = "command";
        }
        static readonly ActionParamsClass_EditReport s_params_EditReport = new ActionParamsClass_EditReport();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditReport EditReportParams { get { return s_params_EditReport; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditReport
        {
            public readonly string linkName = "linkName";
            public readonly string command = "command";
        }
        static readonly ActionParamsClass_DeleteReport s_params_DeleteReport = new ActionParamsClass_DeleteReport();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteReport DeleteReportParams { get { return s_params_DeleteReport; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteReport
        {
            public readonly string linkName = "linkName";
            public readonly string command = "command";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _CommonJavaScript = "_CommonJavaScript";
                public readonly string _CreateEdit = "_CreateEdit";
                public readonly string _ViewStart = "_ViewStart";
                public readonly string CreateReport = "CreateReport";
                public readonly string DeleteReport = "DeleteReport";
                public readonly string EditReport = "EditReport";
                public readonly string Index = "Index";
            }
            public readonly string _CommonJavaScript = "~/Views/Admin/_CommonJavaScript.cshtml";
            public readonly string _CreateEdit = "~/Views/Admin/_CreateEdit.cshtml";
            public readonly string _ViewStart = "~/Views/Admin/_ViewStart.cshtml";
            public readonly string CreateReport = "~/Views/Admin/CreateReport.cshtml";
            public readonly string DeleteReport = "~/Views/Admin/DeleteReport.cshtml";
            public readonly string EditReport = "~/Views/Admin/EditReport.cshtml";
            public readonly string Index = "~/Views/Admin/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_AdminController : AmvReporting.Controllers.AdminController
    {
        public T4MVC_AdminController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        partial void CreateReportOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult CreateReport()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateReport);
            CreateReportOverride(callInfo);
            return callInfo;
        }

        partial void CreateReportOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, AmvReporting.Commands.CreateReportCommand command);

        public override System.Web.Mvc.ActionResult CreateReport(AmvReporting.Commands.CreateReportCommand command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateReport);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            CreateReportOverride(callInfo, command);
            return callInfo;
        }

        partial void EditReportOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string linkName);

        public override System.Web.Mvc.ActionResult EditReport(string linkName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditReport);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "linkName", linkName);
            EditReportOverride(callInfo, linkName);
            return callInfo;
        }

        partial void EditReportOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, AmvReporting.Commands.EditReportCommand command);

        public override System.Web.Mvc.ActionResult EditReport(AmvReporting.Commands.EditReportCommand command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditReport);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            EditReportOverride(callInfo, command);
            return callInfo;
        }

        partial void DeleteReportOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string linkName);

        public override System.Web.Mvc.ActionResult DeleteReport(string linkName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteReport);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "linkName", linkName);
            DeleteReportOverride(callInfo, linkName);
            return callInfo;
        }

        partial void DeleteReportOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, AmvReporting.Commands.DeleteReportCommand command);

        public override System.Web.Mvc.ActionResult DeleteReport(AmvReporting.Commands.DeleteReportCommand command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteReport);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            DeleteReportOverride(callInfo, command);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
