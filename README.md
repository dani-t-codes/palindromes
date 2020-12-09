# Palindromes

#### In-class Practice Assignment during Epicodus Coding School, C# Practice with constructors in classes and adding custom methods, 12.08.2020

#### By Danielle Thompson & Harrison Strand

## Description

A palindrome is any word, phrase, number, or other sequence of characters that reads the same both backward or forward. This application includes a method to identify whether a word is a palindrome. It returns true if the user-provided word is a palindrome and false if it is not.

## Technologies used

- C# v 7.3
- .NET Core v 2.2
- dotnet script, REPL

## Installation Requirements

#### Installing Git
###### For Mac Users

- Access Terminal in your Finder, and open a new window. Install the package manager, (Homebrew) [https://brew.sh/], on your device by entering this line of code in Terminal: `$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"`.
- Ensure Homebrew packages are run with this line of code: `echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile`.
- Once homebrew is installed, install Git, a version control system for code writers, with this line of code `brew install git`.

###### For Windows Users

- Open a new Command Prompt window by typing "Cmd" in your computer's search bar.
- Determine whether you have 32-bit or 64-bit Windows by following these (instructions)[https://support.microsoft.com/en-us/help/13443/windows-which-version-am-i-running].
- Go to (Git Bash)[https://gitforwindows.org/], click on the "Download" button, and download the corresponding exe file from the Git for Windows site._
- Follow the instructions in the set up menu.

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/dani-t-codes/palindromes], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/dani-t-codes/palindromes.git`.


#### Installing C#, .NET, dotnet script, & MySQL

* Install C# and .Net according to your operating system below. 

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command $ dotnet --version, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download either the the 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* Navigate to the project folder on your Terminal or CMD.
* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application. 
* `dotnet restore` to install packages listed in project's boilerplate. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :----------------------------|
| **Takes user entry and turns string into array**    | User enters: palindrome | Return: ["palindrome"] |
| **Takes array and splits word(, etc.) into individual characters**    | User enters: palindrome | Return: ["p", "a", "l", "i", "n", "d", "r", "o", "m", "e"] |
| **Takes split array and reverses in order**    | Takes: ["p", "a", "l", "i", "n", "d", "r", "o", "m", "e"] | Returns: ["e", "m", "o", "r", "d", "n", "i", "l", "a", "p"] |
| **Checks to see if reversed entry is a Palindrome** | User enters: "racecar" |  Output: `You've found a palindrome - true`|
| **Checks to see if reversed entry is not a Palindrome** | User enters: "palindrome" |  Output: `That is not a palindrome. Try again. - false`|


### Tests

Describe: flipItAndReverseIt()
Test: flipItAndReverseIt(userInput).toEqual(userInput read backwards, in order)
Expect: flipItAndReverseIt(palindrome).toEqual(emordnilap)

Describe: checkPalindromeStatus()
Test:
If Array.Reverse() == userInputPalindrome
  return true
  Console.WriteLine("You've found a palindrome!")
Else Array.Reverse(). !== userInputPalindromes
  return false
  Console.WriteLine("That is not a palindrome.")
Expect: checkPalindromeStatus(palindrome).return(False - emordnilap)
Expect: checkPalindromeStatus(racecar).return(True - racecar)

## Known bugs

No known bugs as of now. 

### Legal, or License

_MIT_ Copyright (c) 2020 *_Danielle Thompson, Harrison Strand_**
