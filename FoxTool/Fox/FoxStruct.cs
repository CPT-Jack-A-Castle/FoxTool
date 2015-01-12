﻿using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox
{
    public abstract class FoxStruct : IFoxValue
    {
        public abstract void Read(Stream input);
        public abstract void Write(Stream output);
        public abstract int Size();
        public abstract void ResolveNames(Dictionary<ulong, string> nameMap);

        public XmlSchema GetSchema()
        {
            return null;
        }

        public abstract void ReadXml(XmlReader reader);
        public abstract void WriteXml(XmlWriter writer);
    }
}
