using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Asociacion
{
    class Auto : Vehiculo
    {

        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        // COMPOSICION 
        public Chasis Chasis { get; }       // el auto TIENE que NACER con un CHASIS


        // AGREGACION
        public Motor Motor { get; set; }    // objeto tipo MOTOR como propiedad    |  Esto es una asociacion


        // CONSTRUCTOR
        public Auto()
        {
            Chasis = new Chasis();

            // cuando creo un auto TIENE QUE NACER CON UN CHASIS
        }



        /* la DIFERENCIA e/ composicion y agregacion es el nivel de relacion que tiene el objeto Motor que lo esta asociando con el objeto Auto(LA CLASE) que
         * lo esta alojando. el nivel de cercania se puede definir si el objeto AUTO puede NACER sin el objeto MOTOR o tiene que nacer si o si con el objeto MOTOR.
         * 
         * 
         * COMPOSICION -> que cosas COMPONEN a un auto ademas de sus propiedades-> MOTOR
                       -> relacion cercana, el objeto AUTO TIENE QUE NACER con el objeto MOTOR | se puede hacer a nivel constructor
                                            - al hacer un constructor del objeto AUTO donde incluyo la asociacion del objeto MOTOR, el motor nace con el auto (COMPOSICION)         * 
         * 
         * 
         * AGREGACION -> cosas que se pueden AGREGAR despues del nacimiento del objeto, en este caso el objeto motor
         *            -> la relacion es lejana, se puede crear/nacer el objeto auto y despues se AGREGA como una prop de objeto     * 
         * 
         */

    }
}
