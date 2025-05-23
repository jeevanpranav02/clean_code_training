## Day One
- SOLID Principles
   - Single Responsibility Principle -> Single Reason to Change -> Subjective to the requirement change
   - Dependency Inversion Principle -> High Level Module should not depend on Low Level Module -> Both should depend on Abstraction
            Example: 
     ```
          (PrinterDevice)                            (PrinterDevice)
          |   |      |                  ->                   |
          v   v      v                                       v
          Fax  Scan  Print                       (InputDeviceInterface)
                                                       ^    ^    ^
                                                       |    |    |
                                                       Fax  Scan  Print
     ```

## Day Two
- Liskov Substitution Principle -> Derived class should be able to replace the base class without affecting the functionality 
    - Use Composition over Inheritance 
    - Powermock for Static methods is not a good practice
        - Use a wrapper class for static methods to make it testable make it abstract first
- Interface Segregation Principle -> Many Specific Interfaces are better than one General Interfaces
- Open Closed Principle -> Open for Extension, Closed for Modification
    - Use Strategy Pattern
    - Use Factory Pattern
    - Use Decorator Pattern
    - Use Template Pattern
- TDD -> Test Driven Development

## Day Three
- Refactoring 
    - Steps to Refactor
        - Start some tests                   ---------
        - Build ACL (Anti Corruption Layer)  ---------|---> Production Code should not be touched
        - Build all the tests                ---------|
        - Existing system might have defects ---------
- Mutation Testing
    - Mutation Testing is a type of software testing where we mutate (change) certain statements in the source code and check if the test cases are able to find the errors. 
    - If the test cases fail to find the errors, it indicates a gap in the test cases.
    - Java -> PIT Mutation testing
    - Python -> MutPy
    - C# -> Stryker.NET
    - Rust -> Mutagen
