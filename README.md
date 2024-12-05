# CS460HW1
For this assignment you'll build a simple web application that lets you do something I need to do frequently: form teams.  The most important example of doing this is when we put you into teams of 3 or 4 for your big 2-term software engineering project at the end of this term.  If I want to form teams randomly I'll often whip out a Python session, paste in a list of names, shuffle the list, then partition it into the desired team size.  It would be a lot nicer to have an application to do all this with the click of a mouse. 

Let's get started.  For this assignment I will give you the functional requirements in the form of a video demonstration of my "solution".  (I put that in quotes because there are many solutions; so mine is really just my version of meeting the requirements.  Yours will look different but should function identically.)  Here's what it should do in a nutshell:

The application should take a list of names and assign them into teams randomly.  The user specifies the team size.  Lastly the app should assign team titles randomly so it's easier to identify teams.


The video (hopefully) describes the functional requirements completely.  We do have further requirements that I'm adding to ensure you do things certain ways.  Some of these are appropriately called non-functional requirements.  Your solution must meet these further requirements:

- Use .NET 8.0 and C#
- Use Bootstrap and style it nicely
- Use MVC with a single controller
- Use a POST request to send the list of names to the server.  The assignment of names to teams must be done on the server in C#.  Build the teams page using Razor in a View following the traditional MVC way.
- All pages must use a "strongly typed view" with either a view-model or a model.  You may not use the ViewBag or ViewData for any page data (i.e. names, team names, team size, ...)  
- The form must have input validation on the list of names and on the team size:
- The list of names must be one name per line.  Allowed characters are only: letters, spaces and the characters ,.-_'
- Team size must be an integer between 2 and 10 (inclusive)
- The page showing team assignments needs to have some special styling.  You don't have to create random colors as I have done, but you must do something more than simply throwing names into a list.  Use colors, borders, background images, etc ... (I used Bootstrap CardsLinks to an external site. and      gradient background colors).  
- When the button is pressed to assign names to the teams, you must accomplish this task using Javascript only with no page reloads.  Here is the list of animal names I used: animals.txtLinks to an external site. (thank you Alberto Scorrano).  Feel free to use something else to name your teams, but        whatever it is, it must have hundreds of names to choose from.
- You must write, and pass, 4 Unit test methods that test some part of the functional requirements of this assignment.  The best way to do this is to add a separate C# NUnit project to your solution file and write a single .cs file there that uses NUnit.  
- As discussed in class, you may use code from online resources but it must be attributed in your source code in a comment.  It must always include a link to the source.
  Turn in this homework as discussed in the turn in your homework page which means you'll need to do your work in the GitHub repository given to you by the instructor and make sure and push your finalized work to it prior to the due date and also create a demonstration video and upload a link to this      video on Canvas before the due date.

Homework 1 Team Building
Sources used for this homework:

Read from and write to a text file by Visual C# - C# | Microsoft Learn
https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file

StreamReader.ReadLine Method (System.IO) | Microsoft Learn
https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader.readline?view=net-8.0

// and /* */ - comments - C# reference | Microsoft Learn
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/comments


Overview - A tour of C# | Microsoft Learn
https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/overview#code-try-1

C# learning | Pluralsight
https://www.pluralsight.com/browse/software-development/c-sharp


How to run a program (C#) - Visual Studio (Windows) | Microsoft Learn
https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/run-program?view=vs-2022#start-from-code

Debugging C# in Visual Studio Code
https://code.visualstudio.com/docs/csharp/debugging

C# Read File: A Beginner's Guide to Reading Text Files in C# - Stackify
https://stackify.com/c-read-file-a-beginners-guide-to-reading-text-files-in-c/

C# | List Class - GeeksforGeeks
https://www.geeksforgeeks.org/c-sharp-list-class/

HTML textarea tag
https://www.w3schools.com/tags/tag_textarea.asp

W3Schools Tryit Editor
https://www.w3schools.com/tags/tryit.asp?filename=tryhtml_textarea

How to read line by line of a text area HTML tag with JavaScript? - The Web Dev
https://thewebdev.info/2022/05/19/how-to-read-line-by-line-of-a-text-area-html-tag-with-javascript/

HTML <textarea> Tag: Usage, Attributes, and Examples - HTML Easy
https://www.html-easy.com/references/html-textarea-tag/

javascript - How to read text line by line in a html text area? - Stack Overflow
https://stackoverflow.com/questions/17595361/how-to-read-text-line-by-line-in-a-html-text-area

Divide strings using String.Split - C# | Microsoft Learn
https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split#code-try-5

String.Split() Method in C# with Examples - GeeksforGeeks
https://www.geeksforgeeks.org/string-split-method-in-c-sharp-with-examples/

Branches and loops - Introductory tutorial - A tour of C# | Microsoft Learn
https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops-local

Iteration statements -for, foreach, do, and while - C# reference | Microsoft Learn
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements

Cards · Bootstrap
https://getbootstrap.com/docs/4.0/components/card/#using-grid-markup

HTML Collection for Loop - GeeksforGeeks
https://www.geeksforgeeks.org/htmlcollection-for-loop/

Team Members - TeamBuilder
http://localhost:5001/Home/SubmitNames

How to Get List Length in C# | Delft Stack
https://www.delftstack.com/howto/csharp/get-list-length-in-csharp/

Math.Floor Method (System) | Microsoft Learn
https://learn.microsoft.com/en-us/dotnet/api/system.math.floor?view=net-8.0

C# For Loop
https://www.w3schools.com/cs/cs_for_loop.php

Arrays - C# reference | Microsoft Learn
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays

Multi-dimensional arraylist or list in C#? - Stack Overflow
https://stackoverflow.com/questions/1596530/multi-dimensional-arraylist-or-list-in-c

Typography · Bootstrap v5.3
https://getbootstrap.com/docs/5.3/content/typography/

Cards · Bootstrap
https://getbootstrap.com/docs/4.0/components/card/

Cards · Bootstrap v5.3
https://getbootstrap.com/docs/5.3/components/card/

c# - How Can I Add a Unit Test Project to an Existing MVC3 Application (from empty template) - Stack Overflow
https://stackoverflow.com/questions/4759860/how-can-i-add-a-unit-test-project-to-an-existing-mvc3-application-from-empty-te

Testing C# with C# Dev Kit in Visual Studio Code
https://code.visualstudio.com/docs/csharp/testing

Unit testing C# code in .NET using dotnet test and xUnit - .NET | Microsoft Learn
https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test

ChatGPT
https://chatgpt.com
