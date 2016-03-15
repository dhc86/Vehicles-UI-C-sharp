using System;
using System.Collections.Generic;
 
public class HelloWorld
{
  class Person {
    public string name { get; set; }

    public Person(){
      this.name = "<NOT NAMED YET>";   
    }

    public Person(string name){
      this.name = name;
    }

  }

  class Customer:Person {

    public int money { get; set; }

    public Customer():base(){
      this.name = "Diego";
      this.money = 0;
    }

    public Customer(string name, int money):base(name){
      this.name = name;
      this.money = money;
    }

  }

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

  class RegularCar:Car{

    public int price { get; set; }

    public RegularCar():base(){
      this.price = 5000;
    }

    public RegularCar(string brand, string color, int tires, int seats, int price = 5000):base(brand, color, tires, seats){
      this.brand = brand;
      this.color = color;
      this.tires = tires;
      this.seats = seats;
      this.price = 5000;
    }
  }

  class CustomCar:Car{

    public int price { get; set; }

    public CustomCar():base(){
      this.price = 70000;
    }

    public CustomCar(string brand, string color, int tires, int seats, int price = 5000):base(brand, color, tires, seats){
      this.brand = brand;
      this.color = color;
      this.tires = tires;
      this.seats = seats;
      this.price = 70000;
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

  class RegularPlane: Plane{
    public int price { get; set; }

    public RegularPlane():base(){
      this.price = 50000;
    }

    public RegularPlane(double maxHight, string color, int tires, int seats, int price):base(maxHight, color, tires, seats){
      this.maxHight = maxHight;
      this.color = color;
      this.tires = tires;
      this.seats = seats;
      this.price = 50000;
    }
  }

  class CustomPlane:Plane{
    public int price { get; set; }

    public CustomPlane():base(){
      this.price = 550000;
    }

    public CustomPlane(double maxHight, string color, int tires, int seats, int price = 550000):base(maxHight, color, tires, seats){
      this.maxHight = maxHight;
      this.color = color;
      this.tires = tires;
      this.seats = seats;
      this.price = 550000;
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

  class RegularTruck:Truck{
    public int price { get; set; }

    public RegularTruck():base(){
      this.price = 20000;
      this.weightCapacity = 100;
    }

    public RegularTruck(int weightCapacity, string color, int tires, int seats, int price):base(weightCapacity, color, tires, seats){
      this.weightCapacity = weightCapacity;
      this.color = color;
      this.tires = tires;
      this.seats = seats;
      this.price = 20000;
    }
  }

  class CustomTruck:Truck{
    public int price { get; set; }

    public CustomTruck():base(){
      this.price = 60000;
    }

    public CustomTruck(int weightCapacity, string color, int tires, int seats, int price = 60000):base(weightCapacity, color, tires, seats){
      this.weightCapacity = weightCapacity;
      this.color = color;
      this.tires = tires;
      this.seats = seats;
      this.price = 60000;
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

    Customer newCustomer = new Customer();
    Console.Write("\nBefore we start creating your Vehicle please give us a bit of your information by answering the following questions:\nPlease enter your name: ");
    string name = Console.ReadLine();

    Console.Write("\nHow much money are looking to invest in your new vehicle: ");
    int money = int.Parse(Console.ReadLine());

    newCustomer = new Customer(name, money);
    Console.WriteLine("Thank you very much {0}, let's proceed with your vehicle order!", newCustomer.name);
    createVehicle(typeOfVehicle, vehicleCustomize);
    
    Console.WriteLine("\n ==================== THANK YOU FOR USING THIS PROGRAM! ====================");
  }


  static void createVehicle(string typeOfVehicle, string vehicleCostumize){
    if (typeOfVehicle == "car" && vehicleCostumize == "regular"){
      Console.WriteLine("Creating regular car...");
      RegularCar newCar = new RegularCar();
      ShowRegularVehicle(typeOfVehicle);
      showRegularCarSpecifications(typeOfVehicle, newCar);
    }
    else if (typeOfVehicle == "car" && vehicleCostumize == "custom"){
      Console.WriteLine("Creating customized car...");
      CustomCar newCar = new CustomCar();
      newCar = createsCustomCar(typeOfVehicle, newCar);
      ShowCustomVehicle(typeOfVehicle);
      showCustomCarSpecifications(typeOfVehicle, newCar);
    }
    else if (typeOfVehicle == "truck" && vehicleCostumize == "custom"){
      Console.WriteLine("Creating customized truck...");
      CustomTruck newTruck = new CustomTruck();
      newTruck = createsCustomTruck(typeOfVehicle, newTruck);
      ShowCustomVehicle(typeOfVehicle);
      showCustomTruckSpecifications(typeOfVehicle, newTruck);
    }
    else if (typeOfVehicle == "plane" && vehicleCostumize == "custom"){
      Console.WriteLine("Creating customized plane...");
      CustomPlane newPlane = new CustomPlane();
      newPlane = createsCustomPlane(typeOfVehicle, newPlane);
      ShowCustomVehicle(typeOfVehicle);
      showCustomPlaneSpecifications(typeOfVehicle, newPlane);
    }
    else if  (typeOfVehicle == "truck" && vehicleCostumize == "regular"){
      Console.WriteLine("Creating regular truck...");
      RegularTruck newTruck = new RegularTruck();
      ShowRegularVehicle(typeOfVehicle);
      showRegularTruckSpecifications(typeOfVehicle, newTruck);
    }
    else {
      Console.WriteLine("Creating regular plane...");
      RegularPlane newPlane = new RegularPlane();
      ShowRegularVehicle(typeOfVehicle);
      showRegularPlaneSpecifications(typeOfVehicle, newPlane);
    }
  } 


  static void showRegularCarSpecifications(string typeOfVehicle, RegularCar newVehicle){
    Console.WriteLine("\nThis are your {0} specifications:\nColor: {1}\nNumber of tires: {2}\nNumber of seats: {3}\nBrand: {4}\nPrice: {5}", typeOfVehicle, newVehicle.color, newVehicle.tires, newVehicle.seats, newVehicle.brand, newVehicle.price);    
  }
  
  static void showCustomCarSpecifications(string typeOfVehicle, CustomCar newVehicle){
    Console.WriteLine("\nThis are your {0} specifications:\nColor: {1}\nNumber of tires: {2}\nNumber of seats: {3}\nBrand: {4}\nPrice: {5}", typeOfVehicle, newVehicle.color, newVehicle.tires, newVehicle.seats, newVehicle.brand, newVehicle.price);    
  }

  static void showCustomTruckSpecifications(string typeOfVehicle, CustomTruck newVehicle){
    Console.WriteLine("\nThis are your {0} specifications:\nColor: {1}\nNumber of tires: {2}\nNumber of seats: {3}\nWeight Capacity: {4}\nPrice: {5}", typeOfVehicle, newVehicle.color, newVehicle.tires, newVehicle.seats, newVehicle.weightCapacity, newVehicle.price);    
  }

  static void showRegularTruckSpecifications(string typeOfVehicle, RegularTruck newVehicle){
    Console.WriteLine("\nThis are your {0} specifications:\nColor: {1}\nNumber of tires: {2}\nNumber of seats: {3}\nWeight Capacity: {4}\nPrice: {5}", typeOfVehicle, newVehicle.color, newVehicle.tires, newVehicle.seats, newVehicle.weightCapacity, newVehicle.price);    
  }

  static void showCustomPlaneSpecifications(string typeOfVehicle, CustomPlane newVehicle){
    Console.WriteLine("\nThis are your {0} specifications:\nColor: {1}\nNumber of tires: {2}\nNumber of seats: {3}\nMax Flying Height: {4}\nPrice: {5}", typeOfVehicle, newVehicle.color, newVehicle.tires, newVehicle.seats, newVehicle.maxHight, newVehicle.price);
  }

  static void showRegularPlaneSpecifications(string typeOfVehicle, RegularPlane newVehicle){
    Console.WriteLine("\nThis are your {0} specifications:\nColor: {1}\nNumber of tires: {2}\nNumber of seats: {3}\nMax Flying Height: {4}\nPrice: {5}", typeOfVehicle, newVehicle.color, newVehicle.tires, newVehicle.seats, newVehicle.maxHight, newVehicle.price);
  }


  static int tiresValidation(int tires){
    while (tires < 2 || tires > 6){
      Console.WriteLine("Can only have Vehicles from 2 to 6 tires. Please enter a valid number");
      tires = int.Parse(Console.ReadLine());
    }
    return tires;
  }

  static int seatsValidation(int seats){
    while (seats < 2 || seats > 6){
      Console.WriteLine("Can only have Vehicles from 2 to 8 seats. Please enter a valid number");
      seats = int.Parse(Console.ReadLine());
    }
    return seats;
  }

  static string colorValidation(string color){
    while (color  == "red" && color == "blue" && color == "black" && color == "green"){
      Console.WriteLine("Can only have red, blue, black and green colors. Please enter available color: ");
      color = (Console.ReadLine());
    }
    return color;
  }

  static CustomCar createsCustomCar(string typeOfVehicle, CustomCar newCar){
    Console.Write("\n========== Custom {0} ==========\nLets start with your full customized {0}\nPlease enter what color do you want your {0}:", typeOfVehicle);    
    string color = Console.ReadLine();
    color = colorValidation(color);
    Console.Write("How many tires: ");
    int tires = int.Parse(Console.ReadLine());
    tiresValidation(tires);
    Console.Write("How many seats: ");
    int seats = int.Parse(Console.ReadLine());
    seats =  seatsValidation(seats);
    Console.Write("What brand : ");
    string brand = Console.ReadLine();
    return newCar = new CustomCar(brand, color, tires, seats);
  }

  static CustomTruck createsCustomTruck(string typeOfVehicle, CustomTruck newTruck){
    Console.Write("\n========== Custom {0} ==========\nLets start with your full customized {0}\nPlease enter what color do you want your {0}: ", typeOfVehicle);    
    string color = Console.ReadLine();
    color = colorValidation(color);
    Console.Write("How many tires: ");
    int tires = int.Parse(Console.ReadLine());
    tires = tiresValidation(tires);
    Console.Write("How many seats: ");
    int seats = int.Parse(Console.ReadLine());
    seats = seatsValidation(seats);
    Console.Write("weight Capacity of truck: ");
    int weightCapacity = int.Parse(Console.ReadLine()); 
    return newTruck = new CustomTruck(weightCapacity, color,tires, seats);
  }

  static CustomPlane createsCustomPlane(string typeOfVehicle, CustomPlane newPlane){
    Console.Write("\n========== Custom {0} ==========\nLets start with your full customized {0}\nPlease enter what color do you want your {0}: ", typeOfVehicle);    
    string color = Console.ReadLine();
    color = colorValidation(color);
    Console.Write("How many tires: ");
    int tires = int.Parse(Console.ReadLine());
    tires = tiresValidation(tires);
    Console.Write("How many seats: ");
    int seats = int.Parse(Console.ReadLine());
    seats = seatsValidation(seats);
    Console.Write ("Maximum flying Hight: ");
    double maxHight = double.Parse(Console.ReadLine());   
    return newPlane = new CustomPlane(maxHight ,color, tires,seats);
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
          @" =   =  = ==(___VIP____D",
          @"                 \_____\___________________,-~~~~~~~`-.._",
          @"                 /     o O o o o o O O o o o o o o O o  |\_",
          @"                 `~-.__        ___..----..                  )",
          @"                       `---~~\___________/------------`````",
          @"=         =       =    =  ===(_________D"
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









