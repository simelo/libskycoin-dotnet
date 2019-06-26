/* 
 * Skycoin REST API.
 *
 * Skycoin is a next-generation cryptocurrency.
 *
 * The version of the OpenAPI document: 0.25.1
 * Contact: contact@skycoin.net
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Skyapi.Client.OpenAPIDateConverter;

namespace Skyapi.Model
{
    /// <summary>
    /// InlineObject
    /// </summary>
    [DataContract]
    public partial class InlineObject :  IEquatable<InlineObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        /// <param name="changeAddress">changeAddress.</param>
        /// <param name="hoursSelection">hoursSelection.</param>
        /// <param name="ignoreUnconfirmed">ignoreUnconfirmed.</param>
        /// <param name="to">to.</param>
        /// <param name="wallet">wallet.</param>
        public InlineObject(string changeAddress = default(string), ApiV1WalletTransactionHoursSelection hoursSelection = default(ApiV1WalletTransactionHoursSelection), bool? ignoreUnconfirmed = default(bool?), List<ApiV1WalletTransactionTo> to = default(List<ApiV1WalletTransactionTo>), ApiV1WalletTransactionWallet wallet = default(ApiV1WalletTransactionWallet))
        {
            this.ChangeAddress = changeAddress;
            this.HoursSelection = hoursSelection;
            this.IgnoreUnconfirmed = ignoreUnconfirmed;
            this.To = to;
            this.Wallet = wallet;
        }
        
        /// <summary>
        /// Gets or Sets ChangeAddress
        /// </summary>
        [DataMember(Name="change_address", EmitDefaultValue=false)]
        public string ChangeAddress { get; set; }

        /// <summary>
        /// Gets or Sets HoursSelection
        /// </summary>
        [DataMember(Name="hours_selection", EmitDefaultValue=false)]
        public ApiV1WalletTransactionHoursSelection HoursSelection { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreUnconfirmed
        /// </summary>
        [DataMember(Name="ignore_unconfirmed", EmitDefaultValue=false)]
        public bool? IgnoreUnconfirmed { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<ApiV1WalletTransactionTo> To { get; set; }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name="wallet", EmitDefaultValue=false)]
        public ApiV1WalletTransactionWallet Wallet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject {\n");
            sb.Append("  ChangeAddress: ").Append(ChangeAddress).Append("\n");
            sb.Append("  HoursSelection: ").Append(HoursSelection).Append("\n");
            sb.Append("  IgnoreUnconfirmed: ").Append(IgnoreUnconfirmed).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
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
            return this.Equals(input as InlineObject);
        }

        /// <summary>
        /// Returns true if InlineObject instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChangeAddress == input.ChangeAddress ||
                    (this.ChangeAddress != null &&
                    this.ChangeAddress.Equals(input.ChangeAddress))
                ) && 
                (
                    this.HoursSelection == input.HoursSelection ||
                    (this.HoursSelection != null &&
                    this.HoursSelection.Equals(input.HoursSelection))
                ) && 
                (
                    this.IgnoreUnconfirmed == input.IgnoreUnconfirmed ||
                    (this.IgnoreUnconfirmed != null &&
                    this.IgnoreUnconfirmed.Equals(input.IgnoreUnconfirmed))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Wallet == input.Wallet ||
                    (this.Wallet != null &&
                    this.Wallet.Equals(input.Wallet))
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
                if (this.ChangeAddress != null)
                    hashCode = hashCode * 59 + this.ChangeAddress.GetHashCode();
                if (this.HoursSelection != null)
                    hashCode = hashCode * 59 + this.HoursSelection.GetHashCode();
                if (this.IgnoreUnconfirmed != null)
                    hashCode = hashCode * 59 + this.IgnoreUnconfirmed.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Wallet != null)
                    hashCode = hashCode * 59 + this.Wallet.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}