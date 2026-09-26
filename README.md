# 💰 Accounting App

[![C#](https://img.shields.io/badge/C%23-100%25-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![WinForms](https://img.shields.io/badge/UI-Windows%20Forms-0078D6?logo=windows&logoColor=white)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Entity Framework](https://img.shields.io/badge/ORM-Entity%20Framework%206-68217A)](https://learn.microsoft.com/ef/ef6/)
[![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

A desktop **accounting management application** built with **C# / Windows Forms** on top of a clean **multi-layer architecture**. It lets you manage customers, register payment and receipt transactions, and view monthly financial reports — with full support for the **Persian (Shamsi) calendar**.

---

## 📖 Table of Contents

- [Features](#-features)
- [Architecture](#-architecture)
- [Project Structure](#-project-structure)
- [Database Schema](#-database-schema)
- [Tech Stack](#-tech-stack)
- [Getting Started](#-getting-started)
- [How It Works](#-how-it-works)
- [Design Patterns Used](#-design-patterns-used)
- [Contributing](#-contributing)
- [License](#-license)
- [Author](#-author)

---

## ✨ Features

- 🔐 **Login System** — password-protected access with the ability to change username/password from inside the app
- 👥 **Customer Management** — add, edit, delete, and search customers (name, email, mobile, address, profile image)
- 💸 **Transactions** — register **payments** and **receipts** for each customer with amount, description, and date
- 📊 **Dashboard** — live monthly summary of total payments, total receipts, and current account balance
- 📑 **Reports** — separate payment/receipt reports, filterable by customer and description
- 📅 **Persian (Shamsi) Calendar** — automatic Gregorian ⇄ Shamsi date conversion in all reports
- ✏️ **Edit & Delete Transactions** — modify or remove any registered transaction directly from the report grid

---

## 🏗 Architecture

The solution follows a classic **N-Layer (layered) architecture** with a clear separation of concerns:

```
┌─────────────────────────────────────────────┐
│         Accounting_App  (WinForms UI)       │   ← Presentation Layer
├─────────────────────────────────────────────┤
│       Accounting.Business  (Logic)          │   ← Business Layer
├──────────────────────┬──────────────────────┤
│ Accounting.ViewModel │  Accounting.Utility  │   ← ViewModels / Helpers
├──────────────────────┴──────────────────────┤
│    Accounting.DataLAyer  (EF6 + Repos)      │   ← Data Access Layer
├─────────────────────────────────────────────┤
│        SQL Server  (Accoounting_DB)         │   ← Database
└─────────────────────────────────────────────┘
```

---

## 📂 Project Structure

| Project | Description |
|---|---|
| **`Accounting_App`** | Windows Forms UI — all forms of the application: |
| ├─ `Form1` | Main dashboard (monthly payments / receipts / balance) |
| ├─ `FrmLogin` | Login & edit-password form |
| ├─ `Customers/CustomerChange` | Customer list with search, add, edit, delete |
| ├─ `Customers/Add or edit customer` | Customer create/update form |
| ├─ `Accountiing/NewTransaction` | Register or edit a payment/receipt transaction |
| └─ `Accountiing/FrmReport` | Filterable payment & receipt reports |
| **`Accounting.Business`** | Business logic — e.g. `Account.reportView()` computes the monthly financial summary |
| **`Accounting.DataLAyer`** | Data access layer — Entity Framework 6 (Database-First / EDMX), entities, `UnitOfWork`, generic & customer repositories |
| **`Accounting.ViewModel`** | Lightweight DTOs / view models (`ReportViewModel`, `GetcustomerList`) passed between layers |
| **`Accounting.Utility`** | Helpers — `DateConvertor` extension methods for Gregorian ⇄ Shamsi (Persian) date conversion |

---

## 🗄 Database Schema

The app uses a SQL Server database named **`Accoounting_DB`** with the following tables:

| Table | Columns | Purpose |
|---|---|---|
| **`Customer`** | `CustomerID`, `FullName`, `Email`, `Mobil`, `Address`, `CustomerImage` | Customer records |
| **`Accounting`** | `ID`, `CustomerId` (FK), `TypeID` (FK), `Amount`, `Description`, `Datatime` | Financial transactions |
| **`Accounting_Types`** | `TypeID`, `TypeTiile` | Transaction types — `1 = Receive`, `2 = Pay` |
| **`Login_Db`** | `ID`, `Name`, `Password` | Application login credentials |

**Relationships:** `Accounting.CustomerId → Customer.CustomerID` and `Accounting.TypeID → Accounting_Types.TypeID`

---

## 🛠 Tech Stack

| Technology | Usage |
|---|---|
| **C#** | Main programming language (100% of the codebase) |
| **.NET Framework 4.7.2** | Target framework |
| **Windows Forms** | Desktop UI |
| **Entity Framework 6.2** | ORM — Database-First approach with EDMX model |
| **SQL Server** | Relational database |
| **LINQ** | Querying and filtering data |
| **Visual Studio 2019+** | Recommended IDE |

---

## 🚀 Getting Started

### Prerequisites

- Windows OS
- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/) with **.NET desktop development** workload
- [.NET Framework 4.7.2 Developer Pack](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- [SQL Server](https://www.microsoft.com/sql-server) (Express or higher) / LocalDB

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/MohammadHasanp/Project-Accountin.git
   cd Project-Accountin
   ```

2. **Create the database**

   Create a SQL Server database named `Accoounting_DB` containing the four tables described in [Database Schema](#-database-schema), and insert at least one row into `Login_Db` (your username & password for logging in).

3. **Update the connection string** *(if needed)*

   The default connection string in `Accounting_App/App.config` points to the local server (`data source=.`) with integrated security:
   ```
   data source=.;initial catalog=Accoounting_DB;integrated security=True
   ```
   Change `data source` to your own SQL Server instance name if it differs.

4. **Open & run**
   - Open `Accounting.sln` in Visual Studio
   - Restore NuGet packages (EntityFramework 6.2.0)
   - Set `Accounting_App` as the startup project
   - Press **F5** to build and run

---

## ⚙ How It Works

1. **Login** — on startup, the main form is hidden and `FrmLogin` validates the credentials against the `Login_Db` table.
2. **Dashboard** — after a successful login, `Account.reportView()` sums all transactions of the current month and shows **Payments**, **Receipts**, and **Balance**.
3. **Customers** — the customer side panel supports live search filtering and full CRUD through `CustomerRepository`.
4. **New Transaction** — select a customer from the grid, enter the amount and description, choose *Receive* or *Pay*, and submit.
5. **Reports** — receipts and payments each have their own report form, filterable by customer and description, with dates displayed in the **Shamsi** calendar.

---

## 🧩 Design Patterns Used

- **Repository Pattern** — `IGenericRepositorey<T>` / `GenericRepositorey<T>` for generic CRUD, plus a specialized `ICustomerRepository` / `CustomerRepository`
- **Unit of Work** — `UnitOfWork` class coordinates repositories and commits changes through a single `DbContext`
- **Layered (N-Tier) Architecture** — UI, Business, Data Access, ViewModel, and Utility concerns separated into independent projects
- **Extension Methods** — `DateConvertor.ToShamsi()` / `ToMiladi()` for clean date conversion syntax

---

## 🤝 Contributing

Contributions are welcome! Feel free to:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m "Add amazing feature"`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

---

## 📜 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

## 👤 Author

**Mohammad Hasan**

- GitHub: [@MohammadHasanp](https://github.com/MohammadHasanp)

---

⭐ If you find this project useful, please give it a star!
