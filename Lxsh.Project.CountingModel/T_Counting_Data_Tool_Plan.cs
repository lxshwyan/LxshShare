using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Tool_Plan
    {
        private System.String _AreaNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String AreaNo { get { return this._AreaNo; } set { this._AreaNo = value; } }

        private System.String _PlanTime;
        /// <summary>
        /// 
        /// </summary>
        public System.String PlanTime { get { return this._PlanTime; } set { this._PlanTime = value; } }

        private System.Int32? _States;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? States { get { return this._States; } set { this._States = value; } }

        private System.String _Reporter;
        /// <summary>
        /// 
        /// </summary>
        public System.String Reporter { get { return this._Reporter; } set { this._Reporter = value; } }

        private System.String _ToDept;
        /// <summary>
        /// 
        /// </summary>
        public System.String ToDept { get { return this._ToDept; } set { this._ToDept = value; } }

        private System.String _PolicePhone;
        /// <summary>
        /// 
        /// </summary>
        public System.String PolicePhone { get { return this._PolicePhone; } set { this._PolicePhone = value; } }

        private System.String _CreatedDate;
        /// <summary>
        /// 
        /// </summary>
        public System.String CreatedDate { get { return this._CreatedDate; } set { this._CreatedDate = value; } }

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

        private System.String _ObjectID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String ObjectID { get { return this._ObjectID; } set { this._ObjectID = value; } }
    }
}