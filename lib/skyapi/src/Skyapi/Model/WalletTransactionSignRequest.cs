/* 
 * Skycoin REST API.
 *
 * Skycoin is a next-generation cryptocurrency.
 *
 * The version of the OpenAPI document: 0.26.0
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
    /// WalletTransactionSignRequest
    /// </summary>
    [DataContract]
    public partial class WalletTransactionSignRequest :  IEquatable<WalletTransactionSignRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionSignRequest" /> class.
        /// </summary>
        /// <param name="walletId">walletId.</param>
        /// <param name="password">password.</param>
        /// <param name="encodedTransaction">encodedTransaction.</param>
        /// <param name="signIndexes">signIndexes.</param>
        public WalletTransactionSignRequest(string walletId = default(string), string password = default(string), string encodedTransaction = default(string), List<long?> signIndexes = default(List<long?>))
        {
            this.WalletId = walletId;
            this.Password = password;
            this.EncodedTransaction = encodedTransaction;
            this.SignIndexes = signIndexes;
        }
        
        /// <summary>
        /// Gets or Sets WalletId
        /// </summary>
        [DataMember(Name="wallet_id", EmitDefaultValue=false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets EncodedTransaction
        /// </summary>
        [DataMember(Name="encoded_transaction", EmitDefaultValue=false)]
        public string EncodedTransaction { get; set; }

        /// <summary>
        /// Gets or Sets SignIndexes
        /// </summary>
        [DataMember(Name="sign_indexes", EmitDefaultValue=false)]
        public List<long?> SignIndexes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletTransactionSignRequest {\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  EncodedTransaction: ").Append(EncodedTransaction).Append("\n");
            sb.Append("  SignIndexes: ").Append(SignIndexes).Append("\n");
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
            return this.Equals(input as WalletTransactionSignRequest);
        }

        /// <summary>
        /// Returns true if WalletTransactionSignRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletTransactionSignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletTransactionSignRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.EncodedTransaction == input.EncodedTransaction ||
                    (this.EncodedTransaction != null &&
                    this.EncodedTransaction.Equals(input.EncodedTransaction))
                ) && 
                (
                    this.SignIndexes == input.SignIndexes ||
                    this.SignIndexes != null &&
                    input.SignIndexes != null &&
                    this.SignIndexes.SequenceEqual(input.SignIndexes)
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
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.EncodedTransaction != null)
                    hashCode = hashCode * 59 + this.EncodedTransaction.GetHashCode();
                if (this.SignIndexes != null)
                    hashCode = hashCode * 59 + this.SignIndexes.GetHashCode();
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
