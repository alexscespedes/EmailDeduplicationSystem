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
            string input = Console.ReadLine()?.Trim()!;

            if (string.Equals(input, "done", StringComparison.OrdinalIgnoreCase))
                break;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Empty input is not allowed. \n");
                continue;
            }

            string normalizedEmail = input.ToLower();

            // Prevents duplicates naturally - no need to manually check .Contains()
            if (uniqueEmails.Add(normalizedEmail))
            {
                Console.WriteLine($"Added: {normalizedEmail}\n");
            }

            else
            {
                Console.WriteLine($"Duplicate ignored: {normalizedEmail}\n");
            }
        }

        Console.WriteLine("\nUnique email addresses (sorted):");

        List<string> sortedEmails = [.. uniqueEmails];
        sortedEmails.Sort();

        foreach (var email in sortedEmails)
        {
            Console.WriteLine(email);
        }
    }
}
