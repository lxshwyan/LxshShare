using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_P_Data_Type_Object
    {
        private System.Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsIdentity = true)]
        public System.Int32 ID { get { return this._ID; } set { this._ID = value; } }

        private System.String _FK_Type_SeqNo;
        /// <summary>
        /// 
        /// </summary>
        public System.String FK_Type_SeqNo { get { return this._FK_Type_SeqNo; } set { this._FK_Type_SeqNo = value; } }

        private System.String _FK_Object_ObjectID;
        /// <summary>
        /// 
        /// </summary>
        public System.String FK_Object_ObjectID { get { return this._FK_Object_ObjectID; } set { this._FK_Object_ObjectID = value; } }
    }
}