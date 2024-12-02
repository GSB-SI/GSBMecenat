# Architecture Applicative de l'Application ProGestionGSB (Windows Forms)

## Structure du projet

L'architecture de l'application ProGestionGSB est répartie en différentes couches, chacune ayant une responsabilité bien définie. Voici une description détaillée de chaque couche et de son contenu.

---

## 1. **ProGestionGSB.BLL (Business Logic Layer)**

Cette couche contient la logique métier de l'application, responsable de la gestion des entités métiers telles que les actions, les associations, les pays, les utilisateurs, etc.

### Fichiers principaux :

- **ActionManager.cs** : Gère les actions dans l'application.
- **AssociationManager.cs** : Gère les associations.
- **BudgetManager.cs** : Gère les budgets.
- **ChoosenCountryYearsManager.cs** : Gère les années des pays choisis.
- **CountryManager.cs** : Gère les pays.
- **IndicatorManager.cs** : Gère les indicateurs.
- **MissionManager.cs** : Gère les missions.
- **PartnershipManager.cs** : Gère les partenariats.
- **RoleManager.cs** : Gère les rôles des utilisateurs.
- **UserManager.cs** : Gère les utilisateurs.

---

## 2. **ProGestionGSB.BO (Business Object Layer)**

La couche BO (Business Object) contient les objets métiers qui sont utilisés dans la logique métier (BLL) pour représenter les entités de l'application.

### Fichiers principaux :
- **Action.cs** : Objet représentant une action.
- **Association.cs** : Objet représentant une association.
- **ChoosenCountryYear.cs** : Objet représentant une année de pays choisi.
- **Country.cs** : Objet représentant un pays.
- **Indicator.cs** : Objet représentant un indicateur.
- **Mission.cs** : Objet représentant une mission.
- **Partnership.cs** : Objet représentant un partenariat.
- **Role.cs** : Objet représentant un rôle.
- **User.cs** : Objet représentant un utilisateur.

---

## 3. **ProGestionGSB.DAL (Data Access Layer)**

Cette couche est responsable de la communication avec la base de données. Elle contient les classes qui interagissent directement avec les données, comme les Data Access Objects (DAO) et les procédures stockées.

### Fichiers principaux :

- **ActionDAO.cs** : Gère les actions dans la base de données.
- **AssociationDAO.cs** : Gère les associations dans la base de données.
- **BudgetDAO.cs** : Gère les budgets dans la base de données.
- **ChoosenCountryYearsDAO.cs** : Gère les années des pays choisis dans la base de données.
- **CountryDAO.cs** : Gère les pays dans la base de données.
- **IndicatorDAO.cs** : Gère les indicateurs dans la base de données.
- **MissionDAO.cs** : Gère les missions dans la base de données.
- **PartnershipDAO.cs** : Gère les partenariats dans la base de données.
- **RoleDAO.cs** : Gère les rôles dans la base de données.
- **UserDAO.cs** : Gère les utilisateurs dans la base de données.

Les **sp_..._Result.cs** sont des objets représentant les résultats des procédures stockées dans la base de données, comme par exemple :
- **sp_actions_getAll_Result.cs** : Représente le résultat de la procédure stockée pour récupérer toutes les actions.
- **sp_associations_getById_Result.cs** : Représente le résultat de la procédure stockée pour récupérer une association par ID.

---

## 4. **ProGestionGSB.GUI (Graphical User Interface)**

La couche GUI contient tous les fichiers liés à l'interface utilisateur (Windows Forms). Elle est responsable de l'interaction avec l'utilisateur final, permettant d'afficher et de manipuler les données.

### Fichiers principaux :

- **FrmAddAssociation.cs** : Formulaire pour ajouter une association.
- **FrmAddChoosenCountryYears.cs** : Formulaire pour ajouter une année de pays choisi.
- **FrmAddPartnership.cs** : Formulaire pour ajouter un partenariat.
- **FrmAddUser.cs** : Formulaire pour ajouter un utilisateur.
- **FrmAssociations.cs** : Formulaire pour gérer les associations.
- **FrmBudgets.cs** : Formulaire pour gérer les budgets.
- **FrmChoosenCountryYears.cs** : Formulaire pour gérer les années des pays choisis.
- **FrmDeleteAssociation.cs** : Formulaire pour supprimer une association.
- **FrmDeleteChoosenCountryYears.cs** : Formulaire pour supprimer une année de pays choisi.
- **FrmDeletePartnership.cs** : Formulaire pour supprimer un partenariat.
- **FrmDeleteUser.cs** : Formulaire pour supprimer un utilisateur.
- **FrmHome.cs** : Formulaire principal d'accueil.
- **FrmIndicator.cs** : Formulaire pour gérer les indicateurs.
- **FrmLogin.cs** : Formulaire de connexion.
- **FrmPartnership.cs** : Formulaire pour gérer un partenariat.
- **FrmShowActionByAssociation.cs** : Formulaire pour afficher les actions par association.
- **FrmUpdateAssociation.cs** : Formulaire pour mettre à jour une association.
- **FrmUpdateBudget.cs** : Formulaire pour mettre à jour un budget.
- **FrmUpdateChoosenCountryYear.cs** : Formulaire pour mettre à jour une année de pays choisi.
- **FrmUpdatePartnership.cs** : Formulaire pour mettre à jour un partenariat.
- **FrmUpdateUser.cs** : Formulaire pour mettre à jour un utilisateur.
- **FrmUsers.cs** : Formulaire pour gérer les utilisateurs.

