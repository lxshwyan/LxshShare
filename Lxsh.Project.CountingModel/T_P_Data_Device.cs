using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class T_P_Data_Device
    {
        private System.String _DeviceID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String DeviceID { get { return this._DeviceID; } set { this._DeviceID = value; } }

        private System.String _DepartmentID;
        /// <summary>
        /// 
        /// </summary>
        public System.String DepartmentID { get { return this._DepartmentID; } set { this._DepartmentID = value; } }
    }
}