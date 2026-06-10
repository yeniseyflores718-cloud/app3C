using app3C.cafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_simulador_de_la_cafeteria
{
    internal class BebidaFria: bebida
    {
        private int CantidadHielo;

        public int cantidadHielo
        {
            get { return CantidadHielo; }
            set { CantidadHielo = value; }
        }
        public BebidaFria(string nombre, string tamaño, float precio, int cantidadHielo) : base(nombre, tamaño, precio)
        {
            CantidadHielo = cantidadHielo;
        }
        //polimorfismo
        public override string preparar()
        {
            return "Estamos preparando un : " + Nombre + " Helado (Con " + CantidadHielo +
                   " cubos de hielo) tamaño : " + Tamaño;
        }
        public string listar()
        {
            return "un/a  " + nombre + " frio";
        }
    }
}

