using ParkingChallenge.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialFare = 0;
decimal pricePerHour = 0;

Console.WriteLine($"Welcome to our parking lot!\n " );


// Instancia a classe Parking, já com os valores obtidos anteriormente
Parking park = new Parking(initialFare, pricePerHour);

string opcao = string.Empty;
bool showMenu = true;

// Realiza o loop do menu
while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1 - Register your vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Exit");

    switch (Console.ReadLine())
    {
        case "1":
            park.AddVehicle();
            break;

        case "2":
            park.RemoveVehicle();
            break;

        case "3":
            park.ListVehicles();
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    Console.WriteLine("Press any key to continue");
    Console.ReadLine();
}

Console.WriteLine("The app has been terminated");
