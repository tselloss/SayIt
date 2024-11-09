### ProjectDocumentation
## App Info

- **Description**:  
  SayIt is a .NET MAUI cross-platform app that provides basic user authentication using Firebase. The app currently includes functionality for user registration, login, and basic navigation between pages.

- **Version**:  
  1.0



## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Installation](#installation)
- [Usage](#usage)

  ### Overview
    SayIt provides a cross-platform solution for user authentication with Firebase. Users can register and log in securely with Firebase, using the app's simple, intuitive interface built with .NET MAUI.

 ## Features
- **User Registration**: Allows users to create an account with an email and password. Credentials are securely managed by Firebase.
- **User Login**: Enables registered users to log in securely using their email and password.
- **Firebase Authentication**: Integrates Firebase SDK for secure authentication and management of user accounts.
- **Shell Navigation**: Provides smooth transitions between Login, Registration, and Home pages using .NET MAUI Shell.


  ## Tech Stack
- **Framework**: .NET MAUI (C#)
- **Backend**: Firebase
- **Platforms**: Android, iOS, Windows

## Setup

### Prerequisites
- **.NET MAUI workload**: Install using `dotnet workload install maui`.
- **Firebase Project**: Set up a Firebase project with Email/Password authentication enabled.

### Installation Steps
1. **Clone the repository**:  
   ```bash
   git clone https://github.com/your-username/SayIt.git
2. **Navigate to the directory**:  
   ```bash
   cd SayIt
3. **Download Firebase config files**:  
  - Download `google-services.json` for Android or `GoogleService-Info.plist` for iOS from your Firebase project.
  - Add these files to the appropriate location in your project.
4. **Open the solution in Visual Studio**:  
  - Open `SayIt.sln` in Visual Studio.
  - Restore NuGet packages to ensure all dependencies are installed.
5. **Build and run the app**:  
  - Build the app in Visual Studio.
  - Run the app on a simulator or physical device to test it.

  ## Firebase Configuration

1. **Go to Authentication in Firebase Console**:  
   - Navigate to the Authentication section in the Firebase Console.

2. **Select Sign-in method**:  
   - In the Authentication settings, choose the "Sign-in method" tab.

3. **Enable Email/Password authentication**:  
   - Enable the Email/Password authentication option to allow users to sign up and log in with their email and password.


 ## Usage

1. **User opens the app**:  
   - The user is presented with the Login page.

2. **Login with email and password**:  
   - If the user has an existing account, they can log in using their email and password.

3. **Register if the user is new**:  
   - If the user is new, they can navigate to the Registration page to create a new account.

4. **Navigate to Home page**:  
   - After successful registration or login, the user is redirected to the Home page.

