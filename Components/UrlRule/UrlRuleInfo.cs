#region Copyright
// 
// DotNetNukeŽ - http://www.dotnetnuke.com
// Copyright (c) 2002-2012
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion
#region Usings

using System;
using Satrabel.HttpModules.Provider;

#endregion

namespace Satrabel.Services.Log.UrlRule
{
    [Serializable]
    public class UrlRuleInfo
    {
        
        public int UrlRuleId { get; set; }
        public DateTime DateTime { get; set; }
        public int RuleType { get; set; }

        public UrlRuleType RuleTypeEnum
        { 
            get 
            {
                return (UrlRuleType)RuleType;        
            } 
        }
        public string RuleTypeString
        {
            get
            {
                return ((UrlRuleType)RuleType).ToString();
            }
        }

        public int UserId { get; set; }
        public string CultureCode { get; set; }
        public int PortalId { get; set; }
        public int TabId { get; set; }
        public string Parameters { get; set; }
        public bool RemoveTab { get; set; }
        public int RuleAction { get; set; }
        public UrlRuleAction RuleActionEnum
        {
            get
            {
                return (UrlRuleAction)RuleAction;
            }
        }
        public string RuleActionString
        {
            get
            {
                return ((UrlRuleAction)RuleAction).ToString();
            }
        }

        public string Url { get; set; }
        public string RedirectDestination { get; set; }
        public int RedirectStatus { get; set; }
    }
}