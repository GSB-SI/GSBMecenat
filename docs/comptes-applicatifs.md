# Documentation des Comptes Applicatifs et de leurs Permissions

## Introduction

Cette documentation décrit les comptes applicatifs, les rôles et leurs permissions au sein du projet Windows Form. Le but est de clarifier les différentes fonctionnalités disponibles pour chaque rôle utilisateur et de définir les privilèges spécifiques en fonction des responsabilités attribuées.

## Rôles et Privilèges

### 1. **Rôle Directeur Partenariat et Communication**
Ce rôle est responsable de la gestion des plafonds de mécénat.

**Privilèges associés :**
- Saisie des **plafonds de mécénat** : Le directeur partenariat et communication est le seul habilité à saisir les plafonds de mécénat dans le système.

### 2. **Rôle Directeur du Service Financier**
Ce rôle est responsable de la gestion du budget d’un partenariat.

**Privilèges associés :**
- Saisie du **budget réel** d'un partenariat : Seul le directeur du service financier peut saisir et gérer le budget réel pour chaque partenariat.

### 3. **Rôle Utilisateur**
Les utilisateurs de ce rôle ont accès aux fonctionnalités générales de gestion des données et de consultation, à l'exception des actions administratives et de gestion des budgets spécifiques.

**Privilèges associés :**
- **Consultation et gestion** des partenariats, associations, et actions de mécénat.
- Accès aux **indicateurs** de mécénat.
- Gestion des **associations** et des **partenariats** (ajouter, modifier, supprimer).
- Consultation du **budget prévisionnel** des partenariats.
- Consultation des **actions de mécénat**.

### 4. **Rôle Administrateur**
L'administrateur a un accès complet à toutes les fonctionnalités et est le seul habilité à gérer les utilisateurs.

**Privilèges associés :**
- **Gestion des utilisateurs** : L’administrateur peut ajouter, modifier et supprimer des comptes utilisateurs, ainsi que définir leurs rôles et permissions.
- **Accès complet** aux fonctionnalités de l'application.

---

## Fonctionnalités

### 1. **Authentification**
Tous les utilisateurs doivent s'authentifier à l'application via un processus de connexion sécurisé. Le système de gestion des comptes garantit que seuls les utilisateurs avec des rôles définis auront accès aux fonctionnalités qui leur sont attribuées.

### 2. **CRUD Utilisateurs**
Le rôle **Administrateur** est responsable de la gestion des utilisateurs :
- Création, lecture, mise à jour et suppression des utilisateurs.
- Attribution des rôles (utilisateur, administrateur, etc.) et des permissions associées.

### 3. **CRUD Associations**
Les utilisateurs ayant le rôle approprié (administrateur, utilisateur) peuvent :
- Ajouter de nouvelles associations.
- Modifier ou supprimer des associations existantes.
- Consulter les détails des associations.

### 4. **CRUD Partenariats**
Les utilisateurs peuvent gérer les partenariats sous certaines conditions :
- **Ajout, modification et suppression** de partenariats.
- Consultation du **budget réel** et **budget prévisionnel** des partenariats (accessible selon le rôle).
- Seul le **Directeur du Service Financier** peut modifier le budget réel d’un partenariat.

### 5. **CRUD Plafond du Mécénat**
Cette fonctionnalité permet de gérer les plafonds de mécénat :
- Seul le **Directeur Partenariat et Communication** peut ajouter ou modifier les plafonds de mécénat.

### 6. **Liste des Actions de Mécénat**
Tous les utilisateurs peuvent consulter les actions de mécénat existantes dans l’application :
- Liste complète des actions de mécénat.
- Accès à des informations spécifiques concernant chaque action de mécénat (par exemple : bénéficiaire, montant, date de l’action).

### 7. **Indicateurs**
Les indicateurs de mécénat sont accessibles à tous les utilisateurs pour consulter les statistiques et l'état des actions en cours :
- Indicateurs clés sur le financement des actions.
- Visualisation des tendances et des performances des mécénats réalisés.

---

## Table des Permissions par Rôle

| Fonctionnalité                         | Directeur Partenariat et Communication | Directeur Service Financier | Utilisateur | Administrateur |
|----------------------------------------|--------------------------------------|-----------------------------|-------------|----------------|
| Authentification                       | ✔️                                   | ✔️                          | ✔️          | ✔️             |
| CRUD Utilisateurs                      | ❌                                   | ❌                          | ❌          | ✔️             |
| CRUD Associations                      | ✔️                                   | ✔️                          | ✔️          | ✔️             |
| CRUD Partenariats                      | ✔️                                   | ✔️                          | ✔️          | ✔️             |
| Budget Réel Partenariat                | ❌                                   | ✔️                          | ❌          | ✔️             |
| Budget Prévisionnel Partenariat        | ✔️                                   | ✔️                          | ✔️          | ✔️             |
| CRUD Plafond de Mécénat                | ✔️                                   | ❌                          | ❌          | ✔️             |
| Liste des Actions de Mécénat           | ✔️                                   | ✔️                          | ✔️          | ✔️             |
| Indicateurs                            | ✔️                                   | ✔️                          | ✔️          | ✔️             |

---

## Conclusion

Ce document résume les rôles, les permissions et les fonctionnalités accessibles aux utilisateurs de l’application Windows Form. Chaque rôle possède des privilèges distincts, avec des restrictions d’accès précises pour garantir une gestion sécurisée des données sensibles, telles que les plafonds de mécénat et les budgets réels des partenariats.