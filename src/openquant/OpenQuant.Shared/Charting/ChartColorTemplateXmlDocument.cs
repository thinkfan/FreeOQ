﻿using FreeQuant.Xml;

namespace OpenQuant.Shared.Charting
{
    class ChartColorTemplateXmlDocument : XmlDocumentBase
    {
        private const string ATTR_NAME = "name";

        public string TemplateName
        {
            get
            {
                return this.GetStringAttribute(ATTR_NAME);
            }
            set
            {
                this.SetAttribute(ATTR_NAME, value);
            }
        }

        public PropertyListXmlNode Properties
        {
            get
            {
                return this.GetChildNode<PropertyListXmlNode>();
            }
        }

        public ChartColorTemplateXmlDocument() : base("template", "chart color template file")
        {
        }
    }
}
