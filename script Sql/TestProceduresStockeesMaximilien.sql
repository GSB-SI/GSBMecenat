EXEC sp_interventionLogs_add 'Actions', 'INSERT', 1
EXEC sp_interventionLogs_getAll
EXEC sp_interventionLogs_getById 4
EXEC sp_interventionLogs_getByOperation 'UPDATE'
EXEC sp_interventionLogs_getByReference 1
EXEC sp_interventionLogs_getByTableName 'Actions'

EXEC sp_missions_add 'Nourrire Nolan'
EXEC sp_missions_delete 1
EXEC sp_missions_getAll
EXEC sp_missions_getById 1
EXEC sp_missions_update 2, 'Nourrie Nolan et Nathan'

EXEC sp_nbAssociationByCountry
EXEC sp_nbPartnershipsByActionByYear

EXEC sp_partnerships_add 1, 2, 1
EXEC sp_partnerships_delete 1
EXEC sp_partnerships_getAll
EXEC sp_partnerships_getByActionId 1
EXEC sp_partnerships_getByAssociationId 2
EXEC sp_partnerships_getByCountryId 1
EXEC sp_partnerships_getById 1
EXEC sp_partnerships_update 1, 1, 2, 1
EXEC sp_partnerships_updateForecastBudget 1, 500000.0
EXEC sp_partnerships_updatePlafond 1,6000000.0
EXEC sp_partnerships_updateRealBudget 1, 70000000.0

EXEC sp_role_add 'Administrateur'
EXEC sp_role_delete 1
EXEC sp_role_getAll
EXEC sp_role_getById 1
EXEC sp_role_update 1, 'Admin'

EXEC sp_users_add 'eleve', 'elevepsw', 2
EXEC sp_users_delete 1
EXEC sp_users_getAll
EXEC sp_users_getbyId 2
EXEC sp_users_update 2, 'eleve2', 'eleve2psw', 2