﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkovbakkenWebsite.Models
{
    public class Request
    {
        private int _id;
        private DateTime _timeSent;
        public DateTime TimeSent
        {
            get
            {
                return _timeSent;
            }
        }

        private Worker _worker;
        public Worker Worker
        {
            get
            {
                return _worker;
            }
        }

        public Request(Worker worker)
        {
            _timeSent = DateTime.Now;
            _worker = worker;
        }
    }
}