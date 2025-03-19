# Meaningful Names
## Review 1
int d; // elapsed time in days                                          

//Make sure that the variable name is descriptive

int elapsedTimeInDays; // elapsed time in days                           

--

## Review 2
var dataFromDb = db.GetFromService().ToList(); // Get List of employees  

//The variable name should not be vague and misleading

var employees = db.GetFromService().ToList(); // Get List of employees

--

## Review 3
int iCounter; 
string strFullName;
DateTime dModifiedDate;

// Data type should not be included in the variable name

int counter;
string fullName;
DateTime modifiedDate;

--

## Review 4
public bool IsShopOpen(string pDay, int pAmount)
{
    // some logic
}

// Don't complicate the parameter names, make them simple

public bool IsShopOpen(string day, int amount)
{
    // some logic
}

--

## Review 5
const int DAYS_IN_WEEK = 7;
const int daysInMonth = 30;
var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };
bool EraseDatabase() {}
bool Restore_database() {}
class animal {}
class Alpaca {}

// Use consistent naming conventions, and follow the naming conventions of the language/project guidelines

const int DAYS_IN_WEEK = 7;
const int DAYS_IN_MONTH = 30;
var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };
bool EraseDatabase() {}
bool RestoreDatabase() {}
class Animal {}
class Alpaca {}

--

## Review 6
public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date
    public Datetime modTime { get; set; } // get set Modification Time
}

// Use complete words instead of abbreviations

public class Employee
{
    public Datetime startWorkDate { get; set; } 
    public Datetime modificationTime { get; set; }
}

--

## Review 7
var employeephone;
public double CalculateSalary(int workingdays, int workinghours)
{
    // some logic
}

// Use camelCase for local variables

var employeePhone;
public double CalculateSalary(int workingDays, int workingHours)
{
    // some logic
}

--
