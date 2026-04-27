South African Home Affairs Digital Identity Processor

Project Overview
This application provides a digital interface for processing South African citizen information. 
It allows for the collection of personal details, ID validation and the creation of a citizen profile summary.

Key Features
Citizen Data Collection: Captures Full Name, Surname, and ID Number.
ID Validation:A dedicated validation engine to check the authenticity of South African ID numbers.
Citizenship Categorization:Dropdown selection for identifying citizenship status.
Profile Summary Generation:Dynamically generates a "Citizen Summary" profile based on user input.

How the project Works
1. Input: The user enters their name and a 13-digit South African ID number.
2. Validation: When the user clicks "Validate your ID" button, it runs logic to check the ID format and extract details (like birthdate or gender).
3. Profiling: When the user clicks the "Create Profile" button, it populates the summary box on the right with the formatted citizen data.

Tech Stack
Language: C#
Platform:.NET Windows Forms
IDE: Visual Studio 2022

Fun Fact!:)
The "Citizenship" Status
The 11th digit tells you if the person is a citizen or a permanent resident:
If the 11th digit is 0 then the user is a South African Citizen
If the 11th didgit is 1 then the user is a Permanent Resident!

A Non-Coding Fun Fact!:)
Since your app is for Home Affairs. Did you know that the very first "Home Affairs" records in South Africa were actually kept in a massive church register 
in Cape Town back in the 1600s? We’ve definitely come a long way moving that logic into a C# Windows Form!
