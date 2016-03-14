using System;
using System.Collections.Generic;
 
public class HelloWorld
{

  class Vehicle {
    public string color { get; set; }
    public int tires { get; set; }
    public int seats { get; set; }


    public Vehicle(){
      this.color = "Regular-White";
      this.tires = 4;      
      this.seats = 2;
    } 

    public Vehicle(string color, int tires, int seats){
      this.color = color;
      this.tires = tires;
      this.seats = seats;
    }  
  }

  class Car:Vehicle{

    public string brand { get; set; }

    public Car():base(){
      this.brand = "Suzuki 1990";
    }

    public Car(string brand, string color, int tires, int seats ):base(color, tires, seats){
      this.brand = brand;
      this.color = color;
      this.tires = tires;
      this.seats = seats;
    }
  }  


  class Plane:Vehicle{

    public double maxHight { get; set; }

    public Plane():base(){
      this.maxHight = 100;
    }

    public Plane(double maxHight, string color, int tires, int seats ):base(color, tires, seats){
      this.maxHight = maxHight;
      this.color = color;
      this.tires = tires;
      this.seats = seats;
    }
  }  


  class Truck:Vehicle{

    public int weightCapacity { get; set; }

    public Truck():base(){
      this.weightCapacity = 0;
    }

    public Truck(int weightCapacity, string color, int tires, int seats):base(color, tires, seats){
      this.weightCapacity = weightCapacity;
      this.color = color;
      this.tires = tires;
      this.seats = seats;
    }
  }


  static public void Main ()
  {

    Console.Write("\n===================   WELCOME TO SUPER VEHICLES @VIP™   ===================\n\nHere you can create three types of vehicles Cars, Trucks and Planes.\nTo start please type what is the vehicle you want to create.\nI want a : ");
    string typeOfVehicle = Console.ReadLine();
    while (typeOfVehicle != "car" && typeOfVehicle != "truck" && typeOfVehicle != "plane"){
      Console.WriteLine("Please enter car, truck or plane:");
      typeOfVehicle = Console.ReadLine();
    }
    
    Console.WriteLine("\nWould you like a regular Vehicle of Full Customized Vehicle? (regular/custom)");
    string vehicleCustomize = Console.ReadLine();
    while (vehicleCustomize != "regular" && vehicleCustomize != "custom"){
      Console.WriteLine("Please enter regular or custom: ");
      vehicleCustomize = Console.ReadLine();
    }



    createVehicle(typeOfVehicle, vehicleCustomize);
    

    Console.WriteLine("\n ==================== THANK YOU FOR USING THIS PROGRAM! ====================");

  }


  static void createVehicle(string typeOfVehicle, string vehicleCostumize){
    if (typeOfVehicle == "car" && vehicleCostumize == "regular"){
      Console.WriteLine("Creating regular car...");
      Car newCar = new Car();
      ShowRegularVehicle(typeOfVehicle);
      showCarSpecifications(typeOfVehicle, newCar);
    }
    else if (typeOfVehicle == "car" && vehicleCostumize == "custom"){
      Console.WriteLine("Creating customized car...");
      Car newCar = new Car();
      newCar = questionsCustomCar(typeOfVehicle, newCar);
      ShowCustomVehicle(typeOfVehicle);
      showCarSpecifications(typeOfVehicle, newCar);
    }
    else if (typeOfVehicle == "truck" && vehicleCostumize == "custom"){
      Console.WriteLine("Creating customized truck...");
      Truck newTruck = new Truck();
      newTruck = questionsCustomTruck(typeOfVehicle, newTruck);
      ShowCustomVehicle(typeOfVehicle);
      showTruckSpecifications(typeOfVehicle, newTruck);
    }
    else if (typeOfVehicle == "plane" && vehicleCostumize == "custom"){
      Console.WriteLine("Creating customized plane...");
      Plane newPlane = new Plane();
      newPlane = questionsCustomPlane(typeOfVehicle, newPlane);
      ShowCustomVehicle(typeOfVehicle);
      showPlaneSpecifications(typeOfVehicle, newPlane);
    }
    else if  (typeOfVehicle == "truck" && vehicleCostumize == "regular"){
      Console.WriteLine("Creating regular truck...");
      Truck newTruck = new Truck();
      ShowRegularVehicle(typeOfVehicle);
      showTruckSpecifications(typeOfVehicle, newTruck);
    }
    else {
      Console.WriteLine("Creating regular plane...");
      Plane newPlane = new Plane();
      ShowRegularVehicle(typeOfVehicle);
      showPlaneSpecifications(typeOfVehicle, newPlane);
    }
  } 


