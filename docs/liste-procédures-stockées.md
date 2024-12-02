### **Country (Pays)**

1. **`sp_country_getAll`**  
   - **R�le :** R�cup�re toutes les lignes de la table `country` (pays).
   
2. **`sp_country_getById`**  
   - **R�le :** R�cup�re les informations d'un pays sp�cifique en fonction de son `id`.
   - **Param�tre :** `@id` (identifiant du pays).

3. **`sp_country_getByIsoCode`**  
   - **R�le :** R�cup�re les informations d'un pays bas� sur son code ISO (3 caract�res).
   - **Param�tre :** `@isoCode` (code ISO du pays).

4. **`sp_country_add`**  
   - **R�le :** Ajoute un nouveau pays � la table `country`.
   - **Param�tres :** `@name` (nom du pays), `@isoCode` (code ISO du pays).

5. **`sp_country_update`**  
   - **R�le :** Met � jour les informations d'un pays existant.
   - **Param�tres :** `@id` (identifiant du pays), `@name` (nouveau nom), `@isoCode` (nouveau code ISO).

6. **`sp_country_delete`**  
   - **R�le :** Supprime un pays de la table `country`.
   - **Param�tre :** `@id` (identifiant du pays).

---

### **Actions**

1. **`sp_actions_getAll`**  
   - **R�le :** R�cup�re toutes les actions pr�sentes dans la table `actions`.

