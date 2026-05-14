namespace recetify.Models;

pubic class SugeridorReceta
{
    public string Nombre {get; set;}
    public dateTime Nacimiento {get; set;}
    public int Tipo {get; set;}
    public int Presupuesto {get; set;}
    public int Cantidad {get; set;}

    public SugeridorReceta()
    {

    }

    public SugeridorReceta(string nombre, dateTime nacimiento, int tipo, int presupuesto, int cantidad)
    {
        Nombre = nombre;
        Nacimiento = nacimiento;
        Tipo = tipo;
        Presupuesto = presupuesto;
        Cantidad = cantidad;
    }

    public int CalcularEdad()
    {
        int edad = DateTime.Today.year - Nacimiento.year;
        return edad;
    }

    public string DeterminarPlato()
    {
        if(Tipo == 1)
        {
            else if(Presupuesto < 3000 && Presupuesto > 0)
            {
                return "Fideos con manteca";
            }
            else if(Presupuesto < 7000 && Presupuesto > 3000)
            {
                return "Arroz con verduras salteadas";
            }
            else
            {
                return "Pollo al horno con guarnición";
            }
        }
        else
        {
            else if(Presupuesto < 3000 && Presupuesto > 0)
            {
                return "Ensalada simple";
            }
            else if(Presupuesto < 7000 && Presupuesto > 3000)
            {
                return "Ensalada completa con proteína";
            }
            else
            {
                return "Tabla de fiambres y quesos";
            }
        }
    }

    public int CalcularTiempo()
    {
        if(Tipo == 1)
        {
            else if(Cantidad == 1)
            {
                return 20;
            }
            else if(Cantidad == 2 || Cantidad == 3)
            {
                return 20;
            }
            else if(Cantidad > 3 && Cantidad < 8)
            {
                return 40;
            }
            else
            {
                return 80;
            }
        }
        else
        {
            else if(Cantidad > 0 && Cantidad < 4)
            {
                return 10;
            }
            else if(Cantidad > 3 && Cantidad < 8)
            {
                return 20;
            }
            else
            {
                return 40;
            }
        }
    }

    public string DeterminarDificultad()
    {
        if(Presupuesto < 3000)
        {
            else if(Cantidad > 0 && Cantidad < 4)
            {
                return "Principiante";
            }
            else if(Cantidad > 3 && Cantidad < 8)
            {
                return "Intermedio";
            }
        }
        if(Presupuesto >= 3000 && Presupuesto <= 7000)
        {
            else if(Cantidad > 0 && Cantidad < 4)
            {
                return "Intermedio";
            }
            else if(Cantidad > 3 && Cantidad < 8)
            {
                return "Intermedio";
            }
        }
        if(Presupuesto > 7000)
        {
            else if(Cantidad > 0 && Cantidad < 8)
            {
                return "Intermedio";
            }
        }
        else
        {
            return "Avanzado";
        }
    }

    public string GenerarSaludo()
    {
        if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour <= 12)
        {
            return "Buenos días"
        }
        if(DateTime.Now.Hour > 12 && DateTime.Now.Hour < 20)
        {
            return "Buenas tardes"
        }
        else
        {
            return "Buenas noches"
        }
    }

    public string GenerarTip()
    {
        int edad = CalcularEdad();
        if(edad < 18)
        {
            return "PELIGRO A MENORES DE 18 AÑOS"
        }
        if(edad >= 60)
        {
            return "AQUÍ TIENES TU MENSAJE ESPECIAL"
        }
        else
        {
            return "YOU CAN DO IT"
        }
    }
}