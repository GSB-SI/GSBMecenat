### **Country (Pays)**

1. **`sp_country_getAll`**  
   - **Rôle :** Récupère toutes les lignes de la table `country` (pays).
   
2. **`sp_country_getById`**  
   - **Rôle :** Récupère les informations d'un pays spécifique en fonction de son `id`.
   - **Paramètre :** `@id` (identifiant du pays).

3. **`sp_country_getByIsoCode`**  
   - **Rôle :** Récupère les informations d'un pays basé sur son code ISO (3 caractères).
   - **Paramètre :** `@isoCode` (code ISO du pays).

4. **`sp_country_add`**  
   - **Rôle :** Ajoute un nouveau pays à la table `country`.
   - **Paramètres :** `@name` (nom du pays), `@isoCode` (code ISO du pays).

5. **`sp_country_update`**  
   - **Rôle :** Met à jour les informations d'un pays existant.
   - **Paramètres :** `@id` (identifiant du pays), `@name` (nouveau nom), `@isoCode` (nouveau code ISO).

6. **`sp_country_delete`**  
   - **Rôle :** Supprime un pays de la table `country`.
   - **Paramètre :** `@id` (identifiant du pays).

---

### **Actions**

1. **`sp_actions_getAll`**  
   - **Rôle :** Récupère toutes les actions présentes dans la table `actions`.

