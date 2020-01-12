using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    interface IKurs
    {
        string kursNamn { get; set; }

        DateTime startDatum { get; set; }
        DateTime slutDatum { get; set; }
        string möjligaBetyg { get; set; }
        string kursID { get; set; }
        string lärarlagID { get; set; }
        string slutbetyg { get; set; }

    }
}
