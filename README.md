"# MagicVilla_API" 
![image](https://github.com/Shag0r/MagicVilla_API/assets/101504353/c782d2ba-a8fd-44f8-b997-88226b9314d5)


![image](https://github.com/Shag0r/MagicVilla_API/assets/101504353/12455dec-6e49-4cf7-b539-e1dba9dbecba)

Controllers: Contains ASP.NET Web API controllers responsible for handling HTTP requests and producing HTTP responses.

VillaAPIController: Manages endpoints related to villas, such as retrieving all villas, retrieving a specific villa by ID, and creating a new villa resource.
Models: Contains classes representing domain entities and data transfer objects (DTOs).

Villa: Represents a villa entity with properties like ID, Name, and CreatedDate.
VillaDto: Represents a data transfer object for villas, used for input and output during API operations.
Data: Contains a static class VillaStore responsible for storing villa data during runtime.

VillaStore: Holds a list of VillaDto objects representing pre-defined villa data.
Functionality
Get Villas: Retrieve a list of all villas available.
Get Villa by ID: Retrieve a specific villa by its unique ID.
Create Villa: Add a new villa to the list of available villas.
Project Dependencies
Microsoft.AspNetCore.Authentication.OAuth: Dependency for handling OAuth authentication in the ASP.NET Core application.
