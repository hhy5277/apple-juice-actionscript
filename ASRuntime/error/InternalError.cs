﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASRuntime.error
{
    /// <summary>
    /// 内部操作错误
    /// </summary>
    public class InternalError
    {
        public ASBinCode.SourceToken token;

        public string message;

        public int errorCode;


        public ASBinCode.IRunTimeValue errorValue;

        internal Stack<StackFrame> callStack;

        public InternalError(ASBinCode.SourceToken token,string message)
        {
            this.token = token;
            this.message = message;
            this.errorValue = null;
        }
        /// <summary>
        /// 是否可被捕获的异常
        /// </summary>
        public bool catchable
        {
            get { return  errorValue != null; }
        }


        public InternalError(ASBinCode.SourceToken token, string message ,ASBinCode.IRunTimeValue errorValue )
        {
            this.token = token;
            this.message = message;
            this.errorValue = errorValue;
        }

        public InternalError(ASBinCode.SourceToken token, ASBinCode.IRunTimeValue errorValue)
        {
            this.token = token;
            this.errorValue = errorValue;
            if (errorValue != null)
            {
                this.message = errorValue.ToString();
            }
        }

    }
}