2. **`sp_actions_getById`**  
   - **Rôle :** Récupère une action spécifique basée sur son `id`.
   - **Paramètre :** `@id` (identifiant de l'action).

3. **`sp_actions_add`**  
   - **Rôle :** Ajoute une nouvelle action dans la table `actions`.
   - **Paramètre :** `@libel` (libellé de l'action).

4. **`sp_actions_update`**  
   - **Rôle :** Met à jour le libellé d'une action existante.
   - **Paramètres :** `@id` (identifiant de l'action), `@libel` (nouveau libellé).

5. **`sp_actions_delete`**  
   - **Rôle :** Supprime une action de la table `actions`.
   - **Paramètre :** `@id` (identifiant de l'action).

---

### **Users (Utilisateurs)**

1. **`sp_users_getAll`**  
   - **Rôle :** Récupère tous les utilisateurs dans la table `Users`.

2. **`sp_users_getbyId`**  
   - **Rôle :** Récupère un utilisateur spécifique basé sur son `id`.
   - **Paramètre :** `@id` (identifiant de l'utilisateur).

3. **`sp_users_getByLogin`**  
   - **Rôle :** Récupère un utilisateur en fonction de son login.
   - **Paramètre :** `@login` (login de l'utilisateur).

4. **`sp_users_add`**  
   - **Rôle :** Ajoute un nouvel utilisateur dans la table `Users`.
   - **Paramètres :** `@login` (login de l'utilisateur), `@password` (mot de passe de l'utilisateur), `@role_id` (id du rôle de l'utilisateur).

5. **`sp_users_update`**  
   - **Rôle :** Met à jour les informations d'un utilisateur existant.
   - **Paramètres :** `@id` (identifiant de l'utilisateur), `@login` (nouveau login), `@password` (nouveau mot de passe), `@role_id` (nouveau rôle).

6. **`sp_users_delete`**  
   - **Rôle :** Supprime un utilisateur de la table `Users`.
   - **Paramètre :** `@id` (identifiant de l'utilisateur).

---

### **Associations**

1. **`sp_associations_getAll`**  
   - **Rôle :** Récupère toutes les associations présentes dans la table `associations`.

2. **`sp_associations_getById`**  
   - **Rôle :** Récupère une association spécifique basée sur son `id`.
   - **Paramètre :** `@id` (identifiant de l'association).

3. **`sp_associations_add`**  
   - **Rôle :** Ajoute une nouvelle association dans la table `associations`.
   - **Paramètres :** `@name` (nom de l'association), `@responsable` (responsable de l'association), `@mission_id` (id de la mission), `@country_id` (id du pays).

4. **`sp_associations_update`**  
   - **Rôle :** Met à jour les informations d'une association existante.
   - **Paramètres :** `@id` (identifiant de l'association), `@name` (nouveau nom), `@responsable` (nouveau responsable), `@mission_id` (nouvelle mission), `@country_id` (nouveau pays).

5. **`sp_associations_delete`**  
   - **Rôle :** Supprime une association de la table `associations`.
   - **Paramètre :** `@id` (identifiant de l'association).

---

### **ChoosenCountryYears (Années des pays choisis)**

1. **`sp_choosenCountryYears_getAll`**  
   - **Rôle :** Récupère toutes les années des pays choisis dans la table `ChoosenCountryYears`.

2. **`sp_choosenCountryYears_getByYear`**  
   - **Rôle :** Récupère les années des pays choisis pour une année spécifique.
   - **Paramètre :** `@choosenYear` (année choisie).

3. **`sp_choosenCountryYears_add`**  
   - **Rôle :** Ajoute une nouvelle entrée dans `ChoosenCountryYears` pour un pays et une année donnés.
   - **Paramètres :** `@country_id` (id du pays), `@choosenYear` (année choisie), `@plafond` (plafond choisi).

4. **`sp_choosenCountryYears_update`**  
   - **Rôle :** Met à jour l'année choisie pour un pays existant.
   - **Paramètres :** `@country_id` (id du pays), `@oldChoosenYear` (ancienne année), `@newChoosenYear` (nouvelle année), `@plafond` (plafond choisi).

5. **`sp_choosenCountryYears_delete`**  
   - **Rôle :** Supprime une entrée de `ChoosenCountryYears` pour un pays et une année donnés.
   - **Paramètres :** `@country_id` (id du pays), `@choosenYear` (année choisie).

---

### **InterventionsLogs (Journaux d'intervention)**

1. **`sp_interventionLogs_getAll`**  
   - **Rôle :** Récupère tous les journaux d'intervention dans `InterventionsLogs`.

2. **`sp_interventionLogs_getById`**  
   - **Rôle :** Récupère un journal d'intervention spécifique basé sur son `id`.
   - **Paramètre :** `@id` (identifiant du journal).

3. **`sp_interventionLogs_getByTableName`**  
   - **Rôle :** Récupère les journaux d'intervention pour une table spécifique.
   - **Paramètre :** `@tableName` (nom de la table).

4. **`sp_interventionLogs_getByOperation`**  
   - **Rôle :** Récupère les journaux d'intervention pour une opération spécifique.
   - **Paramètre :** `@operation` (type d'opération).

5. **`sp_interventionLogs_getByReference`**  
   - **Rôle :** Récupère les journaux d'intervention pour une référence donnée.
   - **Paramètre :** `@reference` (référence d'intervention).

6. **`sp_interventionLogs_add`**  
   - **Rôle :** Ajoute un nouvel enregistrement dans `InterventionsLogs`.
   - **Paramètres :** `@tableName` (nom de la table), `@operation` (type d'opération), `@reference` (référence).

---

### **Missions**

1. **`sp_missions_getAll`**  
   - **Rôle :** Récupère toutes les missions dans la table `Missions`.

2. **`sp_missions_getById`**  
   - **Rôle :** Récupère une mission spécifique basée sur son `id`.
   - **Paramètre :** `@id` (identifiant de la mission).

3. **`sp_missions_add`**  
   - **Rôle :** Ajoute une nouvelle mission dans la table `Missions`.
   - **Paramètre :** `@libel` (libellé de la mission).

4. **`sp_missions_update`**  
   - **Rôle :** Met à jour le libell

é d'une mission existante.
   - **Paramètres :** `@id` (identifiant de la mission), `@libel` (nouveau libellé).

5. **`sp_missions_delete`**  
   - **Rôle :** Supprime une mission de la table `Missions`.
   - **Paramètre :** `@id` (identifiant de la mission).

---

### **Partnerships (Partenariats)**

1. **`sp_partnerships_getAll`**  
   - **Rôle :** Récupère tous les partenariats dans la table `Partnerships`.

2. **`sp_partnerships_getById`**  
   - **Rôle :** Récupère un partenariat spécifique basé sur son `id`.
   - **Paramètre :** `@id` (identifiant du partenariat).

3. **`sp_partnerships_getByActionId`**  
   - **Rôle :** Récupère les partenariats en fonction de l'`action_id`.
   - **Paramètre :** `@action_id` (identifiant de l'action).

4. **`sp_partnerships_getByAssociationId`**  
   - **Rôle :** Récupère les partenariats en fonction de l'`association_id`.
   - **Paramètre :** `@association_id` (identifiant de l'association).

5. **`sp_partnerships_getByCountryId`**  
   - **Rôle :** Récupère les partenariats en fonction du `country_id`.
   - **Paramètre :** `@country_id` (identifiant du pays).

6. **`sp_partnerships_add`**  
   - **Rôle :** Ajoute un nouveau partenariat dans la table `Partnerships`.
   - **Paramètres :** `@action_id` (id de l'action), `@association_id` (id de l'association), `@country_id` (id du pays).

7. **`sp_partnerships_updateForecastBudget`**  
   - **Rôle :** Met à jour le budget prévisionnel d'un partenariat.
   - **Paramètres :** `@id` (id du partenariat), `@forecastBudget` (nouveau budget prévisionnel).

8. **`sp_partnerships_updateRealBudget`**  
   - **Rôle :** Met à jour le budget réel d'un partenariat.
   - **Paramètres :** `@id` (id du partenariat), `@realBudget` (nouveau budget réel).

9. **`sp_partnerships_update`**  
    - **Rôle :** Met à jour les informations générales d'un partenariat.
    - **Paramètres :** `@id` (id du partenariat), `@action_id` (id de l'action), `@association_id` (id de l'association), `@country_id` (id du pays).

10. **`sp_partnerships_delete`**  
    - **Rôle :** Supprime un partenariat de la table `Partnerships`.
    - **Paramètre :** `@id` (identifiant du partenariat).

---

### **Role (Rôle)**

1. **`sp_role_getAll`**  
   - **Rôle :** Récupère tous les rôles dans la table `Role`.

2. **`sp_role_getById`**  
   - **Rôle :** Récupère un rôle spécifique basé sur son `id`.
   - **Paramètre :** `@id` (identifiant du rôle).

3. **`sp_role_add`**  
   - **Rôle :** Ajoute un nouveau rôle dans la table `Role`.
   - **Paramètre :** `@libel` (libellé du rôle).

4. **`sp_role_update`**  
   - **Rôle :** Met à jour le libellé d'un rôle existant.
   - **Paramètres :** `@id` (identifiant du rôle), `@libel` (nouveau libellé).

5. **`sp_role_delete`**  
   - **Rôle :** Supprime un rôle de la table `Role`.
   - **Paramètre :** `@id` (identifiant du rôle).

---

### **Indicateurs**

1. **`sp_nbAssociationByCountry`**  
   - **Rôle :** Récupère le nombre d'associations par pays.

2. **`sp_nbPartnershipsByActionByYear`**  
   - **Rôle :** Récupère le nombre de partenariats par action et par année.

3. **`sp_ActionsByAssociation`**  
   - **Rôle :** Récupère les actions associées à une association spécifique.