using DZ_Visitor_Pattern_5;
Random rnd = new Random();

House house = new House() { NumberOfHouse = 1};

Floor groundFloor = new (rnd) { FloorNumber = 1 };
Floor firstFloor = new (rnd) { FloorNumber = 2 };

house.AddFloor(groundFloor);
house.AddFloor(firstFloor);

groundFloor.AddApartment(new Apartment() { RoomNumber = 1, Voltage = 221});
groundFloor.AddApartment(new Apartment() { RoomNumber = 2, Voltage = 225});
groundFloor.AddApartment(new Apartment() { RoomNumber = 3, Voltage = 231});
groundFloor.AddApartment(new Apartment() { RoomNumber = 4, Voltage = 220});

firstFloor.AddApartment(new Apartment() { RoomNumber = 5, Voltage = 218 });
firstFloor.AddApartment(new Apartment() { RoomNumber = 6, Voltage = 225 });
firstFloor.AddApartment(new Apartment() { RoomNumber = 7, Voltage = 229 });
firstFloor.AddApartment(new Apartment() { RoomNumber = 8, Voltage = 225 });

IVisitor visitor = new ElectricVisitor();
house.Accept(visitor);
//groundFloor.Accept(visitor);
//firstFloor.Accept(visitor);