using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Services
{
    public class DatabaseService
    {
        private string _host = "localhost";
        private int _port = 5432;
        private string _username = "postgres";
        private string _password = "nixneris5";
        private string _databaseName = "HotelDB";

        private string MasterConnectionString => $"Host={_host};Port={_port};Username={_username};Password={_password};Database=postgres";
        private string DbConnectionString => $"Host={_host};Port={_port};Username={_username};Password={_password};Database={_databaseName}";
    }

            public bool DatabaseExists()
        {
            try
            {
                using (var conn = new NpgsqlConnection(MasterConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT 1 FROM pg_database WHERE datname = @dbname";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dbname", _databaseName);
                        return cmd.ExecuteScalar() != null;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public void CreateDatabase()
        {
            using (var conn = new NpgsqlConnection(MasterConnectionString))
            {
                conn.Open();
                string sql = $"CREATE DATABASE {_databaseName}";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool TablesExist()
        {
            try
            {
                using (var conn = new NpgsqlConnection(DbConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = 'public' AND table_name = 'hotel_rooms'";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        return (long)cmd.ExecuteScalar() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public void CreateTables()
        {
            string sql = @"
CREATE TABLE IF NOT EXISTS Hotel_Rooms (
    room_id SERIAL PRIMARY KEY,
    category VARCHAR(50) NOT NULL,
    room_number VARCHAR(10) UNIQUE NOT NULL,
    base_price_per_night DECIMAL(10, 2) NOT NULL CHECK (base_price_per_night >= 0),
    capacity INTEGER NOT NULL CHECK (capacity > 0 AND capacity <= 10),
    status VARCHAR(20) DEFAULT 'свободен' CHECK (status IN ('свободен', 'занят', 'ремонт', 'забронирован')),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS Bookings (
    booking_id SERIAL PRIMARY KEY,
    room_id INTEGER NOT NULL,
    check_in_date DATE NOT NULL,
    check_out_date DATE NOT NULL,
    guest_count INTEGER NOT NULL CHECK (guest_count > 0),
    total_price DECIMAL(10, 2) NOT NULL CHECK (total_price >= 0),
    booking_source VARCHAR(50) NOT NULL CHECK (booking_source IN ('Яндекс.Путешествия', 'Туту.ру', 'Прямой звонок', 'Сайт отеля', 'Booking.com', 'Другое')),
    status VARCHAR(20) DEFAULT 'подтверждено' CHECK (status IN ('подтверждено', 'отменено', 'завершено', 'не заехал')),
    customer_email VARCHAR(255),
    customer_phone VARCHAR(20),
    notes TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    
    CONSTRAINT valid_dates CHECK (check_out_date > check_in_date),
    CONSTRAINT fk_room FOREIGN KEY (room_id) REFERENCES Hotel_Rooms(room_id) ON DELETE RESTRICT
);

CREATE TABLE IF NOT EXISTS External_Factors (
    factor_id SERIAL PRIMARY KEY,
    type VARCHAR(50) NOT NULL,
    date DATE NOT NULL,
    value VARCHAR(500) NOT NULL,
    impact_coefficient DECIMAL(5, 3) DEFAULT 1.000,
    description TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS Users (
    user_id SERIAL PRIMARY KEY,
    login VARCHAR(50) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    role VARCHAR(20) NOT NULL CHECK (role IN ('admin', 'manager')),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO Users (login, password_hash, role) 
VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'admin')
ON CONFLICT (login) DO NOTHING;

CREATE INDEX IF NOT EXISTS idx_rooms_category ON Hotel_Rooms(category);
CREATE INDEX IF NOT EXISTS idx_rooms_status ON Hotel_Rooms(status);
CREATE INDEX IF NOT EXISTS idx_bookings_room_id ON Bookings(room_id);
CREATE INDEX IF NOT EXISTS idx_bookings_dates ON Bookings(check_in_date, check_out_date);
CREATE INDEX IF NOT EXISTS idx_bookings_status ON Bookings(status);

CREATE OR REPLACE FUNCTION update_updated_at_column()
RETURNS TRIGGER AS $$
BEGIN
    NEW.updated_at = CURRENT_TIMESTAMP;
    RETURN NEW;
END;
$$ language 'plpgsql';

DROP TRIGGER IF EXISTS update_hotel_rooms_updated_at ON Hotel_Rooms;
CREATE TRIGGER update_hotel_rooms_updated_at 
    BEFORE UPDATE ON Hotel_Rooms
    FOR EACH ROW
    EXECUTE FUNCTION update_updated_at_column();

DROP TRIGGER IF EXISTS update_bookings_updated_at ON Bookings;
CREATE TRIGGER update_bookings_updated_at 
    BEFORE UPDATE ON Bookings
    FOR EACH ROW
    EXECUTE FUNCTION update_updated_at_column();
";

            using (var conn = new NpgsqlConnection(DbConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
            public void InitializeDatabase()
{
    if (!DatabaseExists())
    {
        CreateDatabase();
        System.Threading.Thread.Sleep(500); // Ждем, пока PostgreSQL создаст БД
    }

    if (!TablesExist())
    {
        CreateTables();
    }

    // Миграция для добавления колонки затрат (Экономика)
    try
    {
        using (var conn = new NpgsqlConnection(DbConnectionString))
        {
            conn.Open();
            string alterSql = "ALTER TABLE Hotel_Rooms ADD COLUMN IF NOT EXISTS maintenance_cost DECIMAL(10,2) DEFAULT 1500.00;";
            using (var cmd = new NpgsqlCommand(alterSql, conn)) cmd.ExecuteNonQuery();
        }
    }
    catch { /* Игнорируем, если колонка уже есть */ }
}
}
