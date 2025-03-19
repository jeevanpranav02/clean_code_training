# Variable Review
## Review One - CC 10
```csharp
    public bool IsShopOpen(string day)
    {
        if (!string.IsNullOrEmpty(day)) // 1
        {
            day = day.ToLower();
            if (day == "friday") // 2
            {
                return true;
            }
            else if (day == "saturday") // 2
            {
                return true;
            }
            else if (day == "sunday") // 2
            {
                return true;
            }
            else // 2
            {
                return false;
            }
        }
        else // 1
        {
            return false;
        }

    }

    // Solution
    public bool IsShopOpen(string day)
    {
        if (string.IsNullOrEmpty(day))
        {
            return false;
        }

        var openDays = new HashSet<string> { "friday", "saturday", "sunday" };
        return openDays.Contains(day.ToLower());
    }
```

## Review 3 - CC  21
```csharp
public long Fibonacci(int n)
{
    if (n < 50) // 1
    {
        if (n != 0) // 2
        {
            if (n != 1) // 3
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2); // 3
            }
            else // 3
            {
                return 1; // 3
            }
        }
        else // 2
        {
            return 0; // 2
        }
    }
    else // 1
    {
        throw new System.Exception("Not supported"); // 1
    }
}

// Solution
public long Fibonacci(int n)
{
    if (n >= 50)
    {
        throw new System.Exception("Not supported");
    }

    if (n == 0)
    {
        return 0;
    }

    if (n == 1)
    {
        return 1;
    }

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

```

## Review 4 - CC  1
```csharp
var l = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < l.Count(); i++) // 1
{
    var li = l[i];
    DoStuff(); 
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(li);
}

// Solution
var locations = new[] { "Austin", "New York", "San Francisco" };

foreach (var location in locations)
{
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // It's clear that `location` is being dispatched here.
    Dispatch(location);
}

```

## Review 5 - CC  1
```csharp
if (userRole == 8) // Check if Admin - cc 1
{
    
}

// Solution
const int AdminRole = 8; // Define a constant for the admin role

if (userRole == AdminRole) // Check if Admin
{
    // Admin-specific logic here
}

```

## Review 6 - CC 0
```csharp
public class Car
{
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public string CarColor { get; set; }

    //...
}

// Solution
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    // Additional functionality or methods can go here
}

```

## Review 9 - CC  2
```csharp
public void CreateMicrobrewery(string name = null)
{
    var breweryName = !string.IsNullOrEmpty(name) ? name : "Hipster Brew Co.";
    // ...
}

// Solution
public void CreateMicrobrewery(string name = null)
{
    const string DefaultBreweryName = "Hipster Brew Co."; // Define a constant for the default name
    var breweryName = !string.IsNullOrEmpty(name) ? name : DefaultBreweryName;
    // ...
}
```
