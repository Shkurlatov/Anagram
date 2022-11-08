# Anagram

The repository contains my work on self-completion of a study Task 
while taking specialized online courses for training C# developers.

An experienced Mentor checked the result and made his remarks on 
the quality of the work performed. The Task could not be completed 
until the Mentor decided that the result was up to industry standards.

The commit called “First implementation of the Task” is my original 
implementation, without any hints. All subsequent commits (if any) 
are the results of my attempts to solve Mentor's remarks and his 
suggestions for improvement the work.

According to the conditions of the school, the Mentor does not provide 
ways to solve shortcomings and sources of information. The search for 
the necessary educational information was carried out independently.
<br/><br/>

## Task Conditions

Create a console application for reverse each word in the input line.
<br/>

__Examples:__
* _Input_ `"abcd efgh"` => _Output_ `"dcba hgfe"`
* _Input_ `"Test"` => _Output_ `"tseT"`
<br/><br/>

All non-alphabetic symbols should stay in their original &nbsp; places.
<br/>

__Examples:__
* _Input_ `"a1bcd efg!h"` => _Output_ `"d1cba hgf!e"`
* _Input_ <code>"a1bcd &nbsp;efg!h"</code> => _Output_ <code>"d1cba &nbsp;hgf!e"</code>

<br/>
Space is the divider for words in a line.
<br/><br/>
Spaces (as one of non alphabetic symbols) should not be deleted from the result string.
<br/><br/>
Create a test project for checking the algorithm of the reverse.
<br/><br/>

## Solution Structure

__📁AnagramProject__<br/>
 ┣ 📄Anagram.cs<br/>
 ┗ 📄Program.cs<br/>
 📁Task1UnitTestProject<br/>
 ┗ 📄AnagramTests.cs
<br/><br/>

## Prerequisites

Microsoft Visual Studio 2019 or newer

* Workloads<br/>
    * ASP.NET and web development

- Individual components<br/>
    - .NET Core 3.1 Runtime (LTS) 
<br/><br/>

## Getting Started

Clone the remote repository on your local machine.<br/>
`$ git clone https://github.com/Shkurlatov/Anagram.git`
<br/><br/>
Go to the project directory.<br/>
`$ cd Anagram`
<br/><br/>
Open project solution in Microsoft Visual Studio.<br/>
`$ start Task1.sln`
<br/><br/>
Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> to run the application.
<br/><br/>
Use the application following directions in console window. 
<br/><br/>
Press <kbd>Ctrl</kbd>+<kbd>R</kbd>,<kbd>A</kbd> to run tests.
<br/><br/>

## Usage Example

```
Enter your text
User's typing.
Your text after processing: sres'U gnipyt.

Press any key to close this window . . .
```
