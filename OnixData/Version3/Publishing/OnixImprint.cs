﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixData.Version3.Publishing
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OnixImprint
    {
        #region CONSTANTS
        public const int CONST_IMPRINT_ROLE_PROP = 1;
        #endregion

        public OnixImprint()
        {
            ImprintName = "";
        }

        private string imprintNameField;

        /// <remarks/>
        public string ImprintName
        {
            get
            {
                return this.imprintNameField;
            }
            set
            {
                this.imprintNameField = value;
            }
        }
    }
}
