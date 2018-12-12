using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Record_Criminal
    {
        private System.Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsIdentity = true)]
        public System.Int32 ID { get { return this._ID; } set { this._ID = value; } }

        private System.String _FK_ObjectID;
        /// <summary>
        /// 
        /// </summary>
        public System.String FK_ObjectID { get { return this._FK_ObjectID; } set { this._FK_ObjectID = value; } }

        private System.String _CriminalID;
        /// <summary>
        /// 
        /// </summary>
        public System.String CriminalID { get { return this._CriminalID; } set { this._CriminalID = value; } }

        private System.Int32? _CountType;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CountType { get { return this._CountType; } set { this._CountType = value; } }
    }
}