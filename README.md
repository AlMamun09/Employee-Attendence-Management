# Employee & Attendance Management System

A simple ERP module for managing employees and tracking daily attendance, built with **ASP.NET Core Web API** (Clean Architecture) and **React**.

![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?logo=dotnet)
![React](https://img.shields.io/badge/React-18-61DAFB?logo=react)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?logo=microsoftsqlserver)
![License](https://img.shields.io/badge/License-MIT-green)

---

## 📋 Features (Planned)

### Employee Management

- [ ] Add, update, delete employees
- [ ] View employee list with search & filter
- [ ] Upload employee photo (optional)
- [ ] Employee fields: Name, Email, Phone, Department, Designation, Joining Date, Salary

### Attendance Tracking

- [ ] Mark daily attendance (Present / Absent / Leave)
- [ ] Edit attendance records
- [ ] View attendance by date or employee
- [ ] Calendar or list view

### Reports

- [ ] Monthly summary per employee
- [ ] Total present/absent/leave counts
- [ ] Export to CSV

---

## 🏗️ Project Structure

```
EmployeeAttendanceManagement/
│
├── Backend/
│   ├── EmployeeAttendance.Domain/         # Entities & Enums
│   ├── EmployeeAttendance.Application/    # DTOs, Services, Interfaces
│   ├── EmployeeAttendance.Infrastructure/ # EF Core, Repositories
│   └── EmployeeAttendance.API/            # Controllers, Configuration
│
└── Frontend/                              # React + Vite + TailwindCSS
    └── src/
        ├── components/                    # Reusable UI components
        ├── pages/                         # Page components
        ├── services/                      # API service layer
        └── App.jsx                        # Main application
```

---

## 🔌 API Endpoints (To Be Implemented)

### Employees

| Method | Endpoint              | Description         |
| ------ | --------------------- | ------------------- |
| GET    | `/api/employees`      | Get all employees   |
| GET    | `/api/employees/{id}` | Get employee by ID  |
| POST   | `/api/employees`      | Create new employee |
| PUT    | `/api/employees/{id}` | Update employee     |
| DELETE | `/api/employees/{id}` | Delete employee     |

### Attendance

| Method | Endpoint                                  | Description             |
| ------ | ----------------------------------------- | ----------------------- |
| POST   | `/api/attendance/mark`                    | Mark attendance         |
| GET    | `/api/attendance/by-date?date=2024-01-10` | Get attendance by date  |
| GET    | `/api/attendance/by-employee/{id}`        | Get employee attendance |

---

## 🛠️ Tech Stack

**Backend:**

- ASP.NET Core 9.0 Web API
- Entity Framework Core
- SQL Server
- Clean Architecture

**Frontend:**

- React 18
- Vite
- TailwindCSS
- React Router

---

## 🚀 Getting Started

### Prerequisites

- .NET SDK 9.0+
- Node.js 18+
- SQL Server

### Backend

```bash
cd Backend/EmployeeAttendance.API
dotnet restore
dotnet build

# Update connection string in appsettings.json
# Run migrations
dotnet ef database update --project ../EmployeeAttendance.Infrastructure

# Run the API
dotnet run
```

API will be available at: `https://localhost:7112`

### Frontend

```bash
cd Frontend
npm install
npm run dev
```

App will be available at: `http://localhost:5173`

---

## 📁 Clean Architecture

```
┌─────────────────────────────────────────┐
│                  API                     │
│         (Controllers, Config)            │
└────────────────┬────────────────────────┘
                 │
┌────────────────▼────────────────────────┐
│            Infrastructure                │
│     (EF Core, Repositories, DB)          │
└────────────────┬────────────────────────┘
                 │
┌────────────────▼────────────────────────┐
│             Application                  │
│      (Services, DTOs, Interfaces)        │
└────────────────┬────────────────────────┘
                 │
┌────────────────▼────────────────────────┐
│               Domain                     │
│           (Entities, Enums)              │
└─────────────────────────────────────────┘
```

---

## 📝 Development Status

This project is currently in active development. Test APIs have been removed and the actual Employee & Attendance management features are being implemented.

---

## 📄 License

This project is for learning and practice purposes.

---

## 🤝 Contributing

Feel free to fork and submit pull requests!
