using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class RealLocationUpdateConfig
    {
        private System.DateTime? _DateTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? DateTime { get { return this._DateTime; } set { this._DateTime = value; } }

        private System.Int32? _Status;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Status { get { return this._Status; } set { this._Status = value; } }

        private System.Int32? _Command;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Command { get { return this._Command; } set { this._Command = value; } }

        private System.String _SeqNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String SeqNo { get { return this._SeqNo; } set { this._SeqNo = value; } }

        private System.String _Criminal;
        /// <summary>
        /// 
        /// </summary>
        public System.String Criminal { get { return this._Criminal; } set { this._Criminal = value; } }

        private System.Int32? _Types;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Types { get { return this._Types; } set { this._Types = value; } }
    }
}