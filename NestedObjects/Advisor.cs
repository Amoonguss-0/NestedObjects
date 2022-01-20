﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a college advisor
    /// </summary>
    internal class Advisor
    {
        /// <summary>
        /// Advisors full legal name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Advisors work email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Building and room number of the office
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}
