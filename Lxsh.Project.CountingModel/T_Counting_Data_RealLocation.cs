using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_RealLocation
    {
        private System.String _CriminalID;
        /// <summary>
        /// 
        /// </summary>
        public System.String CriminalID { get { return this._CriminalID; } set { this._CriminalID = value; } }

        private System.String _AreaTypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String AreaTypeCode { get { return this._AreaTypeCode; } set { this._AreaTypeCode = value; } }

        private System.DateTime? _CreatedTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? CreatedTime { get { return this._CreatedTime; } set { this._CreatedTime = value; } }

        private System.Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 ID { get { return this._ID; } set { this._ID = value; } }

        private System.String _Remark;
        /// <summary>
        /// 
        /// </summary>
        public System.String Remark { get { return this._Remark; } set { this._Remark = value; } }
    }
}