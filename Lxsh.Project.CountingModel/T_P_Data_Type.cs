using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_P_Data_Type
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

        private System.String _UpperTypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String UpperTypeCode { get { return this._UpperTypeCode; } set { this._UpperTypeCode = value; } }

        private System.String _RootCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String RootCode { get { return this._RootCode; } set { this._RootCode = value; } }

        private System.String _TypeName;
        /// <summary>
        /// 
        /// </summary>
        public System.String TypeName { get { return this._TypeName; } set { this._TypeName = value; } }

        private System.Int32? _TypeLevel;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? TypeLevel { get { return this._TypeLevel; } set { this._TypeLevel = value; } }

        private System.Int32? _OrderNo;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? OrderNo { get { return this._OrderNo; } set { this._OrderNo = value; } }

        private System.String _Remark;
        /// <summary>
        /// 
        /// </summary>
        public System.String Remark { get { return this._Remark; } set { this._Remark = value; } }

        private System.String _CreatedUser;
        /// <summary>
        /// 
        /// </summary>
        public System.String CreatedUser { get { return this._CreatedUser; } set { this._CreatedUser = value; } }

        private System.String _CreatedDate;
        /// <summary>
        /// 
        /// </summary>
        public System.String CreatedDate { get { return this._CreatedDate; } set { this._CreatedDate = value; } }

        private System.String _LinkAge;
        /// <summary>
        /// 
        /// </summary>
        public System.String LinkAge { get { return this._LinkAge; } set { this._LinkAge = value; } }
    }
}