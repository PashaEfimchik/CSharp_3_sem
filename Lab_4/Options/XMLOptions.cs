sing System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileWatcherService
{
    [Serializable]
    [XmlRoot(ElementName ="Options",Namespace ="")]
    class XmlOptions
    {
        [XmlElement("targetPath")]
        public string targetPath { get; set; }
        [XmlElement("sourcePath")]
        public string sourcePath { get; set; }
        [XmlElement("templogPath")]
        public string templogPath { get; set; }
        [XmlElement("encryptOptions")]
        public bool encryptOptions { get; set; }
        [XmlElement("archiveOptions")]
        public bool archiveOptions { get; set; }
        public XmlOptions() { }
        public XmlOptions(string _targetPath, string _sourcePath, string _templogPath, bool _encrypt, bool _archive)
        {
            targetPath = _targetPath;
            sourcePath = _sourcePath;
            templogPath = _templogPath;
            encryptOptions = _encrypt;
            archiveOptions = _archive;
        }

    }
}
