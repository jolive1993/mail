﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public class Envelope : Mail
    {
        public Envelope(double weight, int id)
        {
            this.weight = 0;
            this.id = 0;
        }
    }
}
