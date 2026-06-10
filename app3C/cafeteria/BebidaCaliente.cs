using app3C.cafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace El_simulador_de_la_cafeteria
{
    internal class BebidaCaliente : bebida
    {
        private float Temperatura;

        public float temperatura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }
        //constructor 
        public BebidaCaliente(string nombre, string tamano, float precio, int temperatura) : base(nombre, tamano, precio)
        {
            this.Temperatura = temperatura;
        }
        //polimorfismo
        public override string preparar()
        {
            return "Estamos preparando un : " + Nombre + " Caliente (Temperatura: " + Temperatura +
                   "°C) tamaño : " + Tamaño;
        }
        public string listar()
        {
            return "un/a  "+ nombre+ " caliente";
        }
    }
}
