using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class DataPrisonGroup
    {
        private System.Guid _PrisonGroupID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.Guid PrisonGroupID { get { return this._PrisonGroupID; } set { this._PrisonGroupID = value; } }

        private System.String _PrisonGroupLevel;
        /// <summary>
        /// 
        /// </summary>
        public System.String PrisonGroupLevel { get { return this._PrisonGroupLevel; } set { this._PrisonGroupLevel = value; } }

        private System.Guid? _GroupUpperID;
        /// <summary>
        /// 
        /// </summary>
        public System.Guid? GroupUpperID { get { return this._GroupUpperID; } set { this._GroupUpperID = value; } }

        private System.String _PrisonGroupName;
        /// <summary>
        /// 
        /// </summary>
        public System.String PrisonGroupName { get { return this._PrisonGroupName; } set { this._PrisonGroupName = value; } }

        private System.String _OrderNum;
        /// <summary>
        /// 
        /// </summary>
        public System.String OrderNum { get { return this._OrderNum; } set { this._OrderNum = value; } }
    }
}