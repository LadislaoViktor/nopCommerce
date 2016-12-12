﻿using System.Collections.Generic;
using Nop.Core.Configuration;

namespace Nop.Core.Domain.Common
{
    public class CommonSettings : ISettings
    {
        public CommonSettings()
        {
            SitemapCustomUrls = new List<string>();
            IgnoreLogWordlist = new List<string>();
        }

        public bool SubjectFieldOnContactUsForm { get; set; }
        public bool UseSystemEmailForContactUsForm { get; set; }

        public bool UseStoredProceduresIfSupported { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sitemap is enabled
        /// </summary>
        public bool SitemapEnabled { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether to include categories to sitemap
        /// </summary>
        public bool SitemapIncludeCategories { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether to include manufacturers to sitemap
        /// </summary>
        public bool SitemapIncludeManufacturers { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether to include products to sitemap
        /// </summary>
        public bool SitemapIncludeProducts { get; set; }
        /// <summary>
        /// A list of custom URLs to be added to sitemap.xml (include page names only)
        /// </summary>
        public List<string> SitemapCustomUrls { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to display a warning if java-script is disabled
        /// </summary>
        public bool DisplayJavaScriptDisabledWarning { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether full-text search is supported
        /// </summary>
        public bool UseFullTextSearch { get; set; }

        /// <summary>
        /// Gets or sets a Full-Text search mode
        /// </summary>
        public FulltextSearchMode FullTextMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 404 errors (page or file not found) should be logged
        /// </summary>
        public bool Log404Errors { get; set; }

        /// <summary>
        /// Gets or sets a breadcrumb delimiter used on the site
        /// </summary>
        public string BreadcrumbDelimiter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether we should render <meta http-equiv="X-UA-Compatible" content="IE=edge"/> tag
        /// </summary>
        public bool RenderXuaCompatible { get; set; }

        /// <summary>
        /// Gets or sets a value of "X-UA-Compatible" META tag
        /// </summary>
        public string XuaCompatibleValue { get; set; }

        /// <summary>
        /// Gets or sets ignore words (phrases) to be ignored when logging errors/messages
        /// </summary>
        public List<string> IgnoreLogWordlist { get; set; }
    }
}