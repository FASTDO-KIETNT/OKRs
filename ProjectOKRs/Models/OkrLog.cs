using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjectOKRs.Models;

[BsonIgnoreExtraElements]
public class OkrLog
{
  [BsonId]
  public string id { get; set; }

  /// <summary>
  /// the timestamp when the log entry was created.
  /// </summary>
  public long created { get; set; }

  /// <summary>
  /// ID of the user who performed the action.
  /// </summary>
  public string user_id { get; set; }

  /// <summary>
  /// the ID of the OKR associated with the log entry.
  /// </summary>
  public string okr_id { get; set; }

  /// <summary>
  /// the action performed on the OKR.
  /// </summary>
  public string action { get; set; }

  /// <summary>
  /// the old values of the OKR before the action.
  /// </summary>
  public Log old { get; set; } = new();

  /// <summary>
  /// the edited values of the OKR after the action.
  /// </summary>
  public Log edit { get; set; } = new();

  public class Log
  {
    /// <summary>
    ///the Id OKR.
    /// </summary>
    public string okr { get; set; }

    /// <summary>
    /// the list of KR associated with the OKR.
    /// </summary>
    public List<string> kr { get; set; } = new();

    /// <summary>
    /// the list of goals associated with the OKR.
    /// </summary>
    public List<string> goal { get; set; } = new();
  }
}
