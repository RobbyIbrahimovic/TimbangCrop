using System;
using System.Collections.Generic;
using System.Text;
using TimbangCrop.Data;

namespace TimbangCrop.Controllers
{
    public class TransactionLogger : ILogAuditor
    {
        public void LogTransaction(string idTimbangan, string status, string pesanDetail)
        {
            string idLog = "LOG-" + DateTime.Now.Ticks.ToString().Substring(10);
            PenimbanganDAO.SimpanLog(idLog, idTimbangan, status, pesanDetail);
        }
    }
}