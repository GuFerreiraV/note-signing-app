# Note Signing App

## Description

This is a cross-platform mobile application built with .NET MAUI for signing fiscal notes (invoices). The app allows users to search for invoices, view their details, and sign them digitally using a signature pad. Signatures are saved to a database and screenshots are uploaded to an SMB server.

## Features

- Search for invoices by branch (filial), series, and note number
- Display invoice details: number, client name, issue date
- Digital signature capture using a signature pad
- Validation of user information (name and RG/ID)
- Save signature records to database
- Capture and upload screenshots to SMB server
- Cross-platform support for Android and Windows

## Technologies Used

- .NET MAUI 9.0
- C#
- Entity Framework Core
- Oracle Database
- SMBLibrary for SMB file uploads
- Community Toolkit for MAUI

## Requirements

- .NET 10 SDK
- Android SDK (for Android builds)
- Windows SDK (for Windows builds)
- Oracle Database connection
- SMB server for file uploads

## Installation

1. Clone the repository:
   ```
   git clone https://github.com/GuFerreiraV/note-signing-app.git
   ```

2. Navigate to the project directory:
   ```
   cd note-signing-app/note-signing-app
   ```

3. Restore NuGet packages:
   ```
   dotnet restore
   ```

4. Configure database connection and SMB settings in the services.

5. Build and run the app:
   - For Android: `dotnet build -t:Run -f net10.0-android`
   - For Windows: `dotnet build -t:Run -f net10.0-windows10.0.19041.0`

## Usage

1. Enter the branch, series, and note number to search for an invoice.
2. Review the invoice details.
3. Enter your name and RG (ID number, 10 characters).
4. Sign on the signature pad.
5. Submit to save the signature and upload the screenshot.

## Contributing

Feel free to open issues or pull requests for improvements.
