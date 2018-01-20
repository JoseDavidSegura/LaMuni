using System;
using Realms;

namespace LaMuni.Model
{
    public class InicioModel : RealmObject
    {
        public bool RecuerdaUser { get; set; }
        public string LastLogin { get; set; }

    }
}
