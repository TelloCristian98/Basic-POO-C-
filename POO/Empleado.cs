class Empleado : IMostrarInformacion
{
    public string nombre;
    public double sueldo;

    public Empleado(string nombre, double sueldo)
    {
        this.nombre = nombre;
        this.sueldo = sueldo * 12;
    }
    public Empleado()
    {
        this.nombre = "";
        this.sueldo = 0.0;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public double Sueldo
    {
        get { return sueldo; }
        set { sueldo = value * 12; }
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Nombre: {0}, Sueldo: {1}", nombre, sueldo);
    }
}