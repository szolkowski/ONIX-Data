﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixData.Version3.Publishing
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OnixPublisher
    {
        public OnixPublisher()
        {
            PublishingRole = -1;
            PublisherName  = "";
        }

        private int    publishingRoleField;
        private string publisherNameField;

        /// <remarks/>
        public int PublishingRole
        {
            get
            {
                return this.publishingRoleField;
            }
            set
            {
                this.publishingRoleField = value;
            }
        }

        /// <remarks/>
        public string PublisherName
        {
            get
            {
                return this.publisherNameField;
            }
            set
            {
                this.publisherNameField = value;
            }
        }
    }





}