Les fichiers **Designer.cs** sont associés à la conception des formulaires, définissant les éléments visuels.

---

## 5. **ProGestionGSB.OBJ**

Ce dossier contient les fichiers générés automatiquement pendant la compilation, comme les fichiers de métadonnées ou les fichiers d'assemblage.

- **obj\Debug\...** et **obj\Release\...** : Fichiers liés aux configurations de compilation (Debug ou Release).
- **AssemblyAttributes.cs** : Fichier généré par le compilateur pour définir des attributs d'assemblage.

---

## 6. **ProGestionGSB.PROPERTIES**

Ce dossier contient les fichiers de configuration et de ressources de l'application.

### Fichiers principaux :

- **AssemblyInfo.cs** : Contient des informations sur l'assemblage, comme le nom, la version et la description.
- **Resources.Designer.cs** : Fichier généré pour gérer les ressources (images, chaînes de texte, etc.).
- **Settings.Designer.cs** : Fichier généré pour gérer les paramètres de configuration de l'application.

---

## 7. **Arborescense**
```
ProGestionGSB
    ProGestionGSB.BLL
        ActionManager.cs
        AssociationManager.cs
        BudgetManager.cs
        ChoosenCountryYearsManager.cs
        CountryManager.cs
        IndicatorManager.cs
        MissionManager.cs
        PartnershipManager.cs
        RoleManager.cs
        UserManager.cs
    
    ProGestionGSB.BO
        (Fichiers non inclus dans l'arborescence détaillée)

    ProGestionGSB.DAL
        Action.cs
        ActionDAO.cs
        Association.cs
        AssociationDAO.cs
        AssociationExt.cs
        BudgetDAO.cs
        ChoosenCountryYear.cs
        ChoosenCountryYearsDAO.cs
        ChoosenCountryYearsExt.cs
        Country.cs
        CountryDAO.cs
        GSBMecenatModel.Context.cs
        GSBMecenatModel.cs
        GSBMecenatModel.Designer.cs
        IndicatorDAO.cs
        InterventionsLog.cs
        Mission.cs
        MissionDAO.cs
        Partnership.cs
        PartnershipDAO.cs
        PartnershipExt.cs
        Role.cs
        RoleDAO.cs
        User.cs
        UserDAO.cs

    ProGestionGSB.GUI
        FrmAddAssociation.cs
        FrmAddAssociation.Designer.cs
        FrmAddChoosenCountryYears.cs
        FrmAddChoosenCountryYears.Designer.cs
        FrmAddPartnership.cs
        FrmAddPartnership.Designer.cs
        FrmAddUser.cs
        FrmAddUser.Designer.cs
        FrmAssociations.cs
        FrmAssociations.Designer.cs
        FrmBudgets.cs
        FrmBudgets.Designer.cs
        FrmChoosenCountryYears.cs
        FrmChoosenCountryYears.Designer.cs
        FrmDeleteAssociation.cs
        FrmDeleteAssociation.Designer.cs
        FrmDeleteChoosenCountryYears.cs
        FrmDeleteChoosenCountryYears.Designer.cs
        FrmDeletePartnership.cs
        FrmDeletePartnership.Designer.cs
        FrmDeleteUser.cs
        FrmDeleteUser.Designer.cs
        FrmHome.cs
        FrmHome.Designer.cs
        FrmIndicator.cs
        FrmIndicator.Designer.cs
        FrmLogin.cs
        FrmLogin.Designer.cs
        FrmPartnership.cs
        FrmPartnership.Designer.cs
        FrmShowActionByAssociation.cs
        FrmShowActionByAssociation.Designer.cs
        FrmUpdateAssociation.cs
        FrmUpdateAssociation.Designer.cs
        FrmUpdateBudget.cs
        FrmUpdateBudget.Designer.cs
        FrmUpdateChoosenCountryYear.cs
        FrmUpdateChoosenCountryYear.Designer.cs
        FrmUpdatePartnership.cs
        FrmUpdatePartnership.Designer.cs
        FrmUpdateUser.cs
        FrmUpdateUser.Designer.cs
        FrmUsers.cs
        FrmUsers.Designer.cs

    Program.cs
```

---

## Conclusion

L'application **ProGestionGSB** est organisée selon une architecture en couches classique, séparant clairement la logique métier, l'accès aux données et l'interface utilisateur. Cela permet de maintenir une structure modulaire et facilite la gestion, la maintenance et l'évolution de l'application.