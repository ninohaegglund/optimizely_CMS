﻿using System.ComponentModel.DataAnnotations;

namespace Optimizely_CMS.Business
{
    public class Globals
    {
        [GroupDefinitions]
        public static class GroupNames
        {
            [Display(
                Name = "Metadata",
                Order = 40
            )]
            public const string MetaData = "Metadata";

            [Display(
                Name = "Specialized",
                Order = 90
            )]
            public const string Specialized = "Specialized";
        }
    }
}