2. **`sp_actions_getById`**  
   - **R�le :** R�cup�re une action sp�cifique bas�e sur son `id`.
   - **Param�tre :** `@id` (identifiant de l'action).

3. **`sp_actions_add`**  
   - **R�le :** Ajoute une nouvelle action dans la table `actions`.
   - **Param�tre :** `@libel` (libell� de l'action).

4. **`sp_actions_update`**  
   - **R�le :** Met � jour le libell� d'une action existante.
   - **Param�tres :** `@id` (identifiant de l'action), `@libel` (nouveau libell�).

5. **`sp_actions_delete`**  
   - **R�le :** Supprime une action de la table `actions`.
   - **Param�tre :** `@id` (identifiant de l'action).

---

### **Users (Utilisateurs)**

1. **`sp_users_getAll`**  
   - **R�le :** R�cup�re tous les utilisateurs dans la table `Users`.

2. **`sp_users_getbyId`**  
   - **R�le :** R�cup�re un utilisateur sp�cifique bas� sur son `id`.
   - **Param�tre :** `@id` (identifiant de l'utilisateur).

3. **`sp_users_getByLogin`**  
   - **R�le :** R�cup�re un utilisateur en fonction de son login.
   - **Param�tre :** `@login` (login de l'utilisateur).

4. **`sp_users_add`**  
   - **R�le :** Ajoute un nouvel utilisateur dans la table `Users`.
   - **Param�tres :** `@login` (login de l'utilisateur), `@password` (mot de passe de l'utilisateur), `@role_id` (id du r�le de l'utilisateur).

5. **`sp_users_update`**  
   - **R�le :** Met � jour les informations d'un utilisateur existant.
   - **Param�tres :** `@id` (identifiant de l'utilisateur), `@login` (nouveau login), `@password` (nouveau mot de passe), `@role_id` (nouveau r�le).

6. **`sp_users_delete`**  
   - **R�le :** Supprime un utilisateur de la table `Users`.
   - **Param�tre :** `@id` (identifiant de l'utilisateur).

---

### **Associations**

1. **`sp_associations_getAll`**  
   - **R�le :** R�cup�re toutes les associations pr�sentes dans la table `associations`.

2. **`sp_associations_getById`**  
   - **R�le :** R�cup�re une association sp�cifique bas�e sur son `id`.
   - **Param�tre :** `@id` (identifiant de l'association).

3. **`sp_associations_add`**  
   - **R�le :** Ajoute une nouvelle association dans la table `associations`.
   - **Param�tres :** `@name` (nom de l'association), `@responsable` (responsable de l'association), `@mission_id` (id de la mission), `@country_id` (id du pays).

4. **`sp_associations_update`**  
   - **R�le :** Met � jour les informations d'une association existante.
   - **Param�tres :** `@id` (identifiant de l'association), `@name` (nouveau nom), `@responsable` (nouveau responsable), `@mission_id` (nouvelle mission), `@country_id` (nouveau pays).

5. **`sp_associations_delete`**  
   - **R�le :** Supprime une association de la table `associations`.
   - **Param�tre :** `@id` (identifiant de l'association).

---

### **ChoosenCountryYears (Ann�es des pays choisis)**

1. **`sp_choosenCountryYears_getAll`**  
   - **R�le :** R�cup�re toutes les ann�es des pays choisis dans la table `ChoosenCountryYears`.

2. **`sp_choosenCountryYears_getByYear`**  
   - **R�le :** R�cup�re les ann�es des pays choisis pour une ann�e sp�cifique.
   - **Param�tre :** `@choosenYear` (ann�e choisie).

3. **`sp_choosenCountryYears_add`**  
   - **R�le :** Ajoute une nouvelle entr�e dans `ChoosenCountryYears` pour un pays et une ann�e donn�s.
   - **Param�tres :** `@country_id` (id du pays), `@choosenYear` (ann�e choisie), `@plafond` (plafond choisi).

4. **`sp_choosenCountryYears_update`**  
   - **R�le :** Met � jour l'ann�e choisie pour un pays existant.
   - **Param�tres :** `@country_id` (id du pays), `@oldChoosenYear` (ancienne ann�e), `@newChoosenYear` (nouvelle ann�e), `@plafond` (plafond choisi).

5. **`sp_choosenCountryYears_delete`**  
   - **R�le :** Supprime une entr�e de `ChoosenCountryYears` pour un pays et une ann�e donn�s.
   - **Param�tres :** `@country_id` (id du pays), `@choosenYear` (ann�e choisie).

---

### **InterventionsLogs (Journaux d'intervention)**

1. **`sp_interventionLogs_getAll`**  
   - **R�le :** R�cup�re tous les journaux d'intervention dans `InterventionsLogs`.

2. **`sp_interventionLogs_getById`**  
   - **R�le :** R�cup�re un journal d'intervention sp�cifique bas� sur son `id`.
   - **Param�tre :** `@id` (identifiant du journal).

3. **`sp_interventionLogs_getByTableName`**  
   - **R�le :** R�cup�re les journaux d'intervention pour une table sp�cifique.
   - **Param�tre :** `@tableName` (nom de la table).

4. **`sp_interventionLogs_getByOperation`**  
   - **R�le :** R�cup�re les journaux d'intervention pour une op�ration sp�cifique.
   - **Param�tre :** `@operation` (type d'op�ration).

5. **`sp_interventionLogs_getByReference`**  
   - **R�le :** R�cup�re les journaux d'intervention pour une r�f�rence donn�e.
   - **Param�tre :** `@reference` (r�f�rence d'intervention).

6. **`sp_interventionLogs_add`**  
   - **R�le :** Ajoute un nouvel enregistrement dans `InterventionsLogs`.
   - **Param�tres :** `@tableName` (nom de la table), `@operation` (type d'op�ration), `@reference` (r�f�rence).

---

### **Missions**

1. **`sp_missions_getAll`**  
   - **R�le :** R�cup�re toutes les missions dans la table `Missions`.

2. **`sp_missions_getById`**  
   - **R�le :** R�cup�re une mission sp�cifique bas�e sur son `id`.
   - **Param�tre :** `@id` (identifiant de la mission).

3. **`sp_missions_add`**  
   - **R�le :** Ajoute une nouvelle mission dans la table `Missions`.
   - **Param�tre :** `@libel` (libell� de la mission).

4. **`sp_missions_update`**  
   - **R�le :** Met � jour le libell

� d'une mission existante.
   - **Param�tres :** `@id` (identifiant de la mission), `@libel` (nouveau libell�).

5. **`sp_missions_delete`**  
   - **R�le :** Supprime une mission de la table `Missions`.
   - **Param�tre :** `@id` (identifiant de la mission).

---

### **Partnerships (Partenariats)**

1. **`sp_partnerships_getAll`**  
   - **R�le :** R�cup�re tous les partenariats dans la table `Partnerships`.

2. **`sp_partnerships_getById`**  
   - **R�le :** R�cup�re un partenariat sp�cifique bas� sur son `id`.
   - **Param�tre :** `@id` (identifiant du partenariat).

3. **`sp_partnerships_getByActionId`**  
   - **R�le :** R�cup�re les partenariats en fonction de l'`action_id`.
   - **Param�tre :** `@action_id` (identifiant de l'action).

4. **`sp_partnerships_getByAssociationId`**  
   - **R�le :** R�cup�re les partenariats en fonction de l'`association_id`.
   - **Param�tre :** `@association_id` (identifiant de l'association).

5. **`sp_partnerships_getByCountryId`**  
   - **R�le :** R�cup�re les partenariats en fonction du `country_id`.
   - **Param�tre :** `@country_id` (identifiant du pays).

6. **`sp_partnerships_add`**  
   - **R�le :** Ajoute un nouveau partenariat dans la table `Partnerships`.
   - **Param�tres :** `@action_id` (id de l'action), `@association_id` (id de l'association), `@country_id` (id du pays).

7. **`sp_partnerships_updateForecastBudget`**  
   - **R�le :** Met � jour le budget pr�visionnel d'un partenariat.
   - **Param�tres :** `@id` (id du partenariat), `@forecastBudget` (nouveau budget pr�visionnel).

8. **`sp_partnerships_updateRealBudget`**  
   - **R�le :** Met � jour le budget r�el d'un partenariat.
   - **Param�tres :** `@id` (id du partenariat), `@realBudget` (nouveau budget r�el).

9. **`sp_partnerships_update`**  
    - **R�le :** Met � jour les informations g�n�rales d'un partenariat.
    - **Param�tres :** `@id` (id du partenariat), `@action_id` (id de l'action), `@association_id` (id de l'association), `@country_id` (id du pays).

10. **`sp_partnerships_delete`**  
    - **R�le :** Supprime un partenariat de la table `Partnerships`.
    - **Param�tre :** `@id` (identifiant du partenariat).

---

### **Role (R�le)**

1. **`sp_role_getAll`**  
   - **R�le :** R�cup�re tous les r�les dans la table `Role`.

2. **`sp_role_getById`**  
   - **R�le :** R�cup�re un r�le sp�cifique bas� sur son `id`.
   - **Param�tre :** `@id` (identifiant du r�le).

3. **`sp_role_add`**  
   - **R�le :** Ajoute un nouveau r�le dans la table `Role`.
   - **Param�tre :** `@libel` (libell� du r�le).

4. **`sp_role_update`**  
   - **R�le :** Met � jour le libell� d'un r�le existant.
   - **Param�tres :** `@id` (identifiant du r�le), `@libel` (nouveau libell�).

5. **`sp_role_delete`**  
   - **R�le :** Supprime un r�le de la table `Role`.
   - **Param�tre :** `@id` (identifiant du r�le).

---

### **Indicateurs**

1. **`sp_nbAssociationByCountry`**  
   - **R�le :** R�cup�re le nombre d'associations par pays.

2. **`sp_nbPartnershipsByActionByYear`**  
   - **R�le :** R�cup�re le nombre de partenariats par action et par ann�e.

3. **`sp_ActionsByAssociation`**  
   - **R�le :** R�cup�re les actions associ�es � une association sp�cifique.