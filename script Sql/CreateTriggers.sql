CREATE TRIGGER tr_logs_missions ON Missions
FOR INSERT, UPDATE, DELETE
AS
BEGIN
  SET NOCOUNT ON;
    
  DECLARE @action CHAR(6);
  DECLARE @tableName CHAR(20);

  SELECT @action  = 'DELETE';
  SELECT @tableName  = 'Missions';
    
  IF EXISTS (SELECT 1 FROM inserted)
  BEGIN
    IF EXISTS (SELECT 1 FROM deleted)
      SET @action = 'UPDATE';
    ELSE
      SET @action = 'INSERT';
  END
        
  IF @action = 'INSERT'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'UPDATE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'DELETE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM deleted)
		);
	END
END

GO

CREATE TRIGGER tr_logs_country ON Country
FOR INSERT, UPDATE, DELETE
AS
BEGIN
  SET NOCOUNT ON;
    
  DECLARE @action CHAR(6);
  DECLARE @tableName CHAR(20);

  SELECT @action  = 'DELETE';
  SELECT @tableName  = 'Country';
    
  IF EXISTS (SELECT 1 FROM inserted)
  BEGIN
    IF EXISTS (SELECT 1 FROM deleted)
      SET @action = 'UPDATE';
    ELSE
      SET @action = 'INSERT';
  END
        
  IF @action = 'INSERT'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'UPDATE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'DELETE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM deleted)
		);
	END
END

GO

CREATE TRIGGER tr_logs_choosen_country_years ON ChoosenCountryYears
FOR INSERT, UPDATE, DELETE
AS
BEGIN
  SET NOCOUNT ON;
    
  DECLARE @action CHAR(6);
  DECLARE @tableName CHAR(20);

  SELECT @action  = 'DELETE';
  SELECT @tableName  = 'ChoosenCountryYears';
    
  IF EXISTS (SELECT 1 FROM inserted)
  BEGIN
    IF EXISTS (SELECT 1 FROM deleted)
      SET @action = 'UPDATE';
    ELSE
      SET @action = 'INSERT';
  END
        
  IF @action = 'INSERT'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT CONCAT(country_id, choosenYear) AS id FROM inserted)
		);
	END

  IF @action = 'UPDATE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT  CONCAT(country_id, choosenYear) AS id FROM inserted)
		);
	END

  IF @action = 'DELETE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT  CONCAT(country_id, choosenYear) AS id FROM deleted)
		);
	END
END

GO

CREATE TRIGGER tr_logs_actions ON Actions
FOR INSERT, UPDATE, DELETE
AS
BEGIN
  SET NOCOUNT ON;
    
  DECLARE @action CHAR(6);
  DECLARE @tableName CHAR(20);

  SELECT @action  = 'DELETE';
  SELECT @tableName  = 'Actions';
    
  IF EXISTS (SELECT 1 FROM inserted)
  BEGIN
    IF EXISTS (SELECT 1 FROM deleted)
      SET @action = 'UPDATE';
    ELSE
      SET @action = 'INSERT';
  END
        
  IF @action = 'INSERT'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'UPDATE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'DELETE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM deleted)
		);
	END
END

GO

CREATE TRIGGER tr_logs_associations ON Associations
FOR INSERT, UPDATE, DELETE
AS
BEGIN
  SET NOCOUNT ON;
    
  DECLARE @action CHAR(6);
  DECLARE @tableName CHAR(20);

  SELECT @action  = 'DELETE';
  SELECT @tableName  = 'Associations';
    
  IF EXISTS (SELECT 1 FROM inserted)
  BEGIN
    IF EXISTS (SELECT 1 FROM deleted)
      SET @action = 'UPDATE';
    ELSE
      SET @action = 'INSERT';
  END
        
  IF @action = 'INSERT'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'UPDATE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'DELETE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM deleted)
		);
	END
END

GO

CREATE TRIGGER tr_logs_partnerships ON Partnerships
FOR INSERT, UPDATE, DELETE
AS
BEGIN
  SET NOCOUNT ON;
    
  DECLARE @action CHAR(6);
  DECLARE @tableName CHAR(20);

  SELECT @action  = 'DELETE';
  SELECT @tableName  = 'Partnerships';
    
  IF EXISTS (SELECT 1 FROM inserted)
  BEGIN
    IF EXISTS (SELECT 1 FROM deleted)
      SET @action = 'UPDATE';
    ELSE
      SET @action = 'INSERT';
  END
        
  IF @action = 'INSERT'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'UPDATE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'DELETE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM deleted)
		);
	END
END

GO

CREATE TRIGGER tr_logs_role ON Role
FOR INSERT, UPDATE, DELETE
AS
BEGIN
  SET NOCOUNT ON;
    
  DECLARE @action CHAR(6);
  DECLARE @tableName CHAR(20);

  SELECT @action  = 'DELETE';
  SELECT @tableName  = 'Role';
    
  IF EXISTS (SELECT 1 FROM inserted)
  BEGIN
    IF EXISTS (SELECT 1 FROM deleted)
      SET @action = 'UPDATE';
    ELSE
      SET @action = 'INSERT';
  END
        
  IF @action = 'INSERT'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'UPDATE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'DELETE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM deleted)
		);
	END
END

GO

CREATE TRIGGER tr_logs_users ON Users
FOR INSERT, UPDATE, DELETE
AS
BEGIN
  SET NOCOUNT ON;
    
  DECLARE @action CHAR(6);
  DECLARE @tableName CHAR(20);

  SELECT @action  = 'DELETE';
  SELECT @tableName  = 'Users';
    
  IF EXISTS (SELECT 1 FROM inserted)
  BEGIN
    IF EXISTS (SELECT 1 FROM deleted)
      SET @action = 'UPDATE';
    ELSE
      SET @action = 'INSERT';
  END
        
  IF @action = 'INSERT'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'UPDATE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'DELETE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM deleted)
		);
	END
END