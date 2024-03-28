using MRSTUW.BusinessLogic.Core;
using MRSTUW.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRSTUW.Domain.Entities.User;

namespace MRSTUW.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            throw new NotImplementedException();
        }
    }
}
