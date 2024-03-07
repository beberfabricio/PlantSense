del ".\Backups\PlantApp - Database Backup.bak"
sqlcmd -S .\SQLEXPRESS -i ".\scripts\BackupPlantApp.sql"