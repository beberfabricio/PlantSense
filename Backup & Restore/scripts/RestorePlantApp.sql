USE [master]
ALTER DATABASE [PlantApp] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
RESTORE DATABASE [PlantApp] FROM  DISK = N'D:\Facultad\TFI\Project\PlantApplication\Backup & Restore\Backups\PlantApp - Database Backup.bak' WITH  NOUNLOAD,  STATS = 5
ALTER DATABASE [PlantApp] SET MULTI_USER

GO
