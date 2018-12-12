using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class PrisonConfig
    {
        private System.String _Code;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String Code { get { return this._Code; } set { this._Code = value; } }

        private System.String _UName;
        /// <summary>
        /// 
        /// </summary>
        public System.String UName { get { return this._UName; } set { this._UName = value; } }

        private System.Int32? _Level;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Level { get { return this._Level; } set { this._Level = value; } }

        private System.String _ParentCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String ParentCode { get { return this._ParentCode; } set { this._ParentCode = value; } }
    }
}