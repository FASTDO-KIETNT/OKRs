using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjectOKRs.Models
{
    [BsonIgnoreExtraElements]

    public class OKRs
    {
            [BsonId]
            public string Id { get; set; }
            public string name { get; set; }
            /// <summary>
            /// The progress previous of the OKR.
            /// </summary>
            public double progress_prev { get; set; }
            /// <summary>
            /// The ID of the cycle that the OKR belongs to.
            /// </summary>
            public string cycleId { get; set; }
            /// <summary>
            /// Indicates whether the OKR is marked for deletion.
            /// </summary>
            public bool delete { get; set; }
            /// <summary>
            /// The confidence level of the OKR.
            /// </summary>
            public int confident { get; set; }
            /// <summary>
            /// The status of the check-in for the OKR.
            /// 1. Check-in nháp 2. Đã xác nhận 3. Đã check-in
            /// </summary>
            public int status_checkin { get; set; }
            /// <summary>
            /// The timestamp of the next check-in for the OKR.
            /// </summary>
            public long next_checkin { get; set; }
            /// <summary>
            /// The timestamp of the check-in date for the OKR.
            /// </summary>
            public long date_checkin { get; set; }
            /// <summary>
            /// The user who performed the check-in for the OKR.
            /// </summary>
            public string user_checkin { get; set; }
            /// <summary>
            /// The previous status of the check-in for the OKR.
            /// </summary>
            public int status_checkin_old { get; set; }
            /// <summary>
            /// The timestamp of the confirmation date for the check-in.
            /// </summary>
            public long date_checkin_confirm { get; set; }
            /// <summary>
            /// The comment from the review staff for the OKR.
            /// </summary>
            public string review_staff_comment { get; set; }
            /// <summary>
            /// The timestamp of the creation date for the OKR.
            /// </summary>
            public long date_created { get; set; }
            /// <summary>
            /// The manager responsible for the OKR.
            /// </summary>
            public string okr_manager { get; set; }
            /// <summary>
            /// The status of the review send for the OKR.
            /// </summary>
            public int review_send_status { get; set; }
            /// <summary>
            /// The type of the OKR.
            /// </summary>
            public int type { get; set; }
            /// <summary>
            /// Indicates whether the OKR is marked as done.
            /// </summary>
            public bool done { get; set; }
            /// <summary>
            /// The user who created the OKR.
            /// </summary>
            public string user_created { get; set; }
            /// <summary>
            /// The comment from the review manager for the OKR.
            /// </summary>
            public string review_manager_comment { get; set; }
            /// <summary>
            /// The ID of the review manager for the OKR.
            /// </summary>
            public string review_manager_id { get; set; }
            /// <summary>
            /// The timestamp of the review send date for the OKR.
            /// </summary>
            public long review_send_date { get; set; }
            /// <summary>
            /// The timestamp of the review manager date for the OKR.
            /// </summary>
            public long review_manager_date { get; set; }
            /// <summary>
            /// The review data for the OKR.
            /// </summary>
            public Review review_data { get; set; } = new();
            /// <summary>
            /// The list of viewers for the review of the OKR.
            /// </summary>
            public List<string> review_viewers { get; set; } = new();
            /// <summary>
            /// The list of key results for the OKR.
            /// </summary>
            public List<KeyResult> key_results { get; set; }
           
            public class KeyResult
            {
                public string id { get; set; }
        
                public string name { get; set; }

                public double goal { get; set; }
                /// <summary>
                /// The change value of the key result.
                /// </summary>
                public double change { get; set; }
                /// <summary>
                /// The review data for the key result.
                /// </summary>
                public Review review_data { get; set; } = new();
                /// <summary>
                /// The unit of measurement for the key result.
                /// </summary>
                public string unit { get; set; }
                /// <summary>
                /// The link associated with the key result.
                /// </summary>
                public string link { get; set; }
                /// <summary>
                /// The confidence level of the key result.
                /// </summary>
                public int confident { get; set; }
                /// <summary>
                /// The achieved result value of the key result.
                /// </summary>
                public double result { get; set; }
                /// <summary>
                /// The list of cross-linking information for the key result.
                /// </summary>
                public List<CrossLink> cross_linking { get; set; }
            }
            public class CrossLink
            {
                public string id { get; set; }
                /// <summary>
                /// The OKR associated with the cross-link.
                /// </summary>
                public string okr { get; set; }
                /// <summary>
                /// The user associated with the cross-link.
                /// </summary>
                public string user { get; set; }
            }
            public class Review
            {
                /// <summary>
                /// The self-assessment point given by the staff.
                /// </summary>
                public double staff_point { get; set; }
                /// <summary>
                /// The assessment point given by the manager.
                /// </summary>
                public double manager_point { get; set; }
                /// <summary>
                /// The self-comment provided by the staff.
                /// </summary>
                public string staff_comment { get; set; }
                /// <summary>
                /// The comment provided by the manager.
                /// </summary>
                public string manager_comment { get; set; }
            }
        }
}