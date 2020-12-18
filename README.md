# Pierre's Vendor & Order Tracker

#### Be able to track all of your vendors and orders from Pierre's Bakery!, 12.18.2020

#### By Ben McFarland

## Description

This application will allow Pierre to track all of his vendors and all of their orders from his bakery
## Technologies used

* Microsoft Visual Studio Code
* Git/GitHub
* C# v 7.3
* .NET Core v 2.2
* REPL
* MSTest
* ASP.NET MVC

## Installation Requirements

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/harzulu/VendorOrderTracker], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/harzulu/VendorOrderTracker`.


#### Installing C#, .NET, dotnet script, & MySQL

###### This program requires C# and the .NET Framework to be installed on your machine:

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command `$ dotnet --version`, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download this 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command `dotnet --version`. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
* Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :---------------------------- |
| **Can make an instance of Order object** | `new Order()` | typeof(Order) = Order |
| **Return given title** | "orderOne" | "orderOne" |
| **Return given description** | "order description" | "order description" |
| **Return given price** | `12` | `12` |
| **Return given date** | "December 18 2020" | "December 18 2020" |
| **Get all instances of Order** | `Order.GetAll()` | {Order, Order} |
| **Get Id of Order** | orderInstance.Id | `2` |
| **Find Order by Id** | `Order.Find(2)` | `Order` |
| **Can make an instance of Vendor object** | `new Vendor()` | typeof(Vendor) = Vendor |
| **Return given name** | "vendorOne" | "vendorOne" |
| **Return given description** | "vendor description" | "vendor description" |
| **Add Order to order list** | `newVendor.AddOrder(Order)` | newVendor.Orders[0] = Order |
| **Get Order list** | `Vendor.Orders` | {Order, Order} |
| **Get all instances of Vendor** | `Vendor.GetAll()` | {Vendor, Vendor} |
| **Get Id of Vendor** | vendorInstance.Id | `2` |
| **Find Vendor by Id** | `Vendor.Find(2)` | `Vendor` |


### Tests

Describe: MakeOrder()
Test: Can make an instance of Order object
Expect: Assert.AreEqual(typeof(Order), newOrder.GetType())

Describe: ReturnTitle()
Test: Return given title
Expect: Assert.AreEqual("orderOne", newOrder.Title)

Describe: ReturnOrderDescription()
Test: Return given description
Expect: Assert.AreEqual("description", newOrder.Description)

Describe: ReturnPrice()
Test: Return given price
Expect: Assert.AreEqual(`12`, newOrder.Price)

Describe: ReturnDate()
Test: Return given date
Expect: Assert.AreEqual("December 18 2020", newOrder.Date)

Describe: OrderGetAll()
Test: Get all instances of Order
Expect: Assert.AreEqual({Order, Order, Order}, Order.GetAll())

Describe: OrderGetId()
Test: Get Id of Order
Expect: Assert.AreEqual(1, newOrder.Id)

Describe: FindOrder()
Test: Find Order by Id
Expect: Assert.AreEqual(Order, Order.Find(2))

Describe: MakeVendor()
Test: Can make an instance of Vendor object
Expect: Assert.AreEqual(typeof(Vendor, newVendor.GetType()))

Describe: ReturnName()
Test: Return given name
Expect: Assert.AreEqual("vendor", newVendor.Name)

Describe: ReturnVendorDescription()
Test: Return given description
Expect: Assert.AreEqual("description", newVendor.Description)

Describe: VendorAddOrder()
Test: Add Order to order list
Expect: Assert.AreEqual(Order, newVendor.Orders[0])

Describe: GetOrders()
Test: Get Order list
Expect: Assert.AreEqual({Order, Order}, newVendor.GetOrders())

Describe: GetAll()
Test: Get all instances of Vendor
Expect: Assert.AreEqual({Vednor, Vendor}, newVendor.GetAll())

Describe: VendorGetId()
Test: Get Id of Vendor
Expect: Assert.AreEqual(2, newVendor.Id)

Describe: FindVendor()
Test: Find Vendor by Id
Expect: Assert.AreEqual(Vendor, Vendor.Find(2))

## Bugs / Issues

No known bugs or issues

### License & Copyright

_MIT_ Copyright (c) 2020 *_Ben McFarland_*