  static void showCarSpecifications(string typeOfVehicle, Car newVehicle){
    Console.WriteLine("\nThis are your {0} specifications:\nColor: {1}\nNumber of tires: {2}\nNumber of seats: {3}\nBrand: {4}", typeOfVehicle, newVehicle.color, newVehicle.tires, newVehicle.seats, newVehicle.brand);    
  }
  
  static void showTruckSpecifications(string typeOfVehicle, Truck newVehicle){
    Console.WriteLine("\nThis are your {0} specifications:\nColor: {1}\nNumber of tires: {2}\nNumber of seats: {3}\nWeight Capacity: {4}", typeOfVehicle, newVehicle.color, newVehicle.tires, newVehicle.seats, newVehicle.weightCapacity);    
  }

  static void showPlaneSpecifications(string typeOfVehicle, Plane newVehicle){
    Console.WriteLine("\nThis are your {0} specifications:\nColor: {1}\nNumber of tires: {2}\nNumber of seats: {3}\nMax Flying Height: {4}", typeOfVehicle, newVehicle.color, newVehicle.tires, newVehicle.seats, newVehicle.maxHight);
  }

  static Car questionsCustomCar(string typeOfVehicle, Car newCar){
    Console.Write("\n========== Custom {0} ==========\nLets start with your full customized {0}\nPlease enter what color do you want your {0}:", typeOfVehicle);    
    string color = Console.ReadLine();
    Console.Write("How many tires: ");
    int tires = int.Parse(Console.ReadLine());
    Console.Write("How many seats: ");
    int seats = int.Parse(Console.ReadLine());
    Console.Write("What brand : ");
    string brand = Console.ReadLine();
    return newCar = new Car(brand, color, tires, seats);
  }

  static Truck questionsCustomTruck(string typeOfVehicle, Truck newTruck){
    Console.Write("\n========== Custom {0} ==========\nLets start with your full customized {0}\nPlease enter what color do you want your {0}: ", typeOfVehicle);    
    string color = Console.ReadLine();
    Console.Write("How many tires: ");
    int tires = int.Parse(Console.ReadLine());
    Console.Write("How many seats: ");
    int seats = int.Parse(Console.ReadLine());
    Console.Write("weight Capacity of truck: ");
    int weightCapacity = int.Parse(Console.ReadLine()); 
    return newTruck = new Truck(weightCapacity, color,tires, seats);
  }

  static Plane questionsCustomPlane(string typeOfVehicle, Plane newPlane){
    Console.Write("\n========== Custom {0} ==========\nLets start with your full customized {0}\nPlease enter what color do you want your {0}: ", typeOfVehicle);    
    string color = Console.ReadLine();
    Console.Write("How many tires: ");
    int tires = int.Parse(Console.ReadLine());
    Console.Write("How many seats: ");
    int seats = int.Parse(Console.ReadLine());
    Console.Write ("Maximum flying Hight: ");
    int maxHight = int.Parse(Console.ReadLine());   
    return newPlane = new Plane(maxHight ,color, tires,seats);
  }


  static void ShowCustomVehicle(string vehicleType){
    switch (vehicleType){
      case "car":
        Console.WriteLine("\nThis is an image of your new " + vehicleType);
        string[] car = {
          @" __---~~~~--__                      __--~~~~---__",
          @"`\---~~~~~~~~\\                    //~~~~~~~~---/'  ",
          @" \/~~~~~~~~~\||                  ||/~~~~~~~~~\/ ",
          @"             `\\                //'",
          @"                `\\            //'",
          @"                  ||          ||      ",
          @"        ______--~~~~~~~~~~~~~~~~~~--______              ",
          @"   ___ // _-~                        ~-_ \\ ___  ",
          @"  `\__)\/~                              ~\/(__/'          ",
          @"   _--`-___                            ___-'--_        ",
          @" /~     `\ ~~~~~~~~------------~~~~~~~~ /'     ~\        ",
          @"/|        `\         ________         /'        |\     ",
          @"| `\   ______`\_      \------/      _/'______   /'|   " ,      
          @"|   `\_~-_____\ ~-________________-~ /_____-~_/'  |  ",
          @"`.     ~-__________________________________-~    .'   ",    
          @"`.      [_______/------|~~|------\_______]      .'",
          @" `\--___((____)(________\/________)(____))___--/'  ",         
          @"  |>>>>>>||                            ||<<<<<<|",
          @"  `\<<<<</'                            `\>>>>>/' "
        };
        for (int i = 0; i < car.Length; i++){
          Console.WriteLine(car[i]);
        }

        break;

      case "truck":
        Console.WriteLine("\nThis is an image of your new " + vehicleType);
        string[] truck = {
          @"                   _______________________________________________________",
          @"                   |                                                      |",
          @"              /    |                                                      |",
          @"             /---, |                                                      |",
          @"        -----# ==| |                                                      |",
          @"        | :) # ==| |                                                      |",
          @"   -----'----#   | |______________________________________________________|",
          @"   |)___()  '#   |______====____   \___________________________________|",
          @"  [_/,-,\'--'------ //,-,  ,-,\\\   |/             //,-,  ,-,  ,-,\\ __#",
          @"    ( 0 )|===******||( 0 )( 0 )||-  o              '( 0 )( 0 )( 0 )||",
          @" ----'-'--------------'-'--'-'-----------------------'-'--'-'--'-'------------"
        };
        for (int i = 0; i < truck.Length; i++){
          Console.WriteLine(truck[i]);
        }
        break;

      case "plane":
        Console.WriteLine("\nThis is an image of your new " + vehicleType);
        string[] plane = {
          @"             ______",
          @"             _\ _~-\___",
          @"     =  = ==(___VIP____D",
          @"                 \_____\___________________,-~~~~~~~`-.._",
          @"                 /     o O o o o o O O o o o o o o O o  |\_",
          @"                 `~-.__        ___..----..                  )",
          @"                       `---~~\___________/------------`````",
          @"                       =  ===(_________D"
        };
        for (int i = 0; i < plane.Length; i++){
          Console.WriteLine(plane[i]);
        }
        break;
    }
  }

