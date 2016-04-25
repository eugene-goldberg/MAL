namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BusinessObjects.MALDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BusinessObjects.MALDbContext context)
        {
           
       //     context.ChangeMeasures.Add(
       //         new UDM.ChangeMeasure {
       //             AccountID = "AON-123",
       //             MeasureName = "Changes Performed",
       //             Value = 3,
       //             Justification = ""
       //         });
       //     context.ChangeMeasures.Add(
       //        new UDM.ChangeMeasure
       //        {
       //            AccountID = "AON-123",
       //            MeasureName = "Changes Successful",
       //            Value = 3,
       //            Justification = ""
       //        });
       //     context.ChangeMeasures.Add(
       //        new UDM.ChangeMeasure
       //        {
       //            AccountID = "AON-123",
       //            MeasureName = "# Emergency Changes",
       //            Value = 3,
       //            Justification = ""
       //        });
       //     context.ChangeMeasures.Add(
       //        new UDM.ChangeMeasure
       //        {
       //            AccountID = "AON-123",
       //            MeasureName = "% Emergency Changes",
       //            Value = 3,
       //            Justification = ""
       //        });
       //     context.ChangeMeasures.Add(
       //       new UDM.ChangeMeasure
       //       {
       //           AccountID = "AON-123",
       //           MeasureName = "# of Process Defect in failed changes",
       //           Value = 3,
       //           Justification = ""
       //       });
       //     context.ChangeMeasures.Add(
       //       new UDM.ChangeMeasure
       //       {
       //           AccountID = "AON-123",
       //           MeasureName = "% Process defects in changes",
       //           Value = 3,
       //           Justification = ""
       //       });
       //     context.ChangeMeasures.Add(
       //      new UDM.ChangeMeasure
       //      {
       //          AccountID = "AON-123",
       //          MeasureName = "#  Urgent / Expedited /Alert Changes",
       //          Value = 3,
       //          Justification = ""
       //      });
       //     context.ChangeMeasures.Add(
       //      new UDM.ChangeMeasure
       //      {
       //          AccountID = "AON-123",
       //          MeasureName = "% Urgent / Expedited /Alert Changes",
       //          Value = 3,
       //          Justification = ""
       //      });
       //     context.ChangeMeasures.Add(
       //     new UDM.ChangeMeasure
       //     {
       //         AccountID = "AON-123",
       //         MeasureName = "#  of Unclosed Changes",
       //         Value = 3,
       //         Justification = ""
       //     });
       //     context.ChangeMeasures.Add(
       //   new UDM.ChangeMeasure
       //   {
       //       AccountID = "AON-123",
       //       MeasureName = "%  of Unclosed Changes",
       //       Value = 3,
       //       Justification = ""
       //   });
       //     context.ChangeMeasures.Add(
       // new UDM.ChangeMeasure
       // {
       //     AccountID = "AON-123",
       //     MeasureName = "% of failed changes",
       //     Value = 3,
       //     Justification = ""
       // });
       //     context.ChangeMeasures.Add(
       //new UDM.ChangeMeasure
       //{
       //    AccountID = "AON-123",
       //    MeasureName = "# Changes lead to major Incidents",
       //    Value = 3,
       //    Justification = ""
       //});
       //     context.ChangeMeasures.Add(
       //   new UDM.ChangeMeasure
       //   {
       //       AccountID = "AON-123",
       //       MeasureName = "# Problem opened",
       //       Value = 3,
       //       Justification = ""
       //   });
       //     context.ChangeMeasures.Add(
       //   new UDM.ChangeMeasure
       //   {
       //       AccountID = "AON-123",
       //       MeasureName = "# Problem Closed",
       //       Value = 3,
       //       Justification = ""
       //   });
       //     context.ChangeMeasures.Add(
       //     new UDM.ChangeMeasure
       //     {
       //         AccountID = "AON-123",
       //         MeasureName = "#  Solutions derived from PR  (RC)",
       //         Value = 3,
       //         Justification = ""
       //     });
       //     context.ChangeMeasures.Add(
       //     new UDM.ChangeMeasure
       //     {
       //         AccountID = "AON-123",
       //         MeasureName = "% of Problem resolved with Root Cause",
       //         Value = 3,
       //         Justification = ""
       //     });
       //     context.ChangeMeasures.Add(
       //    new UDM.ChangeMeasure
       //    {
       //        AccountID = "AON-123",
       //        MeasureName = "Number of solutions implemented",
       //        Value = 3,
       //        Justification = ""
       //    });
       //     context.ChangeMeasures.Add(
       //      new UDM.ChangeMeasure
       //      {
       //          AccountID = "AON-123",
       //          MeasureName = "Number of repeated PR",
       //          Value = 3,
       //          Justification = ""
       //      });
       //     context.ChangeMeasures.Add(
       //     new UDM.ChangeMeasure
       //     {
       //         AccountID = "AON-123",
       //         MeasureName = "# of times RCA has been rejected",
       //         Value = 3,
       //         Justification = ""
       //     });
       //     context.ChangeMeasures.Add(
       //        new UDM.ChangeMeasure
       //        {
       //            AccountID = "AON-123",
       //            MeasureName = "P1 Count",
       //            Value = 3,
       //            Justification = ""
       //        });
       //     context.ChangeMeasures.Add(
       //        new UDM.ChangeMeasure
       //        {
       //            AccountID = "AON-123",
       //            MeasureName = "P2 Count",
       //            Value = 3,
       //            Justification = ""
       //        });
       //     context.ChangeMeasures.Add(
       //        new UDM.ChangeMeasure
       //        {
       //            AccountID = "AON-123",
       //            MeasureName = "MTTR Sev 1",
       //            Value = 3,
       //            Justification = ""
       //        });
       //     context.ChangeMeasures.Add(
       //        new UDM.ChangeMeasure
       //        {
       //            AccountID = "AON-123",
       //            MeasureName = "MTTR Sev 2",
       //            Value = 3,
       //            Justification = ""
       //        });


        }
    }
}
