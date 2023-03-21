using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Ejercicio2
{
    public  class Persona
    {
        //Atributos

        private int years;
        private string nombre;
        private string apellido;
        private int peso;

        public int Years
        {
            set { years = value; }
            get { return years; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Apellido
        {
            set { apellido = value; }
            get
            {
                return apellido;
            }
        }
        public int Peso
        {
            set { peso = value; }
            get { return peso; }
        }
        public Persona(int years, string nombre, string apellido)
        {
            Years = years;
            Nombre = nombre;
            Apellido = apellido;    
        }
        public  void Creser (string _years)
        {
            int year;
          
            if (int.TryParse(_years,out year))
            {
                Years += year;     
            }
            else
            {
                MessageBox.Show("El Campo debe ser un numero");
            }
        }
        public void SubirPeso (string _peso)
        {
            int peso;
            if (int.TryParse(_peso,out peso))
            {
                Peso += peso;
            }
            else
            {
                MessageBox.Show("El Campo debe ser un numero");
            }
        }

        public void CargarNombreApellido (string _nombre, string _apellido)
        {
            Nombre = _nombre;
            Apellido = _apellido;
        }
        public bool Morir()
        {
            bool morir = false;
            int _peso = Peso;
            int _year = Years;
            if (_year > 100 || _peso >300)
            {
                morir = true;
                Nombre = "";
                Apellido = "";
                Years = 0;
                Peso = 0;

            }
            return morir;         
        } 
    }
}
