using System;
using System.Collections.Generic;
using RestSharp.Deserializers;
using System.Xml.Serialization;


namespace RestBasicProject.poco
{

    //[XmlRoot(ElementName = "collection", Namespace = "http://www.w3.org/2007/app")]
    ////[DeserializeAs(Name = "collection")]
    //public class Collection
    //{
    //    [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
    //    //[DeserializeAs(Name = "title")]
    //    public string Title { get; set; }
    //    [XmlAttribute(AttributeName = "href")]
    //    //[DeserializeAs(Name = "href")]
    //    public string Href { get; set; }
    //}

    //[XmlRoot(ElementName = "workspace", Namespace = "http://www.w3.org/2007/app")]
    ////[DeserializeAs(Name = "workspace")]
    //public class Workspace
    //{
    //    [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
    //    //[DeserializeAs(Name = "title")]
    //    public string Title { get; set; }
    //    [XmlElement(ElementName = "collection", Namespace = "http://www.w3.org/2007/app")]
    //    // [DeserializeAs(Name = "title")]
    //    public List<Collection> Collection { get; set; }
    //}

    //[XmlRoot(ElementName = "service", Namespace = "http://www.w3.org/2007/app")]
    ////[DeserializeAs(Name = "service")]
    //public class Service
    //{
    //     [XmlElement(ElementName = "workspace", Namespace = "http://www.w3.org/2007/app")]
    //    //[DeserializeAs(Name = "workspace")]
    //    public Workspace Workspace { get; set; }
    //    [XmlAttribute(AttributeName = "Text")]
    //    //[DeserializeAs(Name = "Text")]
    //    public string Text { get; set; }
    //     [XmlAttribute(AttributeName = "atom", Namespace = "http://www.w3.org/2000/Text/")]
    //    //[DeserializeAs(Name = "atom")]
    //    public string Atom { get; set; }
    //     [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/XML/1998/namespace")]
    //    //[DeserializeAs(Name = "base")]
    //    public string Base { get; set; }
    /* 
 Licensed under the Apache License, Version 2.0
 */
    [XmlRoot(ElementName = "CUSTOMERList")]
        public class CUSTOMERList
        {
        [XmlElement(ElementName = "href", Namespace = "http://www.w3.org/1999/xlink")]
            public string Href { get; set; }
        [XmlAttribute(AttributeName = "Text")]
        public string Text { get; set; }
        }

        [XmlRoot(ElementName = "INVOICEList")]
        public class INVOICEList
        {
            [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
            public string Href { get; set; }
        [XmlAttribute(AttributeName = "Text")]
        public string Text { get; set; }
        }

        [XmlRoot(ElementName = "ITEMList")]
        public class ITEMList
        {
            [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
            public string Href { get; set; }
        [XmlAttribute(AttributeName = "Text")]
        public string Text { get; set; }
        }

        [XmlRoot(ElementName = "PRODUCTList")]
        public class PRODUCTList
        {
            [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
            public string Href { get; set; }
        [XmlAttribute(AttributeName = "Text")]
        public string Text { get; set; }
        }

        [XmlRoot(ElementName = "resource")]
        public class Resource
        {
            [XmlElement(ElementName = "CUSTOMERList")]
            public CUSTOMERList CUSTOMERList { get; set; }
            [XmlElement(ElementName = "INVOICEList")]
            public INVOICEList INVOICEList { get; set; }
            [XmlElement(ElementName = "ITEMList")]
            public ITEMList ITEMList { get; set; }
            [XmlElement(ElementName = "PRODUCTList")]
            public PRODUCTList PRODUCTList { get; set; }
            [XmlAttribute(AttributeName = "xlink", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xlink { get; set; }
        }

    }



