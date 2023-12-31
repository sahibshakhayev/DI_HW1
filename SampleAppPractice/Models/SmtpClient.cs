﻿using System.Diagnostics;

namespace SampleAppPractice.Models
{
    public class SmtpClient:IClient
    {
        private readonly SmtpSettings _settings;

        public SmtpClient(SmtpSettings settings)
        {
            _settings = settings;
        }

        internal void Send(SmtpMessage smtpMessage)
        {
            Debug.WriteLine("Message sent by SmtpClient.");
        }
    }

    public class SmtpMessage:IMessage
    {
        public string Body { get; internal set; }
    }
}
