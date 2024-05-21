// See https://aka.ms/new-console-template for more information
using administracion;

Empleado Emp1 = new Empleado("Miguel","Bustos",DateTime.Parse("1989/04/30"),'s',DateTime.Parse("2001/04/30"),500000,Cargo.Ingeniero);
Empleado Emp2 = new Empleado("Patricio","Jeader",DateTime.Parse("1939/04/30"),'c',DateTime.Parse("1996/04/30"),1500000,Cargo.Ingeniero);
Empleado Emp3 = new Empleado("Joaquin","Lechesi",DateTime.Parse("1969/04/30"),'c',DateTime.Parse("2012/04/30"),3500000,Cargo.Ingeniero);

Console.WriteLine(Emp1.Antiguedad());
Console.WriteLine(Emp2.Antiguedad());
Console.WriteLine(Emp3.Antiguedad());

Console.WriteLine(Emp1.edad());
Console.WriteLine(Emp2.edad());
Console.WriteLine(Emp3.edad());

Console.WriteLine(Emp1.paraJubilarse());
Console.WriteLine(Emp2.paraJubilarse());
Console.WriteLine(Emp3.paraJubilarse());


Console.WriteLine(Emp1.Salario());
Console.WriteLine(Emp2.Salario());
Console.WriteLine(Emp3.Salario());



if(Emp1.paraJubilarse()>Emp2.paraJubilarse()){
    if(Emp2.paraJubilarse()>Emp3.paraJubilarse()){
        Console.WriteLine("El mas proximo es: "+Emp3.getNombre()+" "+Emp3.getApellido());
    } else {
        Console.WriteLine("El mas proximo es: "+Emp2.getNombre()+" "+Emp2.getApellido());
    }
}else{
    if(Emp1.paraJubilarse()>Emp3.paraJubilarse()){
        Console.WriteLine("El mas proximo es: "+Emp3.getNombre()+" "+Emp3.getApellido());
    } else {
        Console.WriteLine("El mas proximo es: "+Emp1.getNombre()+" "+Emp1.getApellido());
    }
}
