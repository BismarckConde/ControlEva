using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEva
{
    public class Promedio
    {
        [Required(ErrorMessage ="EL NOMBRE DEL ESTUIANTES SE DEBE REGISTRAR... POR FAVOR INGRESE EL NOMBE")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "LA EVALUACION 1 SE DEBE REGISTRAR... POR FAVOR INGRESE LA EVALUACION")]
        [Range(0,100,ErrorMessage =" LA EVALUACION QUE INGRESO NO ESTA EN EL RANGO DE 0 A 100... POR FAVOR INGRESE UNA EVALUCION QUE ESTE EN ESE RANGO")]
        public double eva1 { get; set; }
        [Required(ErrorMessage = "LA EVALUACION 2 SE DEBE REGISTRAR... POR FAVOR INGRESE LA EVALUACION")]
        [Range(0, 100, ErrorMessage = " LA EVALUACION QUE INGRESO NO ESTA EN EL RANGO DE 0 A 100... POR FAVOR INGRESE UNA EVALUCION QUE ESTE EN ESE RANGO")]
        public double eva2 { get; set; }
        [Required(ErrorMessage = "LA EVALUACION 3 SE DEBE REGISTRAR... POR FAVOR INGRESE LA EVALUACION")]
        [Range(0, 100, ErrorMessage = " LA EVALUACION QUE INGRESO NO ESTA EN EL RANGO DE 0 A 100... POR FAVOR INGRESE UNA EVALUCION QUE ESTE EN ESE RANGO")]
        public double eva3 { get; set; }
        [Required(ErrorMessage = "LA NOTA ACTITUDINAL SE DEBE REGISTRAR... POR FAVOR INGRESE LA NOTA ACTITUDINAL")]
        [Range(0, 100, ErrorMessage = " LA NOTA ACTITUDINAL QUE INGRESO NO ESTA EN EL RANGO DE 0 A 100... POR FAVOR INGRESE UNA NOTA ACTITUDINAL QUE ESTE EN ESE RANGO")]
        public double NActtitu { get; set; }


        public virtual double CalcularPromedio()
        {
            return (eva1 + eva2 + eva3 + NActtitu) / 4;   

        }
    }
}
