using System;
using AmvReporting.Infrastructure.CQRS;
using Raven.Client;

namespace AmvReporting.Domain.ReportGroups.Commands
{
    public class EditReportGroupCommand : ICommand
    {
        public String Id { get; set; }
        public String Title { get; set; }
    }


    public class EditReportGroupCommandHandler : ICommandHandler<EditReportGroupCommand>
    {
        private readonly IDocumentSession ravenSession;

        public EditReportGroupCommandHandler(IDocumentSession ravenSession)
        {
            this.ravenSession = ravenSession;
        }

        public void Handle(EditReportGroupCommand command)
        {
            var reportGroup = ravenSession.Load<ReportGroup>(command.Id);
            reportGroup.Title = command.Title;
            ravenSession.SaveChanges();
        }
    }
}