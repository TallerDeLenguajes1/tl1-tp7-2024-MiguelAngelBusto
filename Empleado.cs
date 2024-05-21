namespace administracion;

public enum Cargo {
    Auxiliar, 
    Administrativo,
     Ingeniero,
    Especialista, 
    Investigador
}

public class Empleado {
    private string Nombre;
    private string Apellido;
    private DateTime FechaNa;
    private char EstadoC;
    private DateTime FechaIn;
    private double SueldoB;

    private Cargo cargo;

    public Empleado (string x,string y, DateTime z,char e, DateTime w, double s, Cargo j){
        this.Nombre=x;
        this.Apellido=y;
        this.FechaNa=z;
        this.EstadoC=e;
        this.FechaIn=w;
        this.SueldoB=s;
        this.cargo=j;
    }
    public string getNombre (){
        return this.Nombre;
    }
    public string getApellido(){
        return this.Apellido;
    }
    public int Antiguedad (){
        int x = (2024-this.FechaIn.Year);
        return x;
    }
    public int edad (){
        return (2024-this.FechaNa.Year);
    }
    public int paraJubilarse (){
        return (65-this.edad());
    }

    private double Adicional (){
        double x = 0;
        if(this.Antiguedad()<20){
                x = this.Antiguedad()/100;
        }else {
            x=0.25;
        }
        if(this.cargo ==Cargo.Ingeniero || this.cargo == Cargo.Especialista ){
            x=x*1.50;
        }

        return x; 
    }

    public double Salario (){
        double x = this.Adicional();
        if(this.EstadoC == 'C' || this.EstadoC == 'c'){
            return (this.SueldoB+this.SueldoB*x+150000);
        }
        else{
            return (this.SueldoB+this.SueldoB*x);
        }
    } 

}
