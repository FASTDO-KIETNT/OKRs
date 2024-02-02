using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjectOKRs.Models
{
  [BsonIgnoreExtraElements]

  public class TimeCheckin
  {
    [BsonId]
    public string id { get; set; }

    public string cycle { get; set; }

    /// <summary>
    /// the OKR ID of the time check-in entry.
    /// </summary>
    public string okr { get; set; }

    /// <summary>
    /// the OKR name of the time check-in entry.
    /// </summary>
    public string okr_name { get; set; }

    /// <summary>
    /// the user who created the check-in entry.
    /// </summary>
    public string user_create { get; set; }

    /// <summary>
    /// the manager check-in.
    /// </summary>
    public string user_checkin { get; set; }

    /// <summary>
    /// the date of the check-in 
    /// </summary>
    public long date_checkin { get; set; }

    /// <summary>
    /// the status of the check-in entry.
    /// 0: Not checked in, 1: On time, 2: Late
    /// </summary>
    public int status { get; set; }
  }
}