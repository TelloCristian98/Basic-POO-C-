class Program
{
    static void Main(string[] args)
    {
        Empleado empleado = new Empleado();
        Console.WriteLine("Datos del Empleado:");
        Console.WriteLine("Ingrese su nombre: ");
        string empName = Console.ReadLine();
        Console.WriteLine("Ingrese su sueldo: ");
        double empSalary = Convert.ToDouble(Console.ReadLine());
        empleado.Nombre = empName;
        empleado.Sueldo = empSalary;

        Gerente gerente = new Gerente("Pedro", 2000, "Sistemas");
        Console.WriteLine("Datos del Gerente:");
        Console.WriteLine("Ingrese su nombre: ");
        string gerName = Console.ReadLine();
        Console.WriteLine("Ingrese su sueldo: ");
        double gerSalary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese su departamento: ");
        string gerDepartment = Console.ReadLine();
        gerente.Nombre = gerName;
        gerente.Sueldo = gerSalary;
        gerente.Departamento = gerDepartment;

        empleado.MostrarInformacion();
        gerente.MostrarInformacion();
    }
}
