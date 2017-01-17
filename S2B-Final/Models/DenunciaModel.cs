using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace S2B_Final.Models
{
    public class DenunciaModel
    {
        public int ID { get; set; }
        public String DescricaoOcorrido { get; set; }
        public DateTime DataOcorrido { get; set; }
        public String HorarioOcorrido { get; set; }
        public String LocalOcorrido { get; set; }
        public String TipoOcorrencia { get; set; }
        public String CaracteristicasSuspeito { get; set; }
        public String Ip { get; set; }
        public String Navegador { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
    }

    public class DenunciaCreateViewModel
    {
        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        public String DescricaoOcorrido { get; set; }
        [Required(ErrorMessage = "Campo Data Obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Campo em formato inválido")]
        [Display(Name = "Data")]
        public DateTime DataOcorrido { get; set; }
        [Display(Name = "Horário")]
        public String HorarioOcorrido { get; set; }
        [Required(ErrorMessage = "Campo Local Obrigatório")]
        [Display(Name = "Local")]
        public String LocalOcorrido { get; set; }
        [Display(Name = "Tipo de Denúncia")]
        [Required(ErrorMessage = "Campo Data Obrigatório")]
        public String TipoOcorrencia { get; set; }
        [Display(Name = "Caracteristicas do Suspeito")]
        [DataType(DataType.MultilineText)]
        public String CaracteristicasSuspeito { get; set; }
        public String Ip { get; set; }
        public String Navegador { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
    }

    public class DenunciaEditViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        public String DescricaoOcorrido { get; set; }
        [Required(ErrorMessage = "Campo Data Obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Campo em formato inválido")]
        [Display(Name = "Data")]
        public DateTime DataOcorrido { get; set; }
        [Display(Name = "Horário")]
        public String HorarioOcorrido { get; set; }
        [Required(ErrorMessage = "Campo Local Obrigatório")]
        [Display(Name = "Local")]
        public String LocalOcorrido { get; set; }
        [Display(Name = "Tipo de Denúncia")]
        [Required(ErrorMessage = "Campo Data Obrigatório")]
        public String TipoOcorrencia { get; set; }
        [Display(Name = "Caracteristicas do Suspeito")]
        [DataType(DataType.MultilineText)]
        public String CaracteristicasSuspeito { get; set; }
        public String Ip { get; set; }
        public String Navegador { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
    }
    
    public class DenunciaDeleteViewModel
    {
        public int ID { get; set; }
        public String DescricaoOcorrido { get; set; }
        public DateTime DataOcorrido { get; set; }
        public String HorarioOcorrido { get; set; }
        public String LocalOcorrido { get; set; }
        public String TipoOcorrencia { get; set; }
        public String CaracteristicasSuspeito { get; set; }
        public String Ip { get; set; }
        public String Navegador { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
    }

    public class DenunciaDisplayViewModel
    {
        public int ID { get; set; }
        public String DescricaoOcorrido { get; set; }
        public DateTime DataOcorrido { get; set; }
        public String HorarioOcorrido { get; set; }
        public String LocalOcorrido { get; set; }
        public String TipoOcorrencia { get; set; }
        public String CaracteristicasSuspeito { get; set; }
        public String Ip { get; set; }
        public String Navegador { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
    }
}