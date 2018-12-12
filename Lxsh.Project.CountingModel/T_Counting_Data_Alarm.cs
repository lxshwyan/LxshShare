using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Alarm
    {
        private System.String _SeqNo;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String SeqNo { get { return this._SeqNo; } set { this._SeqNo = value; } }

        private System.String _AlarmType;
        /// <summary>
        /// 
        /// </summary>
        public System.String AlarmType { get { return this._AlarmType; } set { this._AlarmType = value; } }

        private System.String _CountingDate;
        /// <summary>
        /// 
        /// </summary>
        public System.String CountingDate { get { return this._CountingDate; } set { this._CountingDate = value; } }

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

        private System.Int32? _CountingType;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CountingType { get { return this._CountingType; } set { this._CountingType = value; } }

        private System.String _CountingObject;
        /// <summary>
        /// 
        /// </summary>
        public System.String CountingObject { get { return this._CountingObject; } set { this._CountingObject = value; } }

        private System.Int32? _CountingWay;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CountingWay { get { return this._CountingWay; } set { this._CountingWay = value; } }

        private System.Int32? _CountingResult;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CountingResult { get { return this._CountingResult; } set { this._CountingResult = value; } }

        private System.String _CountingUser;
        /// <summary>
        /// 
        /// </summary>
        public System.String CountingUser { get { return this._CountingUser; } set { this._CountingUser = value; } }

        private System.String _CreatedDate;
        /// <summary>
        /// 
        /// </summary>
        public System.String CreatedDate { get { return this._CreatedDate; } set { this._CreatedDate = value; } }

        private System.Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsIdentity = true)]
        public System.Int32 ID { get { return this._ID; } set { this._ID = value; } }

        private System.String _ObjectID;
        /// <summary>
        /// 
        /// </summary>
        public System.String ObjectID { get { return this._ObjectID; } set { this._ObjectID = value; } }
    }
}