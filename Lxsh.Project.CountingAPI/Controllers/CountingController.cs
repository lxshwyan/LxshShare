using System;
using System.Collections.Generic;
using System.Linq;

using System.Data;

using System.Data.SqlClient;
using System.IO;
using System.Xml;

using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using Lxsh.Project.CountingCommon;

namespace Lxsh.Project.CountingAPI.Controllers
{
   
    /// <summary>
    /// 人员工具清点API
    // </summary>  
    public class CountingController : ApiController
    {
        #region 批次
        private List<string> PlanTime = new List<string>() {
                   "08:00:00"
                ,  "09:00:00"
                ,  "10:00:00"
                ,  "11:00:00"
                ,  "12:00:00"
                ,  "13:00:00"
                ,  "14:00:00"
                ,  "15:00:00"
                ,  "16:00:00"
                ,  "17:00:00"
                ,  "18:00:00"
                ,  "19:00:00"
                ,  "20:00:00"
                ,  "21:00:00"
            };
        /// <summary>
        /// 根据时间获取批次时间
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private string GetTime(DateTime date)
        {
            //民警清点的时间
            var datenow = date.ToString("yyyy-MM-dd");

            var ret = PlanTime.AsEnumerable().Where(c => Convert.ToDateTime(datenow + " " + c) > DateTime.Now);
            if (ret.Count() > 0)
            {
                return ret.ToArray()[0].ToString();
            }
            if (date.Hour < 8)
            {
                return datenow + " " + PlanTime[0];
            }
            return datenow + " " + PlanTime[PlanTime.Count - 1];
        }
        private DateTime GetCurrentTime()
        {
            return DateTime.Parse(GetTime(DateTime.Now));
        }
        private int GetIndexTime(DateTime date)
        {
            //民警清点的时间
            var datenow = date.ToString("yyyy-MM-dd");

            for (int i = 0; i < PlanTime.Count; i++)
            {
                if (Convert.ToDateTime(datenow + " " + PlanTime[i]) >= date)
                {
                    return i;
                }
            }
            if (date.Hour < 8)
            {
                return 0;
            }
            return PlanTime.Count - 1;
        }
        #endregion
        private static Logger logger = Logger.CreateLogger(typeof(CountingController));
        /// <summary>
        /// 测试
        /// </summary>
        /// <returns></returns>    
        public IHttpActionResult get()
        {
            string str = "1111";

            return Ok(new { status = 1, data = str });
        }
        /// <summary>
        /// 设置罪犯清点完成,生成新批次
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult OffenderCounted(string departmentID)
        {
            try
            {
                if (GlobalData.otherTime.ContainsKey(departmentID))
                {
                    //设置departmentID罪犯清点完成
                    logger.Info(logger.GetMethodInfo() + $":设置{departmentID}罪犯清点完成");
                    GlobalData.otherTime[departmentID] = null;
                }
                return Ok(new { status = 1 });
            }
            catch (Exception ex)
            {

                return Ok(new { status = 0, error = ex.Message });
            }
        }

        /// <summary>
        /// 返回服务器时间
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult SystemTime()
        {
            return Ok(new { status = 1, data = DateTime.Now.ToString() });
        }
        /// <summary>
        /// 发送消息到指定的IP端口
        /// </summary>
        /// <param name="strIP"></param>
        /// <param name="nPort"></param>
        /// <param name="strMsg"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult UDPSendMsg(string strIP, int nPort, string strMsg)
        {
            try
            {
                SocketMessageMng sm = new SocketMessageMng();

                sm.UdpSendMsg(strIP, nPort, strMsg);

                sm.Dis();
                return Ok(new { status = 1, data = true });
            }
            catch (Exception ex)
            {
                return Ok(new { status = 1, data = false });
            }
        }

        /// <summary>
        /// 保存xml文件
        /// </summary>
        /// <param name="strXmlPath">文件路径，例：20180507\08-00</param>
        /// <param name="strXmlName">文件名称，例：测试</param>
        /// <param name="strXmlInfo">文件内容，xml格式</param>
        ///  <param name="isSendMsg">是否发生UDP消息1-发送 0-不发送</param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult XmlSave(string strXmlPath, string strXmlName, string strXmlInfo, string isSendMsg = "1")
        {
            try
            {
                if (!Directory.Exists(GlobalData.m_XmlPath + strXmlPath))
                    Directory.CreateDirectory(GlobalData.m_XmlPath + strXmlPath);

                StreamWriter sw = new StreamWriter(GlobalData.m_XmlPath + strXmlPath + "\\" + strXmlName + ".xml", false);
                sw.Write(strXmlInfo);
                sw.Close();
                sw.Dispose();

               

                return Ok(new { status = 1, data = "成功", path = GlobalData.m_XmlPath + strXmlPath + "\\" + strXmlName + ".xml" });
            }
            catch (Exception ex)
            {
                return Ok(new { status = 0, data = "失败", error = ex.Message });
            }
        }
    }
}