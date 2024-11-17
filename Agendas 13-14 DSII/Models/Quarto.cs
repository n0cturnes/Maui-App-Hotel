using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendas_13_14_DSII.Models
{
    public class Quarto
    {
        public required String descricao { get; set; }
        public required double vDiariaAdulto {  get; set; }
        public required double vDiariaCrianca { get; set; }

    }
}
