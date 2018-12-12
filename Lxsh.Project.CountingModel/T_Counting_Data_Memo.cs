using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Memo
    {
        private System.String _SeqNo;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String SeqNo { get { return this._SeqNo; } set { this._SeqNo = value; } }

        private System.String _CriminalNo;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String CriminalNo { get { return this._CriminalNo; } set { this._CriminalNo = value; } }

        private System.String _MemoContent;
        /// <summary>
        /// 
        /// </summary>
        public System.String MemoContent { get { return this._MemoContent; } set { this._MemoContent = value; } }
    }
}