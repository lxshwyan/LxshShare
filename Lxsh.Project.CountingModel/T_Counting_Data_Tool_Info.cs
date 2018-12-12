using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Tool_Info
    {
        private System.String _ToolNo;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String ToolNo { get { return this._ToolNo; } set { this._ToolNo = value; } }

        private System.String _ToolName;
        /// <summary>
        /// 
        /// </summary>
        public System.String ToolName { get { return this._ToolName; } set { this._ToolName = value; } }

        private System.String _ToolGroup;
        /// <summary>
        /// 
        /// </summary>
        public System.String ToolGroup { get { return this._ToolGroup; } set { this._ToolGroup = value; } }

        private System.String _ToolUser;
        /// <summary>
        /// 
        /// </summary>
        public System.String ToolUser { get { return this._ToolUser; } set { this._ToolUser = value; } }

        private System.String _ToolArea;
        /// <summary>
        /// 
        /// </summary>
        public System.String ToolArea { get { return this._ToolArea; } set { this._ToolArea = value; } }

        private System.DateTime? _GetDateTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? GetDateTime { get { return this._GetDateTime; } set { this._GetDateTime = value; } }

        private System.Int32? _States;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? States { get { return this._States; } set { this._States = value; } }

        private System.String _BelongTypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String BelongTypeCode { get { return this._BelongTypeCode; } set { this._BelongTypeCode = value; } }
    }
}