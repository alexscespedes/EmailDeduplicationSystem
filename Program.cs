namespace EmailDeduplicationSystem;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> uniqueEmails = new HashSet<string>();

        Console.WriteLine("Enter email addresses (type 'done' to finish):");

        while (true)
        {
            Console.Write("Email: ");
            string input = Console.ReadLine()?.Trim();

            if (string.Equals(input, "done", StringComparison.OrdinalIgnoreCase))
                break;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Empty input is not allowed. \n");
                continue;
            }

            string normalizedEmail = input.ToLower();

            Console.WriteLine($"Normalized: {normalizedEmail}");
        }
    }
}
