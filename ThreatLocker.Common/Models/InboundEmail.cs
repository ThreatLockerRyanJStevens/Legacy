using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class InboundEmail
    {

        public Guid InboundEmailID { get; set; }
        /// <summary>
        /// These are the email headers as an array of JSON objects of keys and values.
        /// </summary>
        [JsonProperty("headers")]
        public InboundEmailHeaders Headers { get; set; }

        /// <summary>
        /// This is the message envelope. The details that cloudmailin server receives from the sending server.
        /// </summary>
        [JsonProperty("envelope")]
        public InboundEmailEnvelope Envelope { get; set; }

        /// <summary>
        /// The email body as plain-text.
        /// </summary>
        public string Plain { get; set; }

        [JsonProperty("reply_plain")]
        public string ReplyPlain { get; set; }

        /// <summary>
        /// The email as HTML (if a HTML version is available).
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// The message attachments.
        /// </summary>
        [JsonProperty("attachments")]
        public List<InboundEmailAttachment> Attachments { get; set; }
    }

    /// <summary>
    /// The envelope contains the data sent or gathered from the remote server. It doesn't contain any of the message 
    /// content. It contains details of the transaction that took place between the sending server and CloudMailin.
    /// </summary>
    public class InboundEmailEnvelope
    {
        /// <summary>
        /// The email address the server is sending to. Note this might not always be the address within the 
        /// message headers. For that reason you should also look at the headers parameter.
        /// </summary>
        [JsonProperty("to")]
        public string EnvelopeTo { get; set; }

        /// <summary>
        /// The full list of recipients that the remote server is attempting to send to in this transaction.
        /// </summary>
        public List<string> Recipients { get; set; }

        /// <summary>
        /// The email address that the server was sending from. Note this might not always be the address 
        /// within the message headers. For that reason you should also look at the headers parameter.
        /// </summary>
        [JsonProperty("from")]
        public string Sender { get; set; }

        /// <summary>
        /// The SPF result for the given IP address and Domain.
        /// </summary>
        public Spf Spf { get; set; }
    }

    /// <summary>
    /// These are the email headers as an array of JSON objects of keys and values.
    /// </summary>
    public class InboundEmailHeaders
    {
        //public string Return_path { get; set; }
        public List<string> Received { get; set; }
        //public DateTime Date { get; set; }

        [JsonProperty("from")]
        public string Sender { get; set; }

        public string CC { get; set; }

        public string BCC { get; set; }

        [JsonProperty("to")]
        public string HeaderTo { get; set; }
        public string Message_id { get; set; }

        public string Subject { get; set; }
    }

    /// <summary>
    /// Attachments in the new message formats come in three different forms:
    /// No Attachments       : If there are no attachments then an empty array will always be passed to the attachments parameter.
    /// URL Attachments      : URL Attachments are attachments that have been sent to an attachment store. In these cases 
    ///                        the message content is stored remotely and a URL to the attachment plus the attachment details are provided.
    /// Embedded Attachments : With embedded attachments the attachment content is passed in base-64 encoding to the content parameter of the attachment
    /// </summary>
    public class InboundEmailAttachment
    {
        /// <summary>
        /// The content of the attachment in base-64 encoding, if the message isn't using an attachment store.
        /// </summary>
        [JsonProperty("content")]
        public string AttachmentContent { get; set; }

        /// <summary>
        /// A URL to the attachment if the attachment is within an attachment store.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The original file name of the attachment.
        /// </summary>
        public string File_name { get; set; }

        /// <summary>
        /// The content type of the attachment.
        /// </summary>
        public string Content_type { get; set; }

        /// <summary>
        /// The size of the attachment.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// The disposition of the attachment either attachment or inline
        /// </summary>
        public string Disposition { get; set; }

        /// <summary>
        /// The id of the attachment if it's inline. This can be used to display inline images for example.
        /// </summary>
        public string Content_id { get; set; }
    }

    /// <summary>
    /// SPF (or Sender Policy Framework) is a method of ensuring that the IP address connecting to your server is allowed to 
    /// send email for a given domain. SPF ensures that a given user has permission to send emails on behalf of the domain 
    /// of the email address they're sending from.
    /// </summary>
    public class Spf
    {
        /// <summary>
        /// The result of the SPF check
        /// There are several states that can be returned as a result of an SPF check:
        /// none     : no records were published by the domain or that the domain couldn't be determined
        /// neutral  : The domain owner has explicitly stated that he cannot or does not want to assert whether or not the IP address is authorized.
        /// pass     : the client is authorized to inject mail with the given identity.
        /// fail     : the client is not authorized to use the domain in the given identity.
        /// softfail : treated as somewhere between a "Fail" and a "Neutral". The domain believes the host is not authorized but is not willing to make that strong of a statement.
        /// temperror: A temporary error was encountered.
        /// permerror: A permenant error was encountered.
        /// </summary>
        //public string Result { get; set; }

        /// <summary>
        /// The domain used to perform the SPF check. This will be the domain in the from address. However, if 
        /// there is no domain in the from address then the helo_domain will be used instead.
        /// </summary>
        //public string Domain { get; set; }
    }
}
