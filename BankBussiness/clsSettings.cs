using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class clsSettings
    {
      public enum enPermissions
        {
 eAll = -1,eClientList = 1,eAddClient = 2,eUpdateClient = 4,
 eDeleteClient = 8,eFindClient  = 16,
 eTransAction = 32,eManageUser = 64,
 eTransfer  = 128
        }
    }
}
