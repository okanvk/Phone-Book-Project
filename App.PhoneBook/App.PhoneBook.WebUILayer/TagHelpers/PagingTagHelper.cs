﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.PhoneBook.WebUILayer.TagHelpers
{
    [HtmlTargetElement("product-list-pager")]
    public class PagingTagHelper : TagHelper
    {

        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }

        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }

        [HtmlAttributeName("current-department")]
        public int CurrentDepartment { get; set; }

        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("<ul class='pagination'>");

            for (int i = 1; i <= PageCount; i++)
            {
                stringBuilder.AppendFormat("<li class='{0}'>", i == CurrentPage ? "page-item active" : "page-item");
                stringBuilder.AppendFormat("<a class='page-link' href='/employee/index?page={0}&department={1}'>{2}</a>", i, CurrentDepartment, i);
                stringBuilder.AppendFormat("</li>");
            }
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }

    }
}
