using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Person_Detail
    {
        private System.String _RecordSeqNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String RecordSeqNo { get { return this._RecordSeqNo; } set { this._RecordSeqNo = value; } }

        private System.String _CriminalId;
        /// <summary>
        /// 
        /// </summary>
        public System.String CriminalId { get { return this._CriminalId; } set { this._CriminalId = value; } }

        private System.String _TypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String TypeCode { get { return this._TypeCode; } set { this._TypeCode = value; } }

        private System.String _OldBelongTypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String OldBelongTypeCode { get { return this._OldBelongTypeCode; } set { this._OldBelongTypeCode = value; } }
    }
}