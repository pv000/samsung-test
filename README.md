# samsung-test

Samsung address book interview exercice
Tehcnologies used: - Angular 18.2.7 / node v20.18.0 - .net 8 - Microsoft SQL Server

# run details

1.  Open the sln file in /api/SamsungExample directory
    If need be, change the connection string to the database in appsettings.Development.json. By defaut it tries to use windows authentication to localhost.
    Run it as https.

2.  Go to /UserInterface directory in cmd/bash/ps.
    run npm install
    run ng serve --port 4200

Note: if you want to run the angular app on a diferent port changes will need to be made in the backend solution Program.cs to avoid CORS errors.
