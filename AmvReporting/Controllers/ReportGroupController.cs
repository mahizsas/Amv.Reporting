﻿using System;
using System.Web.Mvc;
using AmvReporting.Domain.ReportGroups.Commands;
using AmvReporting.Domain.ReportGroups.Queries;
using AmvReporting.Infrastructure;
using AmvReporting.Infrastructure.CQRS;

namespace AmvReporting.Controllers
{
    public partial class ReportGroupController : BaseController
    {
        private readonly IMediator mediator;

        public ReportGroupController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual ActionResult Index()
        {
            var groups = mediator.Request(new AllReportGroupsQuery());
            return View(groups);
        }

        [RestoreModelState]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public virtual ActionResult Create(CreateReportGroupCommand command)
        {
            return ProcessForm(command, RedirectToAction(MVC.ReportGroup.Create()),
                RedirectToAction(MVC.ReportGroup.Index()));
        }

        [RestoreModelState]
        public virtual ActionResult Edit(String id)
        {
            var report = mediator.Request(new ReportGroupQuery(id));
            return View(report);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public virtual ActionResult Edit(EditReportGroupCommand command)
        {
            return ProcessForm(command, RedirectToAction(MVC.ReportGroup.Edit(command.Id)), 
                RedirectToAction(MVC.ReportGroup.Index()));
        }

        [HttpPost]
        public virtual ActionResult Delete(DeleteReportGroupCommand command)
        {
            return ProcessJsonForm(command, "Group Deleted");
        }
	}
}