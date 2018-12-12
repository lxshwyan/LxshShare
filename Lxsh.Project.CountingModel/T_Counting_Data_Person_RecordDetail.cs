using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Person_RecordDetail
    {
        private System.String _RecordSeqno;
        /// <summary>
        /// 
        /// </summary>
        public System.String RecordSeqno { get { return this._RecordSeqno; } set { this._RecordSeqno = value; } }

        private System.String _AreaTypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String AreaTypeCode { get { return this._AreaTypeCode; } set { this._AreaTypeCode = value; } }

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
    }
}