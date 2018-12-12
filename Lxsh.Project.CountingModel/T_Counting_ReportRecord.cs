using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_ReportRecord
    {
        private System.String _PlanTime;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String PlanTime { get { return this._PlanTime; } set { this._PlanTime = value; } }

        private System.String _CountingUser;
        /// <summary>
        /// 
        /// </summary>
        public System.String CountingUser { get { return this._CountingUser; } set { this._CountingUser = value; } }

        private System.DateTime? _CreatedDate;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? CreatedDate { get { return this._CreatedDate; } set { this._CreatedDate = value; } }
    }
}