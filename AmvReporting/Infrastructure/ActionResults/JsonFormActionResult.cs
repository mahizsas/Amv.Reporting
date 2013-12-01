﻿using System;
using System.Web.Mvc;
using AmvReporting.Infrastructure.CQRS;
using AmvReporting.Models;

namespace AmvReporting.Infrastructure.ActionResults
{
    public class JsonFormActionResult<T> : ActionResult where T : ICommand
    {
        private readonly T command;
        private readonly string successMessage;
        private readonly ICommandHandler<T> handler;
        private readonly ICommandValidator<T> validator;


        public JsonFormActionResult(T command, string successMessage)
        {
            this.command = command;
            this.successMessage = successMessage;

            validator = DependencyResolver.Current.GetService<ICommandValidator<T>>();
            handler = DependencyResolver.Current.GetService<ICommandHandler<T>>();
        }


        public override void ExecuteResult(ControllerContext context)
        {
            var returnModel = new JsonReturnModel();
            var jsonResult = new JsonResult();

            if (validator.IsValid(command))
            {
                try
                {
                    handler.Handle(command);
                    returnModel.Success = true;
                    returnModel.SuccessMessage = successMessage;
                }
                catch (DomainException domainException)
                {
                    returnModel.Success = false;
                    returnModel.FailureMessage = domainException.Message;
                }
                catch (Exception exception)
                {
                    returnModel.Success = false;
                    returnModel.FailureMessage = "Unable to process command";
                }
            }
            else
            {
                var errors = validator.Errors.ToString();
                returnModel.FailureMessage = errors;
                returnModel.Success = false;
            }

            jsonResult.Data = returnModel;
            jsonResult.ExecuteResult(context);
        }
    }


    public class JsonReturnModel
    {
        public String SuccessMessage { get; set; }
        public String FailureMessage { get; set; }
        public bool Success { get; set; }
    }
}