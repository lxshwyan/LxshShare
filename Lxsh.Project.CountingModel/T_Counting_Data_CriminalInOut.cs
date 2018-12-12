using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_CriminalInOut
    {
        private System.String _ObjectID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String ObjectID { get { return this._ObjectID; } set { this._ObjectID = value; } }

        private System.String _BeforeArea;
        /// <summary>
        /// 
        /// </summary>
        public System.String BeforeArea { get { return this._BeforeArea; } set { this._BeforeArea = value; } }

        private System.String _AfterArea;
        /// <summary>
        /// 
        /// </summary>
        public System.String AfterArea { get { return this._AfterArea; } set { this._AfterArea = value; } }

        private System.DateTime? _StartTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? StartTime { get { return this._StartTime; } set { this._StartTime = value; } }

        private System.Int32? _FlowType;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? FlowType { get { return this._FlowType; } set { this._FlowType = value; } }

        private System.String _Abstract;
        /// <summary>
        /// 
        /// </summary>
        public System.String Abstract { get { return this._Abstract; } set { this._Abstract = value; } }

        private System.Int32? _ID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? ID { get { return this._ID; } set { this._ID = value; } }

        private System.String _CriminalID;
        /// <summary>
        /// 
        /// </summary>
        public System.String CriminalID { get { return this._CriminalID; } set { this._CriminalID = value; } }
    }
}