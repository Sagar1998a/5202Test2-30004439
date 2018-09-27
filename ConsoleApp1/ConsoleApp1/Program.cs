/*
 sagar devkota 
 student Id=30004439
  */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
     string name, specices, sex weight, bandno
       public string name 
     {
      get {return name; }
      set {name =Value;}
    
     }
     public string species
     {
      get {return species; }
      set {specices =Value;}
    
     }
     public string sex
     {
      get {return sex; }
      set {sex =Value;}
    
     }
     public string  Weight
     {
      get {return weight; }
      set {weight =Value;}
    
     }
       public string  Bandno
     {
      get {return bandno; }
      set {bandno =Value;}
    
     }
     public Bird(string _name, string _species, string _sex, string _weight, string bandno)
     {
      Name= _name;
     Species= _species;
     Sex= _sex;
     Weight= _weight;
     Bandno= _bandno;
}
    }
 publi string Birdname()
 {
  return "bird name="+ Bird+ "Species=" +Species+ "Sex of Bird"+ Sex+ " Weight of Bird"+ Weight+" Bandnumber"+ Bandno;
 


        static void Main(string[] args)
        {
            Console.Write("Please enter bird name: ");
            string bird = Console.ReadLine();
            Console.Write("Please enter species name: ");
            string species = Console.ReadLine();
            Console.Write("Please enter sex name: ");
            string sex = Console.ReadLine();
            Console.Write("Please enter weight name: ");
            string weight= Console.ReadLine();
            Console.Write("Please enter bandno name: ");
            string bandno = Console.ReadLine();



        }
    }
}
