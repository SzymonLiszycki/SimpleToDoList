Readme - SimpleToDoList ASP.NET MVC Project**

---

### Project Description

This project, named SimpleToDoList, is a simple ToDo List application developed using ASP.NET MVC. It serves as a project for the "Projektowanie Interfejsów" (User Interface Design) course and implements basic CRUD (Create, Read, Update, Delete) operations for managing tasks in a ToDo list.

### Table of Contents

1. [Features](#features)
2. [Requirements](#requirements)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)

---

### Features

- **Create**: Add new tasks to the ToDo list.
- **Read**: View the list of tasks along with their details.
- **Update**: Modify task details or update their status.
- **Delete**: Remove tasks from the ToDo list.

### Requirements

- Visual Studio 2019 or later
- .NET Core SDK
- PostgreSQL Database

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/SzymonLiszycki/SimpleToDoList.git
    ```

2. Open the solution in Visual Studio.

3. Update the `appsettings.json` file with your PostgreSQL connection string. Modify the following section:

    ```json
    "ConnectionStrings": {
        "PgDb": "Server=;Database=;User Id=;Password=;Search Path=public;"
    }
    ```

    Change it to your PostgreSQL connection string:

    ```json
    "ConnectionStrings": {
        "PgDb": "Host=your_postgres_host;Port=your_postgres_port;Database=your_database_name;Username=your_username;Password=your_password;"
    }
    ```

4. Open Package Manager Console.

5. Run the following commands to apply migrations:

    ```bash
    Add-Migration InitialCreate
    Update-Database
    ```

6. Build and run the application.

### Usage

1. Launch the application.
2. Navigate to the ToDo list page.
3. Use the interface to add, view, update, or delete tasks.
4. 
### License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

### Opis Projektu

Ten projekt o nazwie SimpleToDoList to prosta aplikacja listy zadań (ToDo List) stworzona przy użyciu ASP.NET MVC. Jest on projektem do zaliczenia z przedmiotu "Projektowanie Interfejsów" i implementuje podstawowe operacje CRUD (Create, Read, Update, Delete) do zarządzania zadaniami na liście ToDo.

### Spis Treści

1. [Funkcje](#features)
2. [Wymagania](#requirements)
3. [Instalacja](#installation)
4. [Użycie](#usage)
5. [Współtworzenie](#contributing)
6. [Licencja](#license)

---

### Funkcje

- **Create**: Dodawanie nowych zadań do listy ToDo.
- **Read**: Przeglądanie listy zadań wraz z ich szczegółami.
- **Update**: Modyfikacja szczegółów zadania lub aktualizacja jego statusu.
- **Delete**: Usuwanie zadań z listy ToDo.

### Wymagania

- Visual Studio 2019 lub nowsze
- .NET Core SDK
- Baza danych PostgreSQL

### Instalacja

1. Sklonuj repozytorium:

    ```bash
    git clone https://github.com/SzymonLiszycki/SimpleToDoList.git
    ```

2. Otwórz rozwiązanie w programie Visual Studio.

3. Zaktualizuj plik `appsettings.json` o swoje połączenie z bazą danych PostgreSQL. Zmodyfikuj poniższą sekcję:

    ```json
    "ConnectionStrings": {
        "PgDb": "Server=;Database=;User Id=;Password=;Search Path=public;"
    }
    ```

    Na swoje połączenie z bazą danych PostgreSQL:

    ```json
    "ConnectionStrings": {
        "PgDb": "Host=twoj_host_postgres;Port=twoj_port_postgres;Database=twoja_nazwa_bazy;Username=twoja_nazwa_uzytkownika;Password=twoje_haslo;"
    }
    ```

4. Otwórz Konsolę Menedżera Pakietów.

5. Uruchom poniższe polecenia, aby zastosować migracje:

    ```bash
    Add-Migration InitialCreate
    Update-Database
    ```

6. Zbuduj i uruchom aplikację.

### Użycie

1. Uruchom aplikację.
2. Przejdź do strony listy ToDo.
3. Korzystaj z interfejsu do dodawania, przeglądania, aktualizowania lub usuwania zadań.

![Zrzut ekranu 2024-01-06 094522](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/9b055e51-036d-4560-bc28-c31d2f2a148d)
![Zrzut ekranu 2024-01-06 094159](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/c69b1d58-0fcf-4e39-882a-737f8c28b76e)
![Zrzut ekranu 2024-01-06 094728](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/bd2fa2c4-9fe9-424b-8209-14df95f6bbeb)
![Zrzut ekranu 2024-01-06 094704](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/28131271-35bd-44dd-8477-b9a9a2aa6b6b)
![Zrzut ekranu 2024-01-06 094617](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/43446f70-8183-4424-aba7-4d0cd1199e1e)
![Zrzut ekranu 2024-01-06 094555](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/9bb02871-e12a-4de2-bda7-f6675b733a89)
 projekt jest objęty licencją MIT - zobacz plik [LICENSE](LICENSE) w celu uzyskania szczegółów.
