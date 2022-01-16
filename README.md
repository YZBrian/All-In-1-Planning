# All-In-1-Planning
## Table of Contents
* [Introduction](#Introduction)
* [Technologies](#Technologies)
* [functionalities](#functionalities)
* [Suggestions](#Suggestions)
* [Packages_and_Versions](#Packages_and_Versions)

## Introduction:
The goal of this application is to provide the customer with a simple application in which a user can add events.
These events can then be viewed in a simple way to keep an overview on all upcoming events.

## Technologies:
In this project, the following technologies have been used. I've added hyperlinks for easy access.
- C# (in [Visual Studio](https://visualstudio.microsoft.com/downloads/)) for the backend. Documenation for: [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [Microsoft.NET](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0).
- [Vue.js](https://vuejs.org/) for the frontend. I've added my personal frontend repository [here](https://github.com/YZBrian/PlannerFrontend).
- A MySql (using [MySql Workbench](https://dev.mysql.com/downloads/workbench/)) database for data storage.

## functionalities:
- Creating events with a title, date, time and priority.
- Remove existing events.

## Suggestions:
- Add a filter option for priority events.
- Change the true/false statement for priorities to a red exclamation mark.
- Add a green, orange or red clock to an event depending on how soon said event will take place.
- Connect an SMS API that sends a message when an event is 24 hours away.

## Packages_and_Versions:
- Microsoft.EntityFrameWorkCore (5.0.11)
- Microsoft.EntityFrameWorkCore.SqlServer (5.0.11)
- Microsoft.EntityFrameWorkCore.Tools (5.0.11)
- MySql.Data  (8.0.27)
- MySql.EntityFrameworkCore (5.0.5)
- Swashbuckle.AspNetCore (6.2.3)
