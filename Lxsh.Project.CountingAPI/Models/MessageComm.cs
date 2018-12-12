using Lxsh.Project.CountingCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Lxsh.Project.CountingAPI
{
    /// <summary>
    /// 清点消息控制类
    /// </summary>
    public class MessageComm
    {
        private static MessageComm _instance = null;
        private string strErrorInfo = "";
        private SocketMessageMng smSend;

        private MessageComm()
        {
            smSend = new SocketMessageMng();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public static MessageComm _init()
        {
            if (_instance == null)
                _instance = new MessageComm();

            return _instance;
        }

      
       
    }
}
