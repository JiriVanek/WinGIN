﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GinClientLibrary
{
    [DataContract]
    public class ServerConf
    {
        [DataMember]
        public WebCfg Web { get; set; }
        [DataMember]
        public GitCfg Git { get; set; }
    }

    public class WebCfg
    {
        [DataMember]
        public string Protocol { get; set; }
        [DataMember]
        public string Host { get; set; }
        [DataMember]
        public string Port { get; set; }
    }
    public class GitCfg
    {
        [DataMember]
        public string User { get; set; }
        [DataMember]
        public string Host { get; set; }
        [DataMember]
        public string Port { get; set; }
        [DataMember]
        string HostKey { get; set; }
    }
}
