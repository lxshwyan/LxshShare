using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_Counting_Data_Tool_RecordDetail
    {
        private System.String _FK_Plan_SeqNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String FK_Plan_SeqNo { get { return this._FK_Plan_SeqNo; } set { this._FK_Plan_SeqNo = value; } }

        private System.String _FK_Tool_SeqNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String FK_Tool_SeqNo { get { return this._FK_Tool_SeqNo; } set { this._FK_Tool_SeqNo = value; } }
    }
}