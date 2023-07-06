# Supplier Registration ![Supplier Registrations Logo](wwwroot/favicon.ico)



Supplier Registrations is a basic project developed using a combination of C#, .NET, ASP.NET MVC, and ASP.NET Razor Pages. This application aims to provide a simple and straightforward solution for managing supplier information effectively.

## Features

- **User-Friendly Registration**: The application offers an intuitive registration form where users can easily enter essential details about suppliers, including their name, contact information, and address.

- **Secure Data Storage**: Supplier information submitted through the registration form is securely stored in the application's database, ensuring the confidentiality and integrity of the data.

- **Update and Edit**: Users can easily update and edit supplier information as needed, facilitating seamless management of supplier data.

- **Integration with Via Cep API**: The application integrates with the Via Cep API to automatically populate address information based on the provided CEP (postal code). This saves time and improves accuracy in the registration process.

## Technologies Used

- **C#**: Supplier Registrations leverages the power of C# for its back-end development, enabling robust data handling and processing.

- **.NET**: The application is built using .NET, a versatile and feature-rich framework that provides a solid foundation for developing scalable and maintainable web applications.

- **ASP.NET MVC**: The project incorporates the ASP.NET MVC framework, enabling the implementation of a structured and modular architecture for the application.

- **ASP.NET Razor Pages**: Razor Pages are utilized to create a streamlined and cohesive user interface for Supplier Registrations, enhancing the overall user experience.

- **ASP.NET Web**: The project also utilizes ASP.NET Web, allowing the application to take full advantage of the capabilities and features provided by the ASP.NET framework.
  
-  **MySQL**: The application uses MySQL as the relational database management system for storing supplier information.


## Getting Started

To get started with Supplier Registrations, follow these steps:

1. Clone the repository:
2. Open the project in your preferred IDE.

3. In the Solution Explorer, navigate to the `Properties` folder.

4. Open the `appsettings.json` file.

5. Update the database connection string with your own database credentials. Make sure to replace `<database>` with the name of your database.

 ```json
 "ConnectionStrings": {
   "DefaultConnection": "Server=localhost;Port=3306;Database=DB_Suppliers;user={AddYouUserHere};password={addYouPasswordHere};"
 }
 ```

6. Save the `appsettings.json` file.

7. Build and run the application using the appropriate tools for the .NET framework.

## Contributing
Contributions are welcome! Please see the [CONTRIBUTING](CONTRIBUTING.md) file for more information.

## License

This project is licensed under the [MIT License](LICENSE).

---
Thank you for choosing Supplier Registrations! We hope this basic project simplifies the management of supplier information and serves as a solid foundation for further enhancements and customizations.
