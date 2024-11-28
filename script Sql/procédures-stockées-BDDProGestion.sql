--Country

create  procedure sp_country_getAll
as
begin
	select * from country
end
go

create  procedure sp_country_getById (@id int)
as
begin
	select * from country where id = @id
end
go

create  procedure sp_country_getByIsoCode (@isoCode varchar(3))
as
begin
	select * from country where isoCode = @isoCode
end
go

create  procedure sp_country_add ( @name varchar(40), @isoCode varchar(3))
as
begin
	insert into country(name,isoCode) values(@name,@isoCode)
end
go

create  procedure sp_country_update (@id int, @name varchar(40), @isoCode varchar(3))
as
begin
	update country set name=@name , isoCode=@isoCode where id = @id
end
go

create  procedure sp_country_delete (@id int)
as
begin
	delete from country where id = @id
end
go

-- Actions

create  procedure sp_actions_getAll 
as
begin
	select * from actions
end
go

create  procedure sp_actions_getById (@id int)
as
begin
	select * from actions where id=@id
end
go

create procedure sp_actions_add( @libel varchar(40))
as
begin
	insert into actions(libel) values(@libel)
end
go

create procedure sp_actions_update(@id int, @libel varchar(40))
as
begin
	update actions set libel=@libel where id=@id
end
go

create procedure sp_actions_delete(@id int)
as
begin
	delete from actions where id=@id
end
go

--Users 

create procedure sp_users_getAll
as
begin
	Select * from Users
end
go

create procedure sp_users_getbyId(@id int)
as
begin
	Select * from Users where id=@id
end
go

create procedure sp_users_getByLogin(@login varchar(40))
as
begin
	Select * from Users  where login=@login
end
go

create procedure sp_users_add( @login varchar(40),@password varchar(40),@role_id int)
as
begin
	insert into Users(login,password,role_id) values (@login,@password,@role_id)
end
go

create procedure sp_users_update(@id int, @login varchar(40),@password varchar(40),@role_id int)
as
begin
	update Users set login = @login , password = @password , role_id = @role_id where id = @id
end
go

create procedure sp_users_delete(@id int)
as
begin
	delete from Users where id = @id
end
go

-- Associations

create procedure sp_associations_getAll
as
begin
	Select * from associations
end
go

create procedure sp_associations_getById(@id int)
as
begin
	Select * from associations where id=@id
end
go

create procedure sp_associations_add( @name varchar(40),@responsable varchar(40), @mission_id int, @country_id int)
as
begin
	insert into associations(name,responsable,mission_id,country_id) values(@name, @responsable, @mission_id, @country_id)
end
go

create procedure sp_associations_update(@id int, @name varchar(40), @responsable varchar(40), @mission_id int, @country_id int)
as
begin
	update associations set name=@name,responsable=@responsable, mission_id=@mission_id, country_id=@country_id where id=@id
end
go

create procedure sp_associations_delete(@id int)
as
begin
	delete from Associations where id=@id
end
go

-- ChoosenCountryYears
create procedure sp_choosenCountryYears_getAll
as
begin
	Select * from ChoosenCountryYears
end
go

create procedure sp_choosenCountryYears_getByYear (@choosenYear int)
as
begin
	Select * from ChoosenCountryYears where choosenYear=@choosenYear
end
go

create procedure sp_choosenCountryYears_add(@country_id int, @choosenYear int,@plafond float)
as
begin
	insert into ChoosenCountryYears values(@country_id,@choosenYear,@plafond)
end
go

create procedure sp_choosenCountryYears_update(@oldcountry_id int,@newcountry_id int,  @oldChoosenYear int, @newChoosenYear int, @plafond float)
as
begin
	update ChoosenCountryYears set choosenYear=@newChoosenYear,country_id=@newcountry_id, plafond=@plafond where country_id=@oldcountry_id and choosenYear=@oldChoosenYear
end
go

create procedure sp_choosenCountryYears_delete(@country_id int, @choosenYear int)
as
begin
	delete from ChoosenCountryYears where country_id=@country_id and choosenYear=@choosenYear
end
go

-- InterventionsLogs

create procedure sp_interventionLogs_getAll
as
begin
	Select * from InterventionsLogs
end
go