  static void ShowRegularVehicle(string vehicleType){
    switch (vehicleType){
      case "car":
        Console.WriteLine("\nThis is an image of your new " + vehicleType);
        string[] car = {
        @"                             _.--~~~~~~~---------------._                      ",
        @"                           ,=-,.--#####----..--------.   `.                    ",
        @"                         ,'  ,/ _/_ ####   :!         `   ``.                  ",
        @"                        ,   ,/ [.[.]-=##   :!     /    `   `.`.                ",
        @"                       ,   ,/   /_    )#   :!   // //   `    `.`.              ",
        @"                      ,   /7    |_/   #    :!    // /    `     `.`.  ___,-     ",
        @"                     .   ; |     \___/     :!             ;      `~`=    /     ",
        @"               ___,--`--(  ;_____/__  \____:!__________,-'           `. /      ",
        @"         __,--'         '~~         \  \ __`               ______      `.      ",
        @"     _,-'                      _ ____\  \-o .             /ZZZZZ/        `.    ",
        @"   ,'         Regular Car`    {_|_______)                                  `.  ",
        @"  .------ ------ ---- ---, --  --- - --- -- .--  - - ---  -- -   -- --- - --!  ",
        @"  !__'     ,-~~~-.                                     ,-~~~-.             /|  ",
        @"  | ,     ' ,mMm. `      .                  .         ' ,mMm. `           /-!  ",
        @"  ;-_____'.d-' `-b.`_____ __________________ ________'.d-' `-b.`_________/FS;_ ",
        @" :      ;.d'\ _ /`b.\    .                  '       ;.d'\ _ /`b.\             :",
        @" !====== d;-.' `.-:b ==== ================= ======== d;-.' `.-:b =============;",
        @" `-.   : H  |   |  D :   `                 '       : H  |   |  D :     _ __,-' ",
        @"    `-.! C:-`._,'-;P ;_____________________________! C:-`._,'-;P ;__________7  ",
        @"         'G./   \,S'                                 'G./   \,S'               ",
        @"          'S-. ,-D'                                   'Q-. ,-S'                ",
        @"           &WSW8'                                      '&WSW8'                 ",
        @" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  "
        };
        for (int i = 0; i < car.Length; i++){
          Console.WriteLine(car[i]);
        }

        break;

      case "truck":
        Console.WriteLine("\nThis is an image of your new " + vehicleType);
        string[] truck = {
          @"        ____________________",
          @"       |\                   \  l____",
          @"       | \___________________\ |\   \",
          @"       | |                    ||\l___\___",
          @"       [ |  Regular  Truck    || |__|_\__\",
          @"      /\ |                    |]\|. | |===\",
          @"      \ \[____________________]_]|__|..___]",
          @"       \/.-.\______________\/.-.\____\/.-.\",
          @"        ( @ )                      =  ( @ )"
        };
        for (int i = 0; i < truck.Length; i++){
          Console.WriteLine(truck[i]);
        }
        break;

      case "plane":
        Console.WriteLine("\nThis is an image of your new " + vehicleType);
        string[] plane = {
          @"                               |",
          @" ______________________________|_______________________________",
          @"                     ----\--||___||--/----",
          @"                          \ :==^==: /",
          @"                           \|  o  |/",
          @"                            \_____/",
          @"                            /  |  \",
          @"                          ^/   ^   \^",
          @"                          U    U    U  -RW/AS"
        };

        for (int i = 0; i < plane.Length; i++){
          Console.WriteLine(plane[i]);
        }
        break;
    }
  }
}









