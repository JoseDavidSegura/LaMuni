using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaMuni.Model
{
    public class ReportTypeModel
    {
        #region Atributos

        public int typeId { get; set; }
        public string type { get; set; }

        #endregion

        public static List<ReportTypeModel> GetReportType()
        {

            List<ReportTypeModel> lstTypes = new List<ReportTypeModel>();

            lstTypes.Add(new ReportTypeModel { typeId = 1, type = "Bache en la carretera" });
            lstTypes.Add(new ReportTypeModel { typeId = 2, type = "Bache en la acera" });
            lstTypes.Add(new ReportTypeModel { typeId = 3, type = "Fuga de agua" });
            lstTypes.Add(new ReportTypeModel { typeId = 5, type = "Lote baldío en mal estado" });
            lstTypes.Add(new ReportTypeModel { typeId = 6, type = "Vehículo en vía" });
            lstTypes.Add(new ReportTypeModel { typeId = 7, type = "Botadero de basura" });
            lstTypes.Add(new ReportTypeModel { typeId = 8, type = "Otro" });

            return lstTypes;

        }
    }
}
