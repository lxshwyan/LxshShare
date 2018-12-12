using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using SqlSugar;

using System.Linq.Expressions;
using Lxsh.Project.CountingService;

namespace Lxsh.Project.Bussiness.Service
{
   public  class UserService:BaseService
    {
        #region Identity
        protected SqlSugarClient dbSqlClent = CreateDBInstance.GetInstance();
        /// <summary>
        /// 
        /// </summary>
        public UserService()
        {
            base.baseDbSqlClent = dbSqlClent;
        }
        #endregion Identity

    }
}
