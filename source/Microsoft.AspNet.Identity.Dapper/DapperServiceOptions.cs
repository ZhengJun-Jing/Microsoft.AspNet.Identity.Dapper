using System;
using System.Data;

namespace Microsoft.AspNet.Identity.Dapper
{
    public class TableNames
    {
        private string _role;
        private string _user;
        private string _userClaims;
        private string _userLogins;
        private string _userRoles;

        public string Role
        {
            get { return String.IsNullOrEmpty(this._role) ? "AspNetRoles" : this._role; }
            set { this._role = value.Trim(); }
        }

        public string User
        {
            get { return String.IsNullOrEmpty(this._user) ? "AspNetUsers" : this._user; }
            set { this._user = value.Trim(); }
        }
        public string UserClaims
        {
            get { return String.IsNullOrEmpty(this._userClaims) ? "AspNetUserClaims" : this._userClaims; }
            set { this._userClaims = value.Trim(); }
        }
        public string UserLogins
        {
            get { return String.IsNullOrEmpty(this._userLogins) ? "AspNetUserLogins" : this._userLogins; }
            set { this._userLogins = value.Trim(); }
        }
        public string UserRoles
        {
            get { return String.IsNullOrEmpty(this._userRoles) ? "AspNetUserRoles" : this._userLogins; }
            set { this._userRoles = value.Trim(); }
        }
    }

    public class DapperServiceOptions
    {
        private IDbConnection _connection;
        private TableNames _tableNames;

        public DapperServiceOptions(IDbConnection connection)
        {
            Connection = connection ?? throw new ArgumentNullException("connection");
        }

        public IDbConnection Connection
        {
            get { return this._connection; }
            private set { this._connection = value; }
        }

        public TableNames TableNames
        {
            get { return this._tableNames ?? new TableNames(); }
            set { this._tableNames = value; }
        }
    }
}
