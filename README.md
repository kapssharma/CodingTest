1. Add CRUD functions into this controller: Get/GetById/Post/Delete
   a) The delete function should do a "soft delete"
3. Add a service to conduct the business logic, and use dependancy injection to inject this service into the controller
  a) You will need to pull out whatever logic you need from the controller.
  b) Keep error handling and error messaging in mind 
5. Create an endpoint that will return the top x results, where x is a parameter that can be passed into the function
   a) This endpoint will call this public url: "https://www.anapioficeandfire.com/api/characters"
   b) users should be able to pass in a parameter called "take".
