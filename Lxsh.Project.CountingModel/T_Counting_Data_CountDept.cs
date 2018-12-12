using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_CountDept
    {
        private System.String _SeqNo;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String SeqNo { get { return this._SeqNo; } set { this._SeqNo = value; } }

        private System.String _TypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String TypeCode { get { return this._TypeCode; } set { this._TypeCode = value; } }
    }
}