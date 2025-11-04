using Accounting.DataLAyer.Context;
using Accounting.ViewModel.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{

    public class Account
    {
        public static ReportViewModel reportView()
        {
            ReportViewModel reportViewModel = new ReportViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime EndTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                var pay = db.GenericRepositorey.Get(t => t.TypeID == 2 && t.Datatime > StartTime && t.Datatime < EndTime).Select(t => t.Amount).ToList();
                var Recive = db.GenericRepositorey.Get(t => t.TypeID == 1 && t.Datatime > StartTime && t.Datatime < EndTime).Select(t => t.Amount).ToList();
                reportViewModel.Pay = pay.Sum();
                reportViewModel.Recive = Recive.Sum();
                reportViewModel.AccountBalamce = (Recive.Sum() - pay.Sum());
            }
            return reportViewModel;

        }
    }
}
