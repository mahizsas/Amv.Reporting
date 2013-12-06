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
    public partial class PreviewController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected PreviewController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Data()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Data);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public PreviewController Actions { get { return MVC.Preview; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Preview";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Preview";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Data = "Data";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Data = "Data";
        }


        static readonly ActionParamsClass_Data s_params_Data = new ActionParamsClass_Data();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Data DataParams { get { return s_params_Data; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Data
        {
            public readonly string sql = "sql";
            public readonly string databaseId = "databaseId";
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
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_PreviewController : AmvReporting.Controllers.PreviewController
    {
        public T4MVC_PreviewController() : base(Dummy.Instance) { }

        partial void DataOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string sql, string databaseId);

        public override System.Web.Mvc.ActionResult Data(string sql, string databaseId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Data);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sql", sql);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "databaseId", databaseId);
            DataOverride(callInfo, sql, databaseId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
