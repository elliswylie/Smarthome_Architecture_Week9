using SmartHomeController;

try
{
    SmartDevice badDevice = new SmartLight(0, "Red", 0, "Test Light", false);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error creating device: {ex.Message}");

}