using Microsoft.EntityFrameworkCore;
using UgnayDesktop.Models;
using BCrypt.Net;

namespace UgnayDesktop.Data;

public static class DbInitializer
{
    public static void Seed()
    {
        using var db = new AppDbContext();

        db.Database.EnsureCreated();

        db.Database.ExecuteSqlRaw(@"
            CREATE TABLE IF NOT EXISTS SensorReadings (
                Id INTEGER NOT NULL CONSTRAINT PK_SensorReadings PRIMARY KEY AUTOINCREMENT,
                DeviceId TEXT NOT NULL,
                ReceivedAtUtc TEXT NOT NULL,
                FlexValue REAL NULL,
                AccelX REAL NULL,
                AccelY REAL NULL,
                AccelZ REAL NULL,
                GyroX REAL NULL,
                GyroY REAL NULL,
                GyroZ REAL NULL,
                HeartRate REAL NULL,
                Spo2 REAL NULL,
                GsrValue REAL NULL,
                BodyTemperatureC REAL NULL,
                RawJson TEXT NOT NULL
            );
        ");

        EnsureUserTeacherPhoneColumn(db);
        EnsureUserDeviceIdColumn(db);
        EnsureUserAgeColumn(db);
        EnsureUserSexColumn(db);

        if (!db.Users.Any())
        {
            var admin = new User
            {
                Username = "admin",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                Role = "Admin",
                FullName = "System Administrator"
            };

            db.Users.Add(admin);
            db.SaveChanges();
        }
    }

    private static void EnsureUserTeacherPhoneColumn(AppDbContext db)
    {
        TryAlterUsersColumn(db, "ALTER TABLE Users ADD COLUMN TeacherPhoneNumber TEXT NULL;");
    }

    private static void EnsureUserDeviceIdColumn(AppDbContext db)
    {
        TryAlterUsersColumn(db, "ALTER TABLE Users ADD COLUMN DeviceId TEXT NULL;");
    }

    private static void EnsureUserAgeColumn(AppDbContext db)
    {
        TryAlterUsersColumn(db, "ALTER TABLE Users ADD COLUMN Age INTEGER NULL;");
    }

    private static void EnsureUserSexColumn(AppDbContext db)
    {
        TryAlterUsersColumn(db, "ALTER TABLE Users ADD COLUMN Sex TEXT NULL;");
    }

    private static void TryAlterUsersColumn(AppDbContext db, string sql)
    {
        try
        {
            db.Database.ExecuteSqlRaw(sql);
        }
        catch
        {
            // Column already exists on updated databases.
        }
    }
}
