﻿using XMLApp.Application.Abstraction;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLApp.Infrastructure;
using XMLApp.Utils;

namespace XMLApp.Application
{
    public abstract class ServiceBase : IService
    {

        public MainContext MainContext { get; set; }

        public DbSession DbSession { get; set; }


        private Logger logger = LogManager.GetCurrentClassLogger();
        protected void LogTrace(string msg)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            logger.Trace(string.Format(Loggers.LogFormat, DateTime.Now.ToDateTimeStringSafe(), this.GetType().Name, sf.GetMethod().Name, msg));
        }

        protected void LogInfo(string msg)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            logger.Info(string.Format(Loggers.LogFormat, DateTime.Now.ToDateTimeStringSafe(), this.GetType().Name, sf.GetMethod().Name, msg));
        }

        protected void LogError(string msg, Exception ex)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            logger.Error(ex, string.Format(Loggers.LogFormat, DateTime.Now.ToDateTimeStringSafe(), this.GetType().Name, sf.GetMethod().Name, msg));
        }

        protected void LogDebug(string msg)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            logger.Debug(string.Format(Loggers.LogFormat, DateTime.Now.ToDateTimeStringSafe(), this.GetType().Name, sf.GetMethod().Name, msg));
        }

        protected void LogWarn(string msg)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            logger.Warn(string.Format(Loggers.LogFormat, DateTime.Now.ToDateTimeStringSafe(), this.GetType().Name, sf.GetMethod().Name, msg));
        }
    }
}
