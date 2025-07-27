
---

## 📦 Tecnologías Usadas

- ✅ C# 10 / .NET 6
- ✅ Visual Studio 2022
- ✅ Entity Framework Core
- ✅ SQL Server (opcional)
- ✅ Git & GitHub

---

## 📂 Capas del Proyecto

### 🟦 `Diary.Domain`
Contiene las **entidades del dominio** (`User`, `Emotion`, `DiaryEntry`, `Tip`) y los contratos de los repositorios (`IRepository<T>`, etc.).

### 🟩 `Diary.Infrastructure`
Implementa el acceso a datos mediante `DiaryContext` y repositorios concretos que extienden un `BaseRepository<T>`.

---

## 🚀 Cómo ejecutar (en el futuro)

> Si se agrega una capa de presentación (Console o Web):

1. Configurar cadena de conexión en `appsettings.json`
2. Ejecutar migraciones con EF Core:
   ```bash
   Add-Migration InitialCreate
   Update-Database
