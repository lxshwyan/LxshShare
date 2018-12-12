using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_CriminalMeet
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

        private System.String _StartDate;
        /// <summary>
        /// 
        /// </summary>
        public System.String StartDate { get { return this._StartDate; } set { this._StartDate = value; } }

        private System.String _EndDate;
        /// <summary>
        /// 
        /// </summary>
        public System.String EndDate { get { return this._EndDate; } set { this._EndDate = value; } }

        private System.Int32? _CountingStates;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CountingStates { get { return this._CountingStates; } set { this._CountingStates = value; } }

        private System.Int32? _CriminalCount;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CriminalCount { get { return this._CriminalCount; } set { this._CriminalCount = value; } }

        private System.String _BeforePolice;
        /// <summary>
        /// 
        /// </summary>
        public System.String BeforePolice { get { return this._BeforePolice; } set { this._BeforePolice = value; } }

        private System.String _BeforeToDept;
        /// <summary>
        /// 
        /// </summary>
        public System.String BeforeToDept { get { return this._BeforeToDept; } set { this._BeforeToDept = value; } }

        private System.String _BeforePolicePhone;
        /// <summary>
        /// 
        /// </summary>
        public System.String BeforePolicePhone { get { return this._BeforePolicePhone; } set { this._BeforePolicePhone = value; } }

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

        private System.Int32? _States;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? States { get { return this._States; } set { this._States = value; } }

        private System.String _AfterPolice;
        /// <summary>
        /// 
        /// </summary>
        public System.String AfterPolice { get { return this._AfterPolice; } set { this._AfterPolice = value; } }

        private System.String _AfterToDept;
        /// <summary>
        /// 
        /// </summary>
        public System.String AfterToDept { get { return this._AfterToDept; } set { this._AfterToDept = value; } }

        private System.String _AfterPolicePhone;
        /// <summary>
        /// 
        /// </summary>
        public System.String AfterPolicePhone { get { return this._AfterPolicePhone; } set { this._AfterPolicePhone = value; } }

        private System.String _CriminalID;
        /// <summary>
        /// 
        /// </summary>
        public System.String CriminalID { get { return this._CriminalID; } set { this._CriminalID = value; } }

        private System.Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsIdentity = true)]
        public System.Int32 ID { get { return this._ID; } set { this._ID = value; } }

        private System.String _Desc;
        /// <summary>
        /// 
        /// </summary>
        public System.String Desc { get { return this._Desc; } set { this._Desc = value; } }
    }
}