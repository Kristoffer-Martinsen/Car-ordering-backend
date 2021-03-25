# Car-ordering-backend
Backend repo for car ordering web app

<h1>Setup</h1>
<ul>
<li>Download PostgreSQL from <a href="https://www.postgresql.org/download/">Postgres</a></li>
<li>Download fronent repo for thos project here: <a href="https://github.com/Kristoffer-Martinsen/CarOrdering">CarOrdering</a></li>
<li>Create a user for your postgreSQL server </li>
<li>In appsettings.json, change the connectionstring. "User ID" will be the name of the user you created and "Password" will be the password you chose</li>
<li>In the folder of the project run "dotnet ef migrations add [nameOfMigration]" in the terminal</li>
<li>Then run "dotnet ef database update" this will create the database and the tables</li>
<li>The database will be empty so you will have to add the necessary data yourself (the imagePath can be '/Assets/Images/RedCarPublicDomain.png' for an example image</li>
<li>To run the api run "dotnet run" in the terminal</li>
</ul>
