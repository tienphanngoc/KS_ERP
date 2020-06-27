using KSERP.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Utilities
{
    public class Notification
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public bool SentBySystem { get; set; }
        public bool SentByAdminstrator { get; set; }
        public int ReceiverId { get; set; }
        public string Message { get; set; }
        public DateTime CreateAt { get; set; }
        public MessageStatus Status { get; set; }
        public DateTime LastChangedStatus { get; set; }
        public Notification()
        {
            SenderId = -1;
            CreateAt = DateTime.Now;
            Status = MessageStatus.DRAFT;
            LastChangedStatus = DateTime.Now;
        }
    }
}
