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
    /// CreateDoiContact
    /// </summary>
    [DataContract]
    public partial class CreateDoiContact :  IEquatable<CreateDoiContact>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDoiContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDoiContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDoiContact" /> class.
        /// </summary>
        /// <param name="email">Email address where the confirmation email will be sent. This email address will be the identifier for all other contact attributes. (required).</param>
        /// <param name="attributes">Pass the set of attributes and their values. These attributes must be present in your SendinBlue account. For eg. {&#39;FNAME&#39;:&#39;Elly&#39;, &#39;LNAME&#39;:&#39;Roger&#39;}.</param>
        /// <param name="includeListIds">Lists under user account where contact should be added (required).</param>
        /// <param name="excludeListIds">Lists under user account where contact should not be added.</param>
        /// <param name="templateId">Id of the DOI template (required).</param>
        /// <param name="redirectionUrl">URL of the web page that user will be redirected to after clicking on the double opt in URL..</param>
        public CreateDoiContact(string email = default(string), Object attributes = default(Object), List<long?> includeListIds = default(List<long?>), List<long?> excludeListIds = default(List<long?>), long? templateId = default(long?), string redirectionUrl = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for CreateDoiContact and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "includeListIds" is required (not null)
            if (includeListIds == null)
            {
                throw new InvalidDataException("includeListIds is a required property for CreateDoiContact and cannot be null");
            }
            else
            {
                this.IncludeListIds = includeListIds;
            }
            // to ensure "templateId" is required (not null)
            if (templateId == null)
            {
                throw new InvalidDataException("templateId is a required property for CreateDoiContact and cannot be null");
            }
            else
            {
                this.TemplateId = templateId;
            }
            this.Attributes = attributes;
            this.ExcludeListIds = excludeListIds;
            this.RedirectionUrl = redirectionUrl;
        }
        
        /// <summary>
        /// Email address where the confirmation email will be sent. This email address will be the identifier for all other contact attributes.
        /// </summary>
        /// <value>Email address where the confirmation email will be sent. This email address will be the identifier for all other contact attributes.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Pass the set of attributes and their values. These attributes must be present in your SendinBlue account. For eg. {&#39;FNAME&#39;:&#39;Elly&#39;, &#39;LNAME&#39;:&#39;Roger&#39;}
        /// </summary>
        /// <value>Pass the set of attributes and their values. These attributes must be present in your SendinBlue account. For eg. {&#39;FNAME&#39;:&#39;Elly&#39;, &#39;LNAME&#39;:&#39;Roger&#39;}</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Lists under user account where contact should be added
        /// </summary>
        /// <value>Lists under user account where contact should be added</value>
        [DataMember(Name="includeListIds", EmitDefaultValue=false)]
        public List<long?> IncludeListIds { get; set; }

        /// <summary>
        /// Lists under user account where contact should not be added
        /// </summary>
        /// <value>Lists under user account where contact should not be added</value>
        [DataMember(Name="excludeListIds", EmitDefaultValue=false)]
        public List<long?> ExcludeListIds { get; set; }

        /// <summary>
        /// Id of the DOI template
        /// </summary>
        /// <value>Id of the DOI template</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// URL of the web page that user will be redirected to after clicking on the double opt in URL.
        /// </summary>
        /// <value>URL of the web page that user will be redirected to after clicking on the double opt in URL.</value>
        [DataMember(Name="redirectionUrl", EmitDefaultValue=false)]
        public string RedirectionUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDoiContact {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  IncludeListIds: ").Append(IncludeListIds).Append("\n");
            sb.Append("  ExcludeListIds: ").Append(ExcludeListIds).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  RedirectionUrl: ").Append(RedirectionUrl).Append("\n");
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
            return this.Equals(input as CreateDoiContact);
        }

        /// <summary>
        /// Returns true if CreateDoiContact instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDoiContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDoiContact input)
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
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.IncludeListIds == input.IncludeListIds ||
                    this.IncludeListIds != null &&
                    this.IncludeListIds.SequenceEqual(input.IncludeListIds)
                ) && 
                (
                    this.ExcludeListIds == input.ExcludeListIds ||
                    this.ExcludeListIds != null &&
                    this.ExcludeListIds.SequenceEqual(input.ExcludeListIds)
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.RedirectionUrl == input.RedirectionUrl ||
                    (this.RedirectionUrl != null &&
                    this.RedirectionUrl.Equals(input.RedirectionUrl))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.IncludeListIds != null)
                    hashCode = hashCode * 59 + this.IncludeListIds.GetHashCode();
                if (this.ExcludeListIds != null)
                    hashCode = hashCode * 59 + this.ExcludeListIds.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.RedirectionUrl != null)
                    hashCode = hashCode * 59 + this.RedirectionUrl.GetHashCode();
                return hashCode;
            }
        }
    }

}
