﻿/*******************************************************
 * 
 * 作者：胡庆访
 * 创建时间：20110426
 * 说明：此文件只包含一个类，具体内容见类型注释。
 * 运行环境：.NET 4.0
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20110426
 * 
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;

namespace Rafy.WPF
{
    public class WorkspaceWindowClosingEventArgs : CancelEventArgs
    {
        public WorkspaceWindowClosingEventArgs(WorkspaceWindow window)
        {
            this.Window = window;
        }

        public WorkspaceWindow Window { get; private set; }
    }
}
