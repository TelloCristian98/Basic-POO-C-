class Gerente : Empleado 
{
    public string departamento;

    public Gerente(string nombre, double sueldo) : base(nombre, sueldo)
    {
    }

    public Gerente(string nombre, double sueldo, string departamento) : base(nombre, sueldo)
    {
        this.departamento = departamento;
    }

    public string Departamento
    {
        get { return departamento; }
        set { departamento = value; }
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Nombre: {0}, Sueldo: {1}, Departamento: {2}", nombre, sueldo, departamento);
    }
}