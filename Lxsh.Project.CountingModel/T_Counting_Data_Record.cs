using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Record
    {
        private System.String _ObjectID;
        /// <summary>
        /// 
        /// </summary>
        public System.String ObjectID { get { return this._ObjectID; } set { this._ObjectID = value; } }

        private System.String _FK_Plan_SeqNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String FK_Plan_SeqNo { get { return this._FK_Plan_SeqNo; } set { this._FK_Plan_SeqNo = value; } }

        private System.Int32? _PlanCount;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? PlanCount { get { return this._PlanCount; } set { this._PlanCount = value; } }

        private System.Int32? _RealCount;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? RealCount { get { return this._RealCount; } set { this._RealCount = value; } }

        private System.Int32? _NotCount;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? NotCount { get { return this._NotCount; } set { this._NotCount = value; } }

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

        private System.Int32? _States;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? States { get { return this._States; } set { this._States = value; } }

        private System.String _AreaTypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String AreaTypeCode { get { return this._AreaTypeCode; } set { this._AreaTypeCode = value; } }

        private System.String _PlanTime;
        /// <summary>
        /// 
        /// </summary>
        public System.String PlanTime { get { return this._PlanTime; } set { this._PlanTime = value; } }

        private System.String _StartDate;
        /// <summary>
        /// 
        /// </summary>
        public System.String StartDate { get { return this._StartDate; } set { this._StartDate = value; } }

        private System.String _EndDate;
        /// <summary>
        /// 
        /// </summary>
        public System.String EndDate { get { return this._EndDate; } set { this._EndDate = value; } }

        private System.String _CountingUser;
        /// <summary>
        /// 
        /// </summary>
        public System.String CountingUser { get { return this._CountingUser; } set { this._CountingUser = value; } }

        private System.String _ToDept;
        /// <summary>
        /// 
        /// </summary>
        public System.String ToDept { get { return this._ToDept; } set { this._ToDept = value; } }

        private System.String _PolicePhone;
        /// <summary>
        /// 
        /// </summary>
        public System.String PolicePhone { get { return this._PolicePhone; } set { this._PolicePhone = value; } }

        private System.String _CreatedDate;
        /// <summary>
        /// 
        /// </summary>
        public System.String CreatedDate { get { return this._CreatedDate; } set { this._CreatedDate = value; } }

        private System.String _BetName;
        /// <summary>
        /// 
        /// </summary>
        public System.String BetName { get { return this._BetName; } set { this._BetName = value; } }

        private System.String _PrisonName;
        /// <summary>
        /// 
        /// </summary>
        public System.String PrisonName { get { return this._PrisonName; } set { this._PrisonName = value; } }

        private System.Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 ID { get { return this._ID; } set { this._ID = value; } }

        private System.String _MemoSeqno;
        /// <summary>
        /// 
        /// </summary>
        public System.String MemoSeqno { get { return this._MemoSeqno; } set { this._MemoSeqno = value; } }

        private System.String _PoliceNum;
        /// <summary>
        /// 
        /// </summary>
        public System.String PoliceNum { get { return this._PoliceNum; } set { this._PoliceNum = value; } }
    }
}