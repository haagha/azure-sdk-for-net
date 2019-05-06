// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the prediction of a query.
    /// </summary>
    public partial class Prediction
    {
        /// <summary>
        /// Initializes a new instance of the Prediction class.
        /// </summary>
        public Prediction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Prediction class.
        /// </summary>
        /// <param name="normalizedQuery">The query after pre-processing and
        /// normalization.</param>
        /// <param name="topIntent">The name of the top scoring intent.</param>
        /// <param name="intents">A dictionary representing the intents that
        /// fired.</param>
        /// <param name="entities">The dictionary representing the entities
        /// that fired.</param>
        /// <param name="alteredQuery">The query after spell checking. Only set
        /// if spell check was enabled and a spelling mistake was
        /// found.</param>
        /// <param name="sentiment">The result of the sentiment
        /// analysis.</param>
        public Prediction(string normalizedQuery, string topIntent, IDictionary<string, Intent> intents, IDictionary<string, object> entities, string alteredQuery = default(string), Sentiment sentiment = default(Sentiment))
        {
            NormalizedQuery = normalizedQuery;
            AlteredQuery = alteredQuery;
            TopIntent = topIntent;
            Intents = intents;
            Entities = entities;
            Sentiment = sentiment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the query after pre-processing and normalization.
        /// </summary>
        [JsonProperty(PropertyName = "normalizedQuery")]
        public string NormalizedQuery { get; set; }

        /// <summary>
        /// Gets or sets the query after spell checking. Only set if spell
        /// check was enabled and a spelling mistake was found.
        /// </summary>
        [JsonProperty(PropertyName = "alteredQuery")]
        public string AlteredQuery { get; set; }

        /// <summary>
        /// Gets or sets the name of the top scoring intent.
        /// </summary>
        [JsonProperty(PropertyName = "topIntent")]
        public string TopIntent { get; set; }

        /// <summary>
        /// Gets or sets a dictionary representing the intents that fired.
        /// </summary>
        [JsonProperty(PropertyName = "intents")]
        public IDictionary<string, Intent> Intents { get; set; }

        /// <summary>
        /// Gets or sets the dictionary representing the entities that fired.
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IDictionary<string, object> Entities { get; set; }

        /// <summary>
        /// Gets or sets the result of the sentiment analysis.
        /// </summary>
        [JsonProperty(PropertyName = "sentiment")]
        public Sentiment Sentiment { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NormalizedQuery == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NormalizedQuery");
            }
            if (TopIntent == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TopIntent");
            }
            if (Intents == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Intents");
            }
            if (Entities == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Entities");
            }
            if (Intents != null)
            {
                foreach (var valueElement in Intents.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (Sentiment != null)
            {
                Sentiment.Validate();
            }
        }
    }
}