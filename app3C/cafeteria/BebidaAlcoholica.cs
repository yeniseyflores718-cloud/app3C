using El_simulador_de_la_cafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3C.cafeteria
{
    internal class BebidaAlcoholica : bebida
    {
        private int porcentajeAlcohol;
        private string gluten;

        public int PorcentajeAlcohol
        {
            get { return porcentajeAlcohol; }
            set { porcentajeAlcohol = value; }
        }
        public string Gluten
        {
            get { return gluten; }
            set { gluten = value; }
        }

        public BebidaAlcoholica(string nombre, string tamano, float precio, int gradosAlcohol, string gluten) : base(nombre, tamano, precio)
        {
            this.porcentajeAlcohol = gradosAlcohol;
            this.gluten = gluten;
        }

        public override string preparar()
        {
            return "Estamos preparando un : " + Nombre + " Alcoholica con:  " + porcentajeAlcohol +
                   "% de alcohol tamaño : " + Tamaño + " Gluten: " + Gluten;
        }

        public string listar()
            {
                return "un/a  " + nombre + " alcoholica";
        }
    }
}
