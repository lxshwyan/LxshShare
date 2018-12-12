using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Person_Record
    {
        private System.String _SeqNo;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String SeqNo { get { return this._SeqNo; } set { this._SeqNo = value; } }

        private System.DateTime? _StartDate;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? StartDate { get { return this._StartDate; } set { this._StartDate = value; } }

        private System.DateTime? _EndDate;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? EndDate { get { return this._EndDate; } set { this._EndDate = value; } }

        private System.DateTime _PlanTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime PlanTime { get { return this._PlanTime; } set { this._PlanTime = value; } }

        private System.String _CountingUser;
        /// <summary>
        /// 
        /// </summary>
        public System.String CountingUser { get { return this._CountingUser; } set { this._CountingUser = value; } }

        private System.String _ReportUser;
        /// <summary>
        /// 
        /// </summary>
        public System.String ReportUser { get { return this._ReportUser; } set { this._ReportUser = value; } }

        private System.String _MemoSeqno;
        /// <summary>
        /// 
        /// </summary>
        public System.String MemoSeqno { get { return this._MemoSeqno; } set { this._MemoSeqno = value; } }

        private System.Int32? _CountingType;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CountingType { get { return this._CountingType; } set { this._CountingType = value; } }

        private System.Int32? _CountingWay;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CountingWay { get { return this._CountingWay; } set { this._CountingWay = value; } }

        private System.String _ToDept;
        /// <summary>
        /// 
        /// </summary>
        public System.String ToDept { get { return this._ToDept; } set { this._ToDept = value; } }

        private System.Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsIdentity = true)]
        public System.Int32 ID { get { return this._ID; } set { this._ID = value; } }
    }
}