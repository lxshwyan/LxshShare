using System;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using log4net.Config;
using log4net;     
using System.Collections.Generic;
using log4net.Repository;
using System.Reflection;

namespace Lxsh.Project.CountingCommon
{
    public class Logger
    {

        static Logger()
        {
            XmlConfigurator.Configure(new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CfgFiles\\log4net.Config")));
            ILog Log = LogManager.GetLogger(typeof(Logger));
            Log.Info("系统初始化Logger模块");
        }

        private ILog loger = null;
        private Logger(Type type)
        {
            loger = LogManager.GetLogger(type);
        }

        /// <summary>
        /// 创建Logger
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Logger CreateLogger(Type type)
        {
            return new Logger(type);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public void Error(string msg = "出现异常", Exception ex = null)
        {
            Console.WriteLine(msg);
            loger.Error(msg, ex);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        public void Warn(string msg)
        {
            Console.WriteLine(msg);
            loger.Warn(msg);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        public void Info(string msg)
        {
            Console.WriteLine(msg);
            loger.Info(msg);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        public void Debug(string msg)
        {
            Console.WriteLine(msg);
            loger.Debug(msg);
        }

        //清理日志文件
        public  void CleanLogs(int days)
        {
            try
            {
                string logFilePath = "Logs";
                if (!Directory.Exists(logFilePath)) return;
                DirectoryInfo folder = new DirectoryInfo(logFilePath);
                foreach (FileInfo file in folder.GetFiles("*.txt"))
                {
                    if (!File.Exists(file.FullName)) continue;
                    if (file.CreationTime < DateTime.Now.AddDays(-1 * days))
                        File.Delete(file.FullName);
                }
            }
            catch (Exception ex)
            {
                loger.Info($"清理日志文件时发生错误:{ ex.ToString()}");
            }
        }
        public  string GetMethodInfo()
        {
            string str = "";
            ////取得当前方法命名空间
            //str += "命名空间名:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace + "\n";
            ////取得当前方法类全名
            //str += "类名:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName + "\n";
            ////取得当前方法名
            //str += "方法名:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n";
            //str += "\n";

            StackTrace ss = new StackTrace(true);
            MethodBase mb = ss.GetFrame(1).GetMethod();
            ////取得父方法命名空间
            //str += mb.DeclaringType.Namespace + ".";
            ////取得父方法类名
            //str += mb.DeclaringType.Name + ".";
            //取得父方法类全名
            str += mb.DeclaringType.FullName + ".";
            //取得父方法名
            str += mb.Name + ":";
            return str;
        }
    }
}
