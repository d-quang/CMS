﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace Kooboo.CMS.Common.Extension
{
    public interface IApplyToMatcher
    {
        IEnumerable<T> Match<T>(IEnumerable<T> applyToItems, RouteData route)
        where T : IApplyTo;
    }
}
