# Microsoft.Teams.Api

This project contains the source code for the nuget package Microsoft.Teams.Api which is built on top of the Microsoft Teams RESTFul APIs which are bundled as a part of Microsoft Graph APIs package. This project provides more context into object oriented framework for below mentioned actions:<br><br>
<b><u>1. `Task<OnlineMeeting> GetOnlineMeetingsAsync(string meetingId)`</u></b><br>
   Get Microsoft Teams online meetings information along with attendants (both invited & from lobby).

## Build

Run `dotnet build` for a compiling the codebase locally or on any .NET Runtime based terminal. Once completed, you can import the same into any project which can used the class library as an either a Nuget package or a project reference.

## Running unit tests

Run `dotnet test` for running unit test cases on the solution.

## Further help

To get more help on the Dotnet CLI use `dotnet help` or go check out the [Dotnet Standards Documentations](https://docs.microsoft.com/en-gb/dotnet/standard/net-standard) page.
