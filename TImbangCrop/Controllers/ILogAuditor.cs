using System;
using System.Collections.Generic;
using System.Text;

namespace TimbangCrop.Controllers
{
    public interface ILogAuditor
    {
        void LogTransaction(string idTimbangan, string status, string pesanDetail);
    }
}
