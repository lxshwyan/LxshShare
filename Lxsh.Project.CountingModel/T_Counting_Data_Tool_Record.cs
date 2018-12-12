using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Tool_Record
    {
        private System.String _FK_Plan_SeqNo;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String FK_Plan_SeqNo { get { return this._FK_Plan_SeqNo; } set { this._FK_Plan_SeqNo = value; } }

        private System.Int32? _CountingWay;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CountingWay { get { return this._CountingWay; } set { this._CountingWay = value; } }

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

        private System.String _ObjectID;
        /// <summary>
        /// 
        /// </summary>
        public System.String ObjectID { get { return this._ObjectID; } set { this._ObjectID = value; } }

        private System.String _PoliceNum;
        /// <summary>
        /// 
        /// </summary>
        public System.String PoliceNum { get { return this._PoliceNum; } set { this._PoliceNum = value; } }

        private System.String _ReportUser;
        /// <summary>
        /// 
        /// </summary>
        public System.String ReportUser { get { return this._ReportUser; } set { this._ReportUser = value; } }

        private System.String _DepartmentNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String DepartmentNo { get { return this._DepartmentNo; } set { this._DepartmentNo = value; } }

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
    }
}