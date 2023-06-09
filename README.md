# dotnetPuppies

This is a project to build a RESTful API using C# and the .NET framwork, as well as Entity Framework. Both the database and API are hosted on Azure and the final project is deployed.

The frontend UI can be found [here](https://github.com/SMooreSwe/puppies-frontend), which contains a link to the project deployed on Vercel.

### The Endpoints

- GET: `api/puppies`. Returns an array of all puppies.
- GET: `api/puppies/:id`. Returns the identified puppy.
- POST: `api/puppies`. Creates and returns a newly added puppy.
- PUT: `api/puppies/:id`. Updates the specific puppy.
- DELETE: `api/puppies/:id`. Deletes the puppy from the database.

### The Puppies

Each `puppy` is a document in the database that has the following attributes: 
    - id
    - breed
    - name
    - birth date
    
### The Tools

As outlined above, I used .NET with Entity Framework to create the API, which was tested with a docker database. The deployed project uses an Azure SQL database, which is hosted on Azure. The project is coded in C#.
