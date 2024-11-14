USE ProGestion;

GO;

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
			(SELECT id FROM updated)
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

GO;

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
			(SELECT id FROM updated)
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

GO;

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
			(SELECT id FROM inserted)
		);
	END

  IF @action = 'UPDATE'
    BEGIN
		INSERT InterventionsLogs VALUES(
			@tableName,
			@action,
			(SELECT id FROM updated)
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
			(SELECT id FROM updated)
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

GO;