using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkovbakkenWebsite.Models
{
    public class ExternalWorker : Worker
    {
        public ExternalWorker(string name, string email) : base(name, email)
        {

        }
    }
}