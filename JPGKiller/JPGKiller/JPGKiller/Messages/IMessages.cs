using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPGKiller.Messages
{
    interface IMessages
    {
        bool SentInfoMessage(string mess, string fontName, float fontSize);
        bool SentInfoMessage(string mess, string fontName);
        bool SentInfoMessage(string mess);

        bool SentSuccMessage(string mess, string fontName, float fontSize);
        bool SentSuccMessage(string mess, string fontName);
        bool SentSuccMessage(string mess);

        bool SentErrorMessage(string mess, string fontName, float fontSize);
        bool SentErrorMessage(string mess, string fontName);
        bool SentErrorMessage(string mess);
    }
}
