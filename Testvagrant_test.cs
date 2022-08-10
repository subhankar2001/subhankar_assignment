using System;

class planet
 { 
    public string name, gas, ring;
    public int numMoon;
  
    public int moon()
    {
     return numMoon;
        
    }
    
    public string gas()
    {
       return gas;
        
    }
    
    
    
    public static void Main(string[] args)
    {
         planet mercury =new planet();
         mercury.name = "mercury";
         mercury.gas= "";
         mercury.ring="no";
         mercury.numMoon =0;
         venus
        //  Console.Write(mercury.moon() + "\n");
        //  Console.Write(mercury.gass());
         
        //  Console.ReadLine();
         planet venus =new planet();
        venus.name = "Venus";
        venus.gas= "CO2,N2";
        venus.ring="no";
        venus.numMoon =0;

          planet Earth =new planet();
         Earth.name = "Earth";
         Earth.gas= "N2,O2";
         Earth.ring="no";
         Earth.numMoon =1;

          planet Jupitor =new planet();
         Jupitor.name = "Jupitor";
         Jupitor.gas= "H2,He";
         Jupitor.ring="yes";
         Jupitor.numMoon =79;
         
         Saturn planet Saturn =new planet();
         Saturn.name = "saturn";
         Saturn.gas= "H2,He";
         Saturn.ring="yes";
         Saturn.numMoon =83;

          planet Uranus =new planet();
         Uranus.name = "mercury";
         Uranus.gas= "H2,He,CH4";
         Uranus.ring="yes";
         Uranus.numMoon =27;

         
    
      
    }
}