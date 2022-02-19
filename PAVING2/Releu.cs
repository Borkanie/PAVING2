using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace PAVING2
{
    public class Releu
    {
        public bool Open { get; set; }

        public void Clicked()
        {
            Open = !Open;
        }
    }
}