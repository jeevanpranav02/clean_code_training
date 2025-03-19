# Functions - No 4 and 7
## Review 1
```csharp
package CS1;

public class UserValidator {

    private Cryptographer cryptographer;

    public boolean checkPassword(String userName, String password) {
        User user = UserGateway.findByName(userName);

        if (user != null) {

            String codedPhrase = user.getPhraseEncodedByPassword();

            String phrase = cryptographer.decrypt(codedPhrase, password);

            if ("Valid Password".equals(phrase)) {

                session.initialize();

                return true;
            }


        }
        
    
        return false;
    }

    // Cognitive complexity can be reduced by checking whether the user is null first
}

```

## Review 2
```csharp
var name = "Ryan McDermott";

public void PrintAsFirstNameAndLastName()
{
    var temp = name.Split(" ");
    name = $"His first name is {temp[0]}, and his last name is {temp[1]}"; 
    Console.WriteLine(name);
}

// Avoid repeated assignment of the name variable and print the first and last name directly

```

## Review 3
```csharp 
public bool IsDOMNodeNotPresent(string node)
{
    // ...
}

if (!IsDOMNodeNotPresent(node))
{
    // ...
}

// The method name is confusing. It should be named IsDOMNodePresent
```

## Review 4
```csharp
// TODO:
```

## Review 5
```csharp
public Path TravelToTexas(object vehicle)
{
    if (vehicle.GetType() == typeof(Bicycle))
    {
        (vehicle as Bicycle).PeddleTo(new Location("texas"));
    }
    else if (vehicle.GetType() == typeof(Car))
    {
        (vehicle as Car).DriveTo(new Location("texas"));
    }
}

// The method should return a Path object
// Instead of hardcoding the location, the method should accept a location as a parameterA
// Instead of complex if-else statements, use polymorphism by creating a base class Vehicle
```

## Review 6
```csharp
public void CreateFile(string name, bool temp = false)
{
    if (temp)
    {
        Touch("./temp/" + name);
    }
    else
    {
        Touch(name);
    }
}
 // Instead of using multiple parameters, use a single parameter to specify the path
```

## Review 7
```csharp
public void CreateMenu(string title, string body, string buttonText, bool cancellable)
{
    // ...
}

// The number of parameters can be reduced by creating a class Menu
```

## Review 8
```csharp
// TODO: 
```
