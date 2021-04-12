# GestionHotelsAvecWebServicesRest

HMIN 210, Service web Rest, Version distribuée-Comparateur d'Agence de voyage et hôtels.

# Création et Utilisation de Services Web REST

Ce dépot est [une suite de celui lié au service web SOAP](https://gitlab.com/kaciahmed3/gestionhoteldistribueparagencedevoyage) (même conception métier)

# Objectif :

Développer en C# une application de réservation d’hôtels en ligne.
Cette application propose une interface permettant à un utilisateur de saisir les informations suivantes : Une ville de séjour, une date d’arrivée, une date de départ, un intervalle de prix souhaité, une catégorie d’hôtel : nombre d’étoiles, le nombre de personnes à héberger.

En réponse, l’application lui retourne une liste d’hôtels qui répondent à ses critères et où pour chaque hôtel les informations suivantes sont affichées : nom de l’hôtel, adresse de l’hôtel (pays, ville, rue, numéro, lieu-dit, position GPS), le prix à payer, nombre d’étoile, nombre de lits proposés. L’utilisateur choisira un hôtel dans la liste proposée et l’application lui  demandera les informations suivantes : le nom et prénom de la personne principale à héberger, les informations de la carte de crédit de paiement. L’application utilisera ces informations pour réaliser la réservation de l’hôtel en question.

## Version distribuée-Agence de voyage et hôtels

* Proposez une version distribuée de l’application Agence de voyage sans base de données où :
    * La réservation d’hôtels se fait via une agence de voyage qui accède aux données des hôtels via leurs services web respectifs. Les prix proposés par les hôtels peuvent être adaptés en fonction des agences (les agences peuvent avoir des prix différents pour les mêmes produits/chambres). L’utilisateur final est un client de l’agence qui dispose d’un menu pour bénéficier des services de l’agence.
    * Chaque hôtel aura son propre serveur et ainsi ses propres services web pour pouvoir :
        * Service web 1 : Consulter les disponibilités par les agences partenaires où :
            * Les données en entrée du service web concernent :
                * Identifiant et mot de passe de l’agence.
                * Dates début et fin de la réservation.
                * Nombre de personnes à héberger.
            * Les données en réponse du service web :
                * Une liste d’offres où une offre est caractérisée par :
                    * Un Identifiant de l’offre.
                    * Type de chambre : nombre de lits.
                    * Date de disponibilité.
                    * Prix.
        * Service web 2 : Effectuer une réservation où :
            * Les données en entrée du service web concernent :
                * Identifiant de l’agence.
                * Login.
                * Mot de passe.
                * Identifiant de l’offre.
                * Informations personne principale.
            * Les données en réponse du service web :
                * Confirmation de la réservation ou problème.
                * Référence de la réservation si cette dernière est confirmée.

## Version distribuée- service web intègre des images

Modifier l’application précédente pour que le service « Service web 1 : Consulter les disponibilités par les agences partenaires » puisse retourner une image de la chambre proposée au client.

## Un service web proposé par les agences de voyage pour comparateurs

Nous souhaitons proposer à certaines applications (exemple : Trivago) un service web leur permettant de réaliser la comparaison d’offres d’hébergement d’hôtels proposés par les agences de voyage en ligne. Pour cela, un client (un usager) fournit à l’application « Comparateur », via une interface IHM (web, console ou autre), les données suivantes concernant son hébergement : ville d'hébergement, dates début et fin de la réservation, nombre de personnes à héberger et le type d'hôtel (nombre minimum d'étoiles). L’application en question (Trivago) utilisera respectivement le service web proposé par chaque agence de voyage pour obtenir les informations suivantes : une liste d'offres où chaque offre contient les données suivantes : nom d'hôtel, adresse de l'hôtel, nombre d'étoiles de l'hôtel, nombre de lits proposés, prix proposé. L’application utilisera ces réponses pour répondre à son tour au client/usager (son utilisateur) en lui fournissant les offres reçues avec les noms des agences en ligne qui les proposent.

## (Bonus) : Version distribuée- Base de données et interface graphique.

* Intégrer aux services web proposés des bases de données pour stocker les données
persistantes.

* Proposez des interfaces graphiques respectivement pour l’application agence de
voyage et l’application comparateur.
