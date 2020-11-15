﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiMay.RemoteControls.Core.Enum
{
    public enum ScreenReceivedKind
    {
        /// <summary>
        /// 逐行扫描完成
        /// </summary>
        Noninterlaced,
        /// <summary>
        /// 差异扫描
        /// </summary>
        Difference,
        /// <summary>
        /// 差异扫描完成
        /// </summary>
        DifferenceEnd
    }
}
