﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    abstract class MessageSender
    {
        public string From { get; set; }
        public MessageSender(string @from)
        {
            From = @from;
        }

        // Фабричный метод
        abstract public Message Send(string text);
    }
}
