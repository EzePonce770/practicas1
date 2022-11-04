using System;

public class telefono
{
    public telefono(string modelo, string marca )
    {
        this.modelo = modelo;   
        this.marca = marca; 
    }

    {
        public string modelo { get; }
        public string marca { get; }
        public int numeroTelefono { get; set; }
        private int codigoOperador;

        public int codigoOperador
    {

        get { return codigoOperador; }

        set 
        {
            if (value > 0 && value < 3)
                codigoOperador = value;
            else
                codigoOperador = true;
        
        }

        telefono t1 = new telefono
    }


    }
}
