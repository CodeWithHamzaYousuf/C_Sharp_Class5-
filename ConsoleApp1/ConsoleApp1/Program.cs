namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Vehicle car = new Vehicle("Tesla","Red","ASDFG");
            //car.can_accelerate();

            Suzuki details = new Suzuki("T", "ASDFG", "Blue" , 2005);
            details.vehicle_details();

        }


        class Vehicle
        {

            public string name;
            public string model;
            public string color;


            public void veh() {
                Console.WriteLine($" The car details are {name} {model} {color} ");
            }


        }


        class Suzuki : Vehicle
        {
            public int brand;



            public Suzuki(string name, string color, string model,int brand)
           {
                this.name = name;
                this.color = color;
               this.model = model;
                this.brand = brand;
            }



            public void vehicle_details()
            {
                Console.WriteLine($" The car details are {this.name} {this.model} {this.color} and {this.brand}");
            }



        }





















        //class Vehicle
        //{
        //    public string name;
        //    public string color;
        //    public string model;


        //    public Vehicle(string name, string color, string model )
        //    {
        //        this.name = name;
        //        this.color = color;
        //       this.model = model;

        //    }

        //    public void can_accelerate ()
        //    {
        //        Console.WriteLine($" {name} with {color} and Model {model}");
        //    }
        //}


        //class 
        //{


        //    public void stdname()
        //    {
        //        Console.WriteLine($"Student name in child class{this.name} {this.age}");
        //    }

        //}

        //class C : A
        //{


        //    public void c_method()
        //    {
        //        Console.WriteLine("C Class Statement");
        //    }

        //}




    }
}
