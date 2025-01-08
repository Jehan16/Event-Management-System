# Event Management System

This is a robust **Event Management System** built with **React** (frontend) and **.NET Core** (backend), using **PostgreSQL** as the database.

## Features

### Backend

- **Event Management:** Create, update, and delete events with validation.
- **Attendee Registration:** Register attendees with capacity checks.

### Frontend

- **Reusable Components:** Buttons, forms, modals, and tables.
- **Responsive Pages:** Event listing, detail, creation, and update pages.
- **State Management:** Using React Context API/Redux Toolkit.

## Setup Instructions

### Backend

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-repo/event-management-system.git
   ```
2. **Navigate to the backend directory**
   ```bash
   cd EventManagementAPI
   ```
3. **Configure the Database**
   - Update the `appsettings.json` file with your database connection string.
4. **Run Migrations**
   ```bash
   dotnet ef database update
   ```
5. **Run the Backend**
   ```bash
   dotnet run
   ```

### Frontend

1. **Navigate to the frontend directory**
   ```bash
   cd frontend
   ```
2. **Install Dependencies**
   ```bash
   npm install
   ```
3. **Run the Frontend**
   ```bash
   npm start
   ```

## API Endpoints

- `GET /api/events`: Fetch all events (supports filters).
- `POST /api/events`: Add a new event.
- `PUT /api/events/{id}`: Update an event.
- `DELETE /api/events/{id}`: Delete an event.
- `POST /api/events/{id}/register`: Register attendees.

## Technologies Used

- **Backend:** .NET Core, Entity Framework Core
- **Frontend:** React, React Context API/Redux Toolkit
- **Database:** PostgreSQL