create procedure sp_interventionLogs_getById(@id int)
as
begin
	Select * from InterventionsLogs where id=@id
end
go

create procedure sp_interventionLogs_getByTableName(@tableName varchar(40))
as
begin
	Select * from InterventionsLogs where tableName=@tableName
end
go

create procedure sp_interventionLogs_getByOperation(@operation varchar(6))
as
begin
	Select * from InterventionsLogs where operation=@operation
end
go

create procedure sp_interventionLogs_getByReference(@reference int)
as
begin
	Select * from InterventionsLogs where reference=@reference
end
go

create procedure sp_interventionLogs_add(@tableName varchar(40), @operation varchar(6), @reference int)
as
begin
	Insert into InterventionsLogs(tableName,operation,reference) values (@tableName, @operation, @reference)
end
go

-- Missions

create procedure sp_missions_getAll
as
begin
	Select * from Missions
end
go

create procedure sp_missions_getById(@id int)
as
begin
	Select * from Missions where id=@id
end
go

create procedure sp_missions_add(@libel varchar(40))
as
begin
	Insert into Missions(libel) values (@libel)
end
go

create procedure sp_missions_update(@id int, @libel varchar(40))
as
begin
	update Missions set libel=@libel where id=@id
end
go

create procedure sp_missions_delete(@id int)
as
begin
	delete from Missions where id=@id
end
go

-- Partnerships

create procedure sp_partnerships_getAll
as
begin
	Select * from Partnerships
end
go

create procedure sp_partnerships_getById(@id int)
as
begin
	Select * from Partnerships where id=@id
end
go

create procedure sp_partnerships_getByActionId(@action_id int)
as
begin
	Select * from Partnerships where action_id=@action_id
end
go

create procedure sp_partnerships_getByAssociationId(@association_id int)
as
begin
	Select * from Partnerships where association_id=@association_id
end
go

create procedure sp_partnerships_getByCountryId(@country_id int)
as
begin
	Select * from Partnerships where country_id=@country_id
end
go

create procedure sp_partnerships_add(@action_id int, @association_id int, @country_id int)
as
begin
	insert into Partnerships(date, action_id, association_id, country_id) values(getdate(), @action_id, @association_id, @country_id)
end
go

create procedure sp_partnerships_updateForecastBudget(@id int,@forecastBudget float)
as
begin
	update Partnerships set  forecastBudget=@forecastBudget where id=@id
end
go

create procedure sp_partnerships_updateRealBudget(@id int,@realBudget float)
as
begin
	update Partnerships set  realBudget=@realBudget where id=@id
end
go

create procedure sp_partnerships_update(@id int,@action_id int, @association_id int, @country_id int)
as
begin
	update Partnerships set  action_id=@action_id, association_id=@association_id, country_id=@country_id where id=@id
end
go

create procedure sp_partnerships_delete(@id int)
as
begin
	delete from Partnerships where id=@id
end
go

-- Role
create procedure sp_role_getAll
as
begin
	Select * from Role
end
go

create procedure sp_role_getById(@id int)
as
begin
	Select * from Role where id=@id
end
go

create procedure sp_role_add(@libel varchar(40))
as
begin
	insert into Role(libel) values(@libel)
end
go

create procedure sp_role_update(@id int, @libel varchar(40))
as
begin
	update Role set libel=@libel where id=@id
end
go

create procedure sp_role_delete(@id int)
as
begin
	delete from role where id=@id
end
go

-- Indicateurs

create procedure sp_nbAssociationByCountry
as
begin
	select country.name,count(country_id) as Number from Country 
	join Associations on country_id = Country.id
	group by Country.name
	having count(country_id) > 0
end
go

create procedure sp_nbPartnershipsByActionByYear
as
begin
	select libel,ChoosenCountryYears.choosenYear as year,count(Partnerships.id) as nbPartnerships
	from Partnerships
	join Actions on action_id=Actions.id
	join Country on Country.id = country_id
	join ChoosenCountryYears on Country.id=ChoosenCountryYears.country_id
	group by libel,ChoosenCountryYears.choosenYear
end
go

create procedure sp_ActionsByAssociation(@idAssociation int)
as
begin
	select distinct libel 
	from Actions 
	join Partnerships on Partnerships.action_id=Actions.id 
	where association_id=@idAssociation ;
end
go
