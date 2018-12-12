using SqlSugar;

namespace Lxsh.Project.CountingModel
{
    /// <summary>
    /// 
    /// </summary>
    public class CriminalInfo
    {
        private System.String _CriminalID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public System.String CriminalID { get { return this._CriminalID; } set { this._CriminalID = value; } }

        private System.String _CriminalName;
        /// <summary>
        /// 
        /// </summary>
        public System.String CriminalName { get { return this._CriminalName; } set { this._CriminalName = value; } }

        private System.String _RealName;
        /// <summary>
        /// 
        /// </summary>
        public System.String RealName { get { return this._RealName; } set { this._RealName = value; } }

        private System.String _Sex;
        /// <summary>
        /// 
        /// </summary>
        public System.String Sex { get { return this._Sex; } set { this._Sex = value; } }

        private System.String _Marriages;
        /// <summary>
        /// 
        /// </summary>
        public System.String Marriages { get { return this._Marriages; } set { this._Marriages = value; } }

        private System.String _CardID;
        /// <summary>
        /// 
        /// </summary>
        public System.String CardID { get { return this._CardID; } set { this._CardID = value; } }

        private System.DateTime? _Birth;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? Birth { get { return this._Birth; } set { this._Birth = value; } }

        private System.String _NationInfo;
        /// <summary>
        /// 
        /// </summary>
        public System.String NationInfo { get { return this._NationInfo; } set { this._NationInfo = value; } }

        private System.String _PunishmentTime;
        /// <summary>
        /// 
        /// </summary>
        public System.String PunishmentTime { get { return this._PunishmentTime; } set { this._PunishmentTime = value; } }

        private System.String _OldPunishmentTime;
        /// <summary>
        /// 
        /// </summary>
        public System.String OldPunishmentTime { get { return this._OldPunishmentTime; } set { this._OldPunishmentTime = value; } }

        private System.String _Accusation;
        /// <summary>
        /// 
        /// </summary>
        public System.String Accusation { get { return this._Accusation; } set { this._Accusation = value; } }

        private System.DateTime? _InPrisonTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? InPrisonTime { get { return this._InPrisonTime; } set { this._InPrisonTime = value; } }

        private System.DateTime? _OutPrisonTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? OutPrisonTime { get { return this._OutPrisonTime; } set { this._OutPrisonTime = value; } }

        private System.DateTime? _OldOutPrisonTIme;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? OldOutPrisonTIme { get { return this._OldOutPrisonTIme; } set { this._OldOutPrisonTIme = value; } }

        private System.String _PhotoInfo;
        /// <summary>
        /// 
        /// </summary>
        public System.String PhotoInfo { get { return this._PhotoInfo; } set { this._PhotoInfo = value; } }

        private System.String _Nationality;
        /// <summary>
        /// 
        /// </summary>
        public System.String Nationality { get { return this._Nationality; } set { this._Nationality = value; } }

        private System.String _HomeAddress;
        /// <summary>
        /// 
        /// </summary>
        public System.String HomeAddress { get { return this._HomeAddress; } set { this._HomeAddress = value; } }

        private System.String _CriminalStatus;
        /// <summary>
        /// 
        /// </summary>
        public System.String CriminalStatus { get { return this._CriminalStatus; } set { this._CriminalStatus = value; } }

        private System.String _CriminalFacts;
        /// <summary>
        /// 
        /// </summary>
        public System.String CriminalFacts { get { return this._CriminalFacts; } set { this._CriminalFacts = value; } }

        private System.String _OldEducation;
        /// <summary>
        /// 
        /// </summary>
        public System.String OldEducation { get { return this._OldEducation; } set { this._OldEducation = value; } }

        private System.String _NowEducation;
        /// <summary>
        /// 
        /// </summary>
        public System.String NowEducation { get { return this._NowEducation; } set { this._NowEducation = value; } }

        private System.String _OldJob;
        /// <summary>
        /// 
        /// </summary>
        public System.String OldJob { get { return this._OldJob; } set { this._OldJob = value; } }

        private System.String _OldPoliticsState;
        /// <summary>
        /// 
        /// </summary>
        public System.String OldPoliticsState { get { return this._OldPoliticsState; } set { this._OldPoliticsState = value; } }

        private System.Int32 _CriminalType;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CriminalType { get { return this._CriminalType; } set { this._CriminalType = value; } }

        private System.String _Remarks;
        /// <summary>
        /// 
        /// </summary>
        public System.String Remarks { get { return this._Remarks; } set { this._Remarks = value; } }

        private System.String _ObjectID;
        /// <summary>
        /// 
        /// </summary>
        public System.String ObjectID { get { return this._ObjectID; } set { this._ObjectID = value; } }

        private System.String _BelongTypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String BelongTypeCode { get { return this._BelongTypeCode; } set { this._BelongTypeCode = value; } }

        private System.Int32? _InPrison;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? InPrison { get { return this._InPrison; } set { this._InPrison = value; } }

        private System.String _Criticality;
        /// <summary>
        /// 
        /// </summary>
        public System.String Criticality { get { return this._Criticality; } set { this._Criticality = value; } }

        private System.String _Groups;
        /// <summary>
        /// 
        /// </summary>
        public System.String Groups { get { return this._Groups; } set { this._Groups = value; } }

        private System.String _OldBelongTypeCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String OldBelongTypeCode { get { return this._OldBelongTypeCode; } set { this._OldBelongTypeCode = value; } }

        private System.Int32? _Sync;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Sync { get { return this._Sync; } set { this._Sync = value; } }

        private System.String _CountedLocation;
        /// <summary>
        /// 
        /// </summary>
        public System.String CountedLocation { get { return this._CountedLocation; } set { this._CountedLocation = value; } }
    }
}