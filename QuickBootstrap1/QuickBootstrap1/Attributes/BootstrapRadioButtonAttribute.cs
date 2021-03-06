﻿using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace QuickBootstrap1.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class BootstrapRadioButtonAttribute : BootstrapInputAttribute
    {
        public override MvcHtmlString Generate(HtmlHelper htmlHelper, string name, object value)
        {
            return htmlHelper.RadioButton(name, value, new { @class = CssClass, style = CssStyle });
        }
    }
}