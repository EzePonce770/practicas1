using System;
using System.Diagnostics.Contracts;

public class telefono
{
    public telefono(string modelo, string marca )
    {
        this.modelo = modelo;   
        this.marca = marca; 
    }

    
        public string modelo { get; }
        public string marca { get; }
        public int numeroTelefono { get; set; }
    


        public int codigoOperador
    {

        get { return codigoOperador; }

        set
        {
            if (value > 0 && value < 3)
                codigoOperador = value;
            else
                codigoOperador = 0;

        }
    }
        public string Llamar() 
        {
        return "Realizando llamada";

        }
        //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        public string Llamar(string Contacto) 
        {
            return "Llamando a contacto.."+ Contacto;

        }

        //Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
        


    }


    

