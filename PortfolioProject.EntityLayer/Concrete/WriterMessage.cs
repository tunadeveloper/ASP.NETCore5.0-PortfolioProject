﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.EntityLayer.Concrete
{
    public class WriterMessage
    {
        [Key]
        public int WriterMessageID { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
