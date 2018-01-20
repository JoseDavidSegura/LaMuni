using System;
using Plugin.Media.Abstractions;
using Realms;

namespace LaMuni.Model
{
    public class ReportModel : RealmObject
    {

        #region Atributos

        public string reportId { get; set; }
        public string reporter { get; set; }
        public string reportDate { get; set; }
        public string reportType { get; set; }
        public string reportStatus { get; set; }
        public string detail { get; set; }
        public double latKey { get; set; }
        public double lonKey { get; set; }
        public string updateLog { get; set; }
        public string responseSummary { get; set; }
        public string responseDate { get; set; }
        public string responseReporter { get; set; }
        public byte[] photo { get; set; }

        #endregion
    }
}
