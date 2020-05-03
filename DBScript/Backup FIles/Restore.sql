USE [master]
RESTORE DATABASE [MerkFinance] FROM 
	DISK = N'd:\01 Work\02 Programming Work\StepMarket1.4\DBScript\Backup FIles\MerkFinance_20190822_01.bak' WITH FILE = 1,
	MOVE N'MerkFinance' TO N'd:\01 Work\02 Programming Work\DataBases_Backups\1\MerkFinance.mdf',
	MOVE N'MerkFinance_log' TO N'd:\01 Work\02 Programming Work\DataBases_Backups\1\MerkFinance.ldf',
	NOUNLOAD, REPLACE,  STATS = 5
GO
