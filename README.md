# Day One
- SOLID Principles
   - Single Responsibility Principle -> Single Reason to Change -> Subjective to the requirement change
   - Dependency Inversion Principle -> High Level Module should not depend on Low Level Module -> Both should depend on Abstraction
            Example: 
            (PrinterDevice)                            (PrinterDevice)
             |   |    |                  ->                   |
             v   v    v                                       v
           Fax  Scan  Print                         (InputDeviceInterface)
                                                       ^    ^    ^
                                                       |    |    |
                                                      Fax  Scan  Print
