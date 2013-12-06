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
    public partial class DatabaseController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected DatabaseController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Edit()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Delete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CheckDatabaseConnection()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CheckDatabaseConnection);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public DatabaseController Actions { get { return MVC.Database; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Database";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Database";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Create = "Create";
            public readonly string Edit = "Edit";
            public readonly string Delete = "Delete";
            public readonly string CheckDatabaseConnection = "CheckDatabaseConnection";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Create = "Create";
            public const string Edit = "Edit";
            public const string Delete = "Delete";
            public const string CheckDatabaseConnection = "CheckDatabaseConnection";
        }


        static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Create
        {
            public readonly string command = "command";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string dbId = "dbId";
            public readonly string command = "command";
        }
        static readonly ActionParamsClass_Delete s_params_Delete = new ActionParamsClass_Delete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Delete DeleteParams { get { return s_params_Delete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Delete
        {
            public readonly string command = "command";
        }
        static readonly ActionParamsClass_CheckDatabaseConnection s_params_CheckDatabaseConnection = new ActionParamsClass_CheckDatabaseConnection();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CheckDatabaseConnection CheckDatabaseConnectionParams { get { return s_params_CheckDatabaseConnection; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CheckDatabaseConnection
        {
            public readonly string connectionString = "connectionString";
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
                public readonly string _CommonScripts = "_CommonScripts";
                public readonly string _CreateEdit = "_CreateEdit";
                public readonly string _ViewStart = "_ViewStart";
                public readonly string Create = "Create";
                public readonly string Edit = "Edit";
                public readonly string Index = "Index";
            }
            public readonly string _CommonScripts = "~/Views/Database/_CommonScripts.cshtml";
            public readonly string _CreateEdit = "~/Views/Database/_CreateEdit.cshtml";
            public readonly string _ViewStart = "~/Views/Database/_ViewStart.cshtml";
            public readonly string Create = "~/Views/Database/Create.cshtml";
            public readonly string Edit = "~/Views/Database/Edit.cshtml";
            public readonly string Index = "~/Views/Database/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_DatabaseController : AmvReporting.Controllers.DatabaseController
    {
        public T4MVC_DatabaseController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Create()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            CreateOverride(callInfo);
            return callInfo;
        }

        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, AmvReporting.Domain.DatabaseConnections.Commands.CreateDatabaseDetailsCommand command);

        public override System.Web.Mvc.ActionResult Create(AmvReporting.Domain.DatabaseConnections.Commands.CreateDatabaseDetailsCommand command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            CreateOverride(callInfo, command);
            return callInfo;
        }

        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string dbId);

        public override System.Web.Mvc.ActionResult Edit(string dbId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "dbId", dbId);
            EditOverride(callInfo, dbId);
            return callInfo;
        }

        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, AmvReporting.Domain.DatabaseConnections.Commands.EditDatabaseDetailsCommand command);

        public override System.Web.Mvc.ActionResult Edit(AmvReporting.Domain.DatabaseConnections.Commands.EditDatabaseDetailsCommand command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            EditOverride(callInfo, command);
            return callInfo;
        }

        partial void DeleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, AmvReporting.Domain.DatabaseConnections.Commands.DeleteDatabaseCommand command);

        public override System.Web.Mvc.ActionResult Delete(AmvReporting.Domain.DatabaseConnections.Commands.DeleteDatabaseCommand command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            DeleteOverride(callInfo, command);
            return callInfo;
        }

        partial void CheckDatabaseConnectionOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string connectionString);

        public override System.Web.Mvc.ActionResult CheckDatabaseConnection(string connectionString)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CheckDatabaseConnection);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "connectionString", connectionString);
            CheckDatabaseConnectionOverride(callInfo, connectionString);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
