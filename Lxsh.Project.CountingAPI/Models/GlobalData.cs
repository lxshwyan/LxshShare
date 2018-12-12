using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lxsh.Project.CountingAPI
{
    /// <summary>
    /// 全局数据
    /// </summary>
    public static class GlobalData
    {
        /// <summary>
        /// XML文件存储路径
        /// </summary>
        public static string m_XmlPath = "";
        /// <summary>
        /// 设备编码信息
        /// </summary>
        //public static DataTable DeviceInfo;
        /// <summary>
        /// 罪犯信息
        /// </summary>
        //public static DataTable CriminalInfo;
        /// <summary>
        /// 罪犯照片地址
        /// </summary>
        public static string CriminalPhotoUrl;
        /// <summary>
        /// 当前互监清点的时间
        /// </summary>
        public static Dictionary<string, DateTime?> otherTime = new Dictionary<string, DateTime?>();
        /// <summary>
        /// 当前需要互监清点
        /// </summary>
        public static Dictionary<string, int> otherCount = new Dictionary<string, int>();
        /// <summary>
        /// 清点名单
        /// </summary>
        public static Dictionary<string, List<string>> CountList = new Dictionary<string, List<string>>();
       
    }
}