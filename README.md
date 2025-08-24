# Simple WinForms Login with Local MySQL Database

This repository contains a straightforward desktop application demonstrating a user login system. The project is built with C# using Windows Forms and connects to a local MySQL database managed via XAMPP.

It serves as a clear, practical example of how to handle user authentication in a .NET desktop application by validating credentials against a database.
#Features

    **User-friendly Interface:** A clean and simple login screen.

    **Database Connection:** Establishes a connection to a local MySQL database.

    **Credential Validation:** Securely checks user-provided credentials against stored records.

    **Status Feedback:** Provides clear messages for successful or failed login attempts.

# Technologies Used

    **C#:** The core programming language for the application logic.

    **Windows Forms (.NET Framework):** For building the graphical user interface.

    **MySQL:** The relational database used to store user credentials.

    **XAMPP:** Manages the local Apache and MySQL server environment.

    **MySQL Connector/NET:** The ADO.NET driver for connecting the C# application to the MySQL database.

# Prerequisites

Before you begin, ensure you have the following installed:

    **Visual Studio:** The IDE for running and editing the C# project.

    **XAMPP:** To run the local MySQL database server.

    **MySQL Connector/NET:** To enable the connection between the application and the database.

# Getting Started

Follow these steps to get the project up and running on your local machine.
**1. Set Up the Database**

    Start the **Apache** and **MySQL** services in your **XAMPP** Control Panel.

    Open your web browser and navigate to http://localhost/phpmyadmin.

    Create a new database named SistemaLogin.

    Select the SistemaLogin database and run the following SQL script to create the usuarios table and insert a sample user:

    CREATE TABLE IF NOT EXISTS USUARIOS(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
        usuario VARCHAR(50) NOT NULL, 
        senha VARCHAR(50) NOT NULL 
        ) DEFAULT CHARSET = UTF8MB4 COLLATE = UTF8MB4_UNICODE_CI;

    INSERT INTO usuarios (usuario, senha) VALUES ('admin', 'admin123');
    INSERT INTO usuarios (usuario, senha) VALUES ('lucas', 'Lucas123');

**2. Configure the Application**

    Clone this repository to your local machine:

    git clone https://github.com/PedroDutraSouza/Login-DB-local.git

    Open the solution file (.sln) in **Visual Studio**.

    Ensure the connection string in the **C#** code correctly points to your local database. The default should work with a standard **XAMPP** setup:

    // Example connection string
    string conn = "server=localhost;database=SistemaLogin;uid=root;password=;";

    Build and run the project by pressing F5 in Visual Studio.

3. Test the Login

Use the following credentials to log in:

    Username: admin

    Password: admin123

# License

This project is open-source and available to everyone.
