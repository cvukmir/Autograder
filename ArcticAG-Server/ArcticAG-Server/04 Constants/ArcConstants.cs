using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcticAG_Admin
{
    static class ArcConstants
    {
        // Program execution
        public const string EXEC_BAT_FILE = "__exec_bat_file.bat";
        public const string CPP_FILE_EXT  = ".cpp";
        public const string JAVA_FILE_EXT = ".java";

        // TCP codes
        public const string TCP_CODE_LOGIN          = "LGN";
        public const string TCP_CODE_LOGIN_APPROVED = "APR";
        public const string TCP_CODE_LOGIN_DENIED   = "DEN";
        public const string TCP_CODE_SEND_DATA      = "SND";
        public const string TCP_FILE_SPLIT_DELIM    = "*%/_";
    }
}
