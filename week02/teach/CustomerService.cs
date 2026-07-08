/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService
{
    public static void Run()
    {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Testing maximun size when de queue is created
        // Expected Result: 10, 2 and 12
        Console.WriteLine("Test 1");
        CustomerService cs1 = new CustomerService(-2);
        CustomerService cs2 = new CustomerService(2);
        CustomerService cs3 = new CustomerService(12);
        // Defect(s) Found: 
        Console.WriteLine($"cs1(should be 10): {cs1._maxSize}, cs2(should be 2):  {cs2._maxSize},  cs3(should be 12):  {cs3._maxSize}");
        Console.WriteLine("=================");


        // Test 2
        // Scenario: We will try to add 3 customer.
        // Expected Result:  If the queue is full when trying to add the third customer (full size is 3), then an error message should be displayed.
        Console.WriteLine("Test 2");
        //Customer c1 = new Customer("Customer1", "1000", "problemCustomer1");
        //Customer c2 = new Customer("Customer2", "2000", "problemCustomer2");
        //Customer c3 = new Customer("Customer3", "3000", "problemCustomer3");
        cs2.AddNewCustomer();
        cs2.AddNewCustomer();
        cs2.AddNewCustomer();


        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
        // Test 2
        // Scenario: We will try to remove all the customers.
        // Expected Result:   The system will show us all the customers' information and when the _queue gets empty, an error message will be displayed
        Console.WriteLine("Test 3");
        cs2.ServeCustomer();
        cs2.ServeCustomer();
        cs2.ServeCustomer();
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize)
    {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer
    {
        public Customer(string name, string accountId, string problem)
        {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString()
        {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer()
    {
        // Verify there is room in the service queue
        // I fixed this adding >=
        if (_queue.Count >= _maxSize)
        {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer()
    {
        //We added the message:There are no customers 
        if (_queue.Count != 0)
        {
            //We changed this two lines:
            //_queue.RemoveAt(0);
            //var customer = _queue[0];
            var customer = _queue[0];
            _queue.RemoveAt(0);
            Console.WriteLine(customer);
        }
        else
        {
            Console.WriteLine("There are no customers");
        }

    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString()
    {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}