﻿using System;
using System.Web.Mvc;
using AmvReporting.Domain.Preview.Queries;
using AmvReporting.Domain.Preview.ViewModels;
using AmvReporting.Domain.ReportingConfigs.Queries;
using AmvReporting.Domain.Reports;
using AmvReporting.Infrastructure.CQRS;
using AmvReporting.Infrastructure.Filters;


namespace AmvReporting.Controllers
{
    [RoleAuthorizeFilter]
    public partial class PreviewController : BaseController
    {
        private readonly IMediator mediator;

        public PreviewController(IMediator mediator)
        {
            this.mediator = mediator;
        }



        [HttpPost]
        public virtual ActionResult Data(String sql, String databaseId, ReportType reportType)
        {
            var query = new PreviewDataQuery(sql, databaseId, reportType);
            var result = mediator.Request(query);

            return PartialView(result);
        }


        [HttpPost]
        public virtual ActionResult Report(PreviewReportModel model)
        {
            var query = new PreviewDataQuery(model.Sql, model.DatabaseId, model.ReportType);
            var queryResult = mediator.Request(query);
            var config = mediator.Request(new ReportingConfigQuery());

            var outModel = new ReportResultPreview()
                           {
                               Data = queryResult.Data,
                               JavaScript = model.JavaScript,
                               GlobalJs = config.GlobalJavascript,
                               Css = model.Css,
                               GlobalCss = config.GlobalCss,
                               ReportType = model.ReportType,
                               HtmlOverride = model.HtmlOverride,
                           };

            return PartialView(outModel);
        }


        [HttpPost, ValidateInput(false)]
        public virtual ActionResult CleanseAndFormatSql(String sql)
        {
            var cleanedSql = mediator.Request(new CleanseSqlQuery(sql));

            var formattedSql = mediator.Request(new FormattedSqlQuery(cleanedSql));

            return Json(formattedSql);
        }


        [HttpPost, ValidateInput(false)]
        public virtual ActionResult ParseHtml(String rawData)
        {
            var sqlParsingResult = mediator.Request(new RawHtmlInputQuery(rawData));

            if (!sqlParsingResult.IsSuccess)
            {
                return Json(sqlParsingResult);
            }
            var cleanedSql = mediator.Request(new CleanseSqlQuery(sqlParsingResult.Payload));

            var formattedSql = mediator.Request(new FormattedSqlQuery(cleanedSql));

            sqlParsingResult.Payload = formattedSql;

            return Json(sqlParsingResult);
        }
    }
}