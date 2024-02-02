using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjectOKRs.Models
{
  public class Suggest
  {
    [BsonId]
    public string id { get; set; }
    public string name { get; set; }

    /// <summary>
    /// the cycle of the suggestion.
    /// </summary>
    public string cycle { get; set; }

    /// <summary>
    /// the type of the suggestion.
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// a value indicating whether the suggestion is a draft.
    /// </summary>
    public bool draft { get; set; }

    /// <summary>
    /// the date of the suggestion.
    /// </summary>
    public long date { get; set; }

    /// <summary>
    /// the user associated with the suggestion.
    /// </summary>
    public string user { get; set; }
  }
}