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
    /// UpdateAttribute
    /// </summary>
    [DataContract]
    public partial class UpdateAttribute :  IEquatable<UpdateAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAttribute" /> class.
        /// </summary>
        /// <param name="value">Value of the attribute to update. Use only if the attribute&#39;s category is &#39;calculated&#39; or &#39;global&#39;.</param>
        /// <param name="enumeration">List of the values and labels that the attribute can take. Use only if the attribute&#39;s category is \&quot;category\&quot;. For example, [{&#39;value&#39;:1, &#39;label&#39;:&#39;male&#39;}, {&#39;value&#39;:2, &#39;label&#39;:&#39;female&#39;}].</param>
        public UpdateAttribute(string value = default(string), List<UpdateAttributeEnumeration> enumeration = default(List<UpdateAttributeEnumeration>))
        {
            this.Value = value;
            this.Enumeration = enumeration;
        }
        
        /// <summary>
        /// Value of the attribute to update. Use only if the attribute&#39;s category is &#39;calculated&#39; or &#39;global&#39;
        /// </summary>
        /// <value>Value of the attribute to update. Use only if the attribute&#39;s category is &#39;calculated&#39; or &#39;global&#39;</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// List of the values and labels that the attribute can take. Use only if the attribute&#39;s category is \&quot;category\&quot;. For example, [{&#39;value&#39;:1, &#39;label&#39;:&#39;male&#39;}, {&#39;value&#39;:2, &#39;label&#39;:&#39;female&#39;}]
        /// </summary>
        /// <value>List of the values and labels that the attribute can take. Use only if the attribute&#39;s category is \&quot;category\&quot;. For example, [{&#39;value&#39;:1, &#39;label&#39;:&#39;male&#39;}, {&#39;value&#39;:2, &#39;label&#39;:&#39;female&#39;}]</value>
        [DataMember(Name="enumeration", EmitDefaultValue=false)]
        public List<UpdateAttributeEnumeration> Enumeration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAttribute {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Enumeration: ").Append(Enumeration).Append("\n");
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
            return this.Equals(input as UpdateAttribute);
        }

        /// <summary>
        /// Returns true if UpdateAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Enumeration == input.Enumeration ||
                    this.Enumeration != null &&
                    this.Enumeration.SequenceEqual(input.Enumeration)
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Enumeration != null)
                    hashCode = hashCode * 59 + this.Enumeration.GetHashCode();
                return hashCode;
            }
        }
    }

}
