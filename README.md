<?xml version="1.0" encoding="UTF-8"?>
<ProjectDocumentation>
  <AppInfo>
    <AppName>SayIt</AppName>
    <Description>SayIt is a .NET MAUI cross-platform app that provides basic user authentication using Firebase. The app currently includes functionality for user registration, login, and basic navigation between pages.</Description>
    <Version>1.0</Version>
  </AppInfo>

  <Features>
    <Feature>
      <Title>User Registration</Title>
      <Description>A page where users can create a new account by providing an email and password. Firebase authentication is used to securely store and manage user credentials.</Description>
    </Feature>
    <Feature>
      <Title>User Login</Title>
      <Description>A login page where existing users can authenticate themselves using their email and password.</Description>
    </Feature>
    <Feature>
      <Title>Firebase Authentication Integration</Title>
      <Description>Utilizes Firebase Authentication SDK to handle user account creation and login securely. The app uses Firebase’s email and password authentication methods.</Description>
    </Feature>
    <Feature>
      <Title>Shell Navigation</Title>
      <Description>Implements Shell navigation to provide smooth transitions between the Login, Registration, and Home pages.</Description>
    </Feature>
  </Features>

  <Setup>
    <Requirements>
      <Requirement>.NET MAUI workload</Requirement>
      <Requirement>Firebase Project with Email/Password authentication enabled</Requirement>
    </Requirements>
    <Instructions>
      <Step>Install .NET MAUI using `dotnet workload install maui`.</Step>
      <Step>Set up a Firebase project and enable Email/Password authentication.</Step>
      <Step>Clone the repository and open it in your preferred IDE.</Step>
    </Instructions>
  </Setup>

  <Usage>
    <Step>User opens the app and is presented with the Login page.</Step>
    <Step>If the user has an account, they can log in using their email and password.</Step>
    <Step>If the user is new, they can navigate to the Registration page to create an account.</Step>
    <Step>On successful registration or login, the user is taken to the Home page.</Step>
  </Usage>
 
</ProjectDocumentation>
