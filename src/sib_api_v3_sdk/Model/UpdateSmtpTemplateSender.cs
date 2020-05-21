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
    /// Sender details including id or email and name (optional). Only one of either Sender&#39;s email or Sender&#39;s ID shall be passed in one request at a time. For example &#x60;{&quot;name&quot;:&quot;xyz&quot;, &quot;email&quot;:&quot;example@abc.com&quot;}&#x60; , &#x60;{&quot;name&quot;:&quot;xyz&quot;, &quot;id&quot;:123}&#x60;
    /// </summary>
    [DataContract]
    public partial class UpdateSmtpTemplateSender :  IEquatable<UpdateSmtpTemplateSender>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSmtpTemplateSender" /> class.
        /// </summary>
        /// <param name="name">Name of the sender.</param>
        /// <param name="email">Email of the sender.</param>
        /// <param name="id">Select the sender for the template on the basis of sender id. In order to select a sender with specific pool of IP’s, dedicated ip users shall pass id (instead of email)..</param>
        public UpdateSmtpTemplateSender(string name = default(string), string email = default(string), long? id = default(long?))
        {
            this.Name = name;
            this.Email = email;
            this.Id = id;
        }
        
        /// <summary>
        /// Name of the sender
        /// </summary>
        /// <value>Name of the sender</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Email of the sender
        /// </summary>
        /// <value>Email of the sender</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Select the sender for the template on the basis of sender id. In order to select a sender with specific pool of IP’s, dedicated ip users shall pass id (instead of email).
        /// </summary>
        /// <value>Select the sender for the template on the basis of sender id. In order to select a sender with specific pool of IP’s, dedicated ip users shall pass id (instead of email).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSmtpTemplateSender {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as UpdateSmtpTemplateSender);
        }

        /// <summary>
        /// Returns true if UpdateSmtpTemplateSender instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSmtpTemplateSender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSmtpTemplateSender input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }

}
