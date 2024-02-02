using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjectOKRs.Models;

public class OkrsCheckin
{
  [BsonId]
  public string id { get; set; }

  /// <summary>
  /// the cycle of the check-in.
  /// </summary>
  public string cycle { get; set; }

  /// <summary>
  /// the date when the check-in was created.
  /// </summary>
  public long date_created { get; set; }

  /// <summary>
  /// the user who created the check-in.
  /// </summary>
  public string user_created { get; set; }

  /// <summary>
  /// the status of the check-in.
  /// </summary>
  public int status_checkin { get; set; }

  /// <summary>
  /// the date of the next check-in.
  /// </summary>
  public long next_date_checkin { get; set; }

  /// <summary>
  /// the date of the check-in.
  /// </summary>
  public long date_checkin { get; set; }

  /// <summary>
  /// the user who performed the check-in.
  /// </summary>
  public string user_checkin { get; set; }

  /// <summary>
  /// a value indicating whether the check-in is a draft.
  /// </summary>
  public bool draft { get; set; }

  /// <summary>
  /// the confidence level of the check-in.
  /// </summary>
  public int confident { get; set; }

  /// <summary>
  /// the previous progress of the check-in.
  /// </summary>
  public double progress_prev { get; set; }

  /// <summary>
  /// the OKR (Objective and Key Results) associated with the check-in.
  /// </summary>
  public string okr { get; set; }

  /// <summary>
  /// a value indicating whether the check-in is done.
  /// </summary>
  public bool is_done { get; set; }

  /// <summary>
  /// the list of key results for the check-in.
  /// </summary>
  public List<KeyResult> key_results { get; set; } = new();

  /// <summary>
  /// the list of feedbacks for the check-in.
  /// </summary>
  public List<Feedback> feedbacks { get; set; } = new();


  public class KeyResult
  {
    public string id { get; set; }

    /// <summary>
    /// the result value of the key result.
    /// </summary>
    public double result { get; set; }

    /// <summary>
    /// the change value of the key result.
    /// </summary>
    public double change { get; set; }

    /// <summary>
    /// the confidence level of the key result.
    /// </summary>
    public int confident { get; set; }

    /// <summary>
    /// the list of questions for the key result.
    /// </summary>
    public List<string> questions { get; set; }

    /// <summary>
    /// the feedback for the key result.
    /// </summary>
    public string feedback { get; set; }
  }


  public class Feedback
  {
    public string id { get; set; }

    /// <summary>
    /// the user who provided the feedback.
    /// </summary>
    public string user { get; set; }

    /// <summary>
    /// the content of the feedback.
    /// </summary>
    public string content { get; set; }

    /// <summary>
    /// the key result associated with the feedback.
    /// </summary>
    public string kr { get; set; }

    /// <summary>
    /// the date of the feedback.
    /// </summary>
    public long date { get; set; }
  }
}
