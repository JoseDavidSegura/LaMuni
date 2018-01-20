namespace LaMuni.Model
{

    using System;
    using Realms;

    public class UsersModel : RealmObject
    {

        #region Atributos

        [PrimaryKey]
        public string userId { get; set; }
        public string userNick { get; set; }
        public string name { get; set; }
        public string firstLastName { get; set; }
        public string secondLastName { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string phone { get; set; }
        public string userType { get; set; }
        public string token { get; set; }
        public byte[] userPhoto { get; set; }

        #endregion


    }
}

