exec sp_actions_add 'Don de médicaments'
exec sp_actions_getAll
exec sp_actions_getById 1
exec sp_actions_update 1, 'Don de médocs'
exec sp_actions_getAll
exec sp_actions_delete 1

exec sp_associations_add 'ALEFS' ,'Makiche',2,2
exec sp_associations_delete 3
exec sp_associations_getAll
exec sp_associations_getById 2
exec sp_associations_update 2,'ALEFS', 'Nonow',2,2

exec sp_choosenCountryYears_add 3,2024
exec sp_choosenCountryYears_getAll
exec sp_choosenCountryYears_update 3,2024 ,2026
exec sp_choosenCountryYears_getByYear 2026
exec sp_choosenCountryYears_delete 3 ,2026

exec sp_country_getAll
exec sp_country_getById 11
exec sp_country_getByIsoCode NML
exec sp_country_add 'NomacLand', 'NML'
exec sp_country_update 242, 'NomakLand',NML
exec sp_country_delete 242