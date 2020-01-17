/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// GetTransacEmailContent
    /// </summary>
    [DataContract]
    public partial class GetTransacEmailContent :  IEquatable<GetTransacEmailContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacEmailContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransacEmailContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacEmailContent" /> class.
        /// </summary>
        /// <param name="email">Email address to which transactional email has been sent (required).</param>
        /// <param name="subject">Subject of the sent email (required).</param>
        /// <param name="templateId">Id of the template.</param>
        /// <param name="date">Date on which transactional email was sent (required).</param>
        /// <param name="events">Series of events which occurred on the transactional email (required).</param>
        /// <param name="body">Actual content of the transactional email that has been sent (required).</param>
        /// <param name="attachmentCount">Count of the attachments that were sent in the email (required).</param>
        public GetTransacEmailContent(string email = default(string), string subject = default(string), long? templateId = default(long?), DateTime? date = default(DateTime?), List<GetTransacEmailContentEvents> events = default(List<GetTransacEmailContentEvents>), string body = default(string), long? attachmentCount = default(long?))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for GetTransacEmailContent and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for GetTransacEmailContent and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for GetTransacEmailContent and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new InvalidDataException("events is a required property for GetTransacEmailContent and cannot be null");
            }
            else
            {
                this.Events = events;
            }
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for GetTransacEmailContent and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            // to ensure "attachmentCount" is required (not null)
            if (attachmentCount == null)
            {
                throw new InvalidDataException("attachmentCount is a required property for GetTransacEmailContent and cannot be null");
            }
            else
            {
                this.AttachmentCount = attachmentCount;
            }
            this.TemplateId = templateId;
        }
        
        /// <summary>
        /// Email address to which transactional email has been sent
        /// </summary>
        /// <value>Email address to which transactional email has been sent</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Subject of the sent email
        /// </summary>
        /// <value>Subject of the sent email</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Id of the template
        /// </summary>
        /// <value>Id of the template</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// Date on which transactional email was sent
        /// </summary>
        /// <value>Date on which transactional email was sent</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Series of events which occurred on the transactional email
        /// </summary>
        /// <value>Series of events which occurred on the transactional email</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<GetTransacEmailContentEvents> Events { get; set; }

        /// <summary>
        /// Actual content of the transactional email that has been sent
        /// </summary>
        /// <value>Actual content of the transactional email that has been sent</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Count of the attachments that were sent in the email
        /// </summary>
        /// <value>Count of the attachments that were sent in the email</value>
        [DataMember(Name="attachmentCount", EmitDefaultValue=false)]
        public long? AttachmentCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransacEmailContent {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  AttachmentCount: ").Append(AttachmentCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetTransacEmailContent);
        }

        /// <summary>
        /// Returns true if GetTransacEmailContent instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransacEmailContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransacEmailContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.AttachmentCount == input.AttachmentCount ||
                    (this.AttachmentCount != null &&
                    this.AttachmentCount.Equals(input.AttachmentCount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.AttachmentCount != null)
                    hashCode = hashCode * 59 + this.AttachmentCount.GetHashCode();
                return hashCode;
            }
        }
    }

}
