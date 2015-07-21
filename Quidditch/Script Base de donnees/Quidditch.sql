DROP TABLE Reservation;
DROP TABLE Match;
DROP TABLE Joueur;
DROP TABLE Equipe;
DROP TABLE Coupe;
DROP TABLE Stade;
DROP TABLE Arbitre;
DROP TABLE Spectateur;

CREATE TABLE Coupe(
id INT IDENTITY(1,1) CONSTRAINT coupe_pk PRIMARY KEY,
dateCoupe DATE
);
CREATE TABLE Equipe(
id INT IDENTITY(1,1) CONSTRAINT equipe_pk PRIMARY KEY,
nom VARCHAR(30),
pays VARCHAR(40)
);
CREATE TABLE Joueur(
id INT IDENTITY(1,1) CONSTRAINT joueur_pk PRIMARY KEY,
nom VARCHAR(30),
prenom VARCHAR(30),
dateNaissance DATE,
capitaine VARCHAR(5),
nombreSelection INT,
poste VARCHAR(20),
equipe_id_ref INT,
CONSTRAINT joueur_equipe FOREIGN KEY (equipe_id_ref) REFERENCES Equipe(id)
)
CREATE TABLE Stade(
id INT IDENTITY(1,1) CONSTRAINT stade_pk PRIMARY KEY,
nom VARCHAR(30),
adresse VARCHAR(50),
nombrePlace INT,
commission FLOAT(4)
);
CREATE TABLE Arbitre(
id INT IDENTITY(1,1) CONSTRAINT arbitre_pk PRIMARY KEY,
nom VARCHAR(30),
prenom VARCHAR(50),
dateNaissance DATE,
numeroAssuranceVie VARCHAR(30),
);
CREATE TABLE Spectateur(
id INT IDENTITY(1,1) CONSTRAINT spectateur_pk PRIMARY KEY,
nom VARCHAR(30),
prenom VARCHAR(50),
dateNaissance DATE,
adresse VARCHAR(30),
email VARCHAR(30)
);
CREATE TABLE Match(
id INT IDENTITY(1,1) CONSTRAINT match_pk PRIMARY KEY,
dateMatch DATE,
scoreEquipeDomicile INT,
scoreEquipeVisiteur INT,
arbitre_id_ref INT,
stade_id_ref INT,
coupe_id_ref INT,
equipeDomicile_id_ref INT,
equipeVisiteur_id_ref INT,
CONSTRAINT match_arbitre FOREIGN KEY (arbitre_id_ref) REFERENCES Arbitre(id),
CONSTRAINT match_stade FOREIGN KEY (stade_id_ref) REFERENCES Stade(id),
CONSTRAINT match_coupe FOREIGN KEY (coupe_id_ref) REFERENCES Coupe(id),
CONSTRAINT match_equipeDomicile FOREIGN KEY (equipeDomicile_id_ref) REFERENCES Equipe(id),
CONSTRAINT match_equipeVisiteur FOREIGN KEY (equipeVisiteur_id_ref) REFERENCES Equipe(id)
);
CREATE TABLE Reservation(
id INT IDENTITY(1,1) CONSTRAINT reservation_pk PRIMARY KEY,
place INT,
prix FLOAT(4),
match_id_ref INT,
spectateur_id_ref INT,
CONSTRAINT reservation_match FOREIGN KEY (match_id_ref) REFERENCES Match(id),
CONSTRAINT reservation_spectateur FOREIGN KEY (spectateur_id_ref) REFERENCES Spectateur(id)
);

--Insertions

DELETE FROM Reservation;
DELETE FROM Match;
DELETE FROM Joueur;
DELETE FROM Spectateur;
DELETE FROM Equipe;
DELETE FROM Arbitre;
DELETE FROM Stade;
DELETE FROM Coupe;

SET IDENTITY_INSERT Coupe ON;
INSERT INTO Coupe (id, dateCoupe)
VALUES (0, '04/04/2015');
SET IDENTITY_INSERT Coupe OFF;

SET IDENTITY_INSERT Spectateur ON;
INSERT INTO Spectateur (id, nom, prenom, dateNaissance, adresse, email)
VALUES (0, 'Mignion', 'Chaton', '04/12/2012', '4 rue de la goutière', 'chaton@udamail.fr');
INSERT INTO Spectateur (id, nom, prenom, dateNaissance, adresse, email)
VALUES (1, 'Plan', 'Ran tan', '05/08/1997', '18 avenue du désert', 'luckyluke@hotmail.fr');
SET IDENTITY_INSERT Spectateur OFF;

SET IDENTITY_INSERT Stade ON;
INSERT INTO Stade (id, nom, adresse, nombrePlace, commission)
VALUES (0, 'Marcel Michelin', 'Montferrand', 20000, 14.5);
INSERT INTO Stade (id, nom, adresse, nombrePlace, commission)
VALUES (1, 'Jean Bouin', 'Bobigny"', 22000, 23.0);
INSERT INTO Stade (id, nom, adresse, nombrePlace, commission)
VALUES (2, 'Ernest Wallon', 'Toulouse', 31000, 11.0);
INSERT INTO Stade (id, nom, adresse, nombrePlace, commission)
VALUES (3, 'Yves le Manoir', 'Montpellier', 14000, 12.0);
SET IDENTITY_INSERT Stade OFF;

SET IDENTITY_INSERT Arbitre ON;
INSERT INTO Arbitre (id, nom, prenom, dateNaissance, numeroAssuranceVie)
VALUES (0, 'Garces', 'Jérome', '1971-04-28', '1710464');
INSERT INTO Arbitre (id, nom, prenom, dateNaissance, numeroAssuranceVie)
VALUES (1, 'Owens', 'Mike', '1964-11-04', '1641107');
SET IDENTITY_INSERT Arbitre OFF;

SET IDENTITY_INSERT Equipe ON;
INSERT INTO Equipe (id, nom, pays)
VALUES (0, 'Les financiers volants', 'Moldavie');
INSERT INTO Equipe (id, nom, pays)
VALUES (1, 'Les petits chatons', 'Malawi');
INSERT INTO Equipe (id, nom, pays)
VALUES (2, 'Les découp(l)eurs', 'Honduras');
SET IDENTITY_INSERT Equipe OFF;

SET IDENTITY_INSERT Joueur ON;
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (0, 'Neymard', 'Jean', '1991-08-21', 'false', 45, 'Attrapeur', 0);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (1, 'Ton', 'Dupont', '1990-05-04', 'false', 71, 'Gardien', 0);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (2, 'Erka', 'Damien', '1987-11-09', 'true', 36, 'Poursuiveur', 0);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (3, 'Hemaya', 'Pacal', '1990-02-17', 'false', 23, 'Batteur', 0);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (4, 'Mendelsohn', 'Jonathan', '1988-12-15', 'false', 74, 'Poursuiveur', 0);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (5, 'Vegas', 'Dimitri', '1990-05-25', 'false', 112, 'Poursuiveur', 0);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (6, 'Mike', 'Like', '1988-08-04', 'false', 120, 'Batteur', 0);

INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (7, 'Van Buuren', 'Armin', '1982-07-14', 'true', 97, 'Attrapeur', 1);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (8, 'Heart', 'Brennan', '1999-12-02', 'false', 114, 'Gardien', 1);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (9, 'Heldens', 'Oliver', '1993-01-17', 'false', 54, 'Poursuiveur', 1);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (10, 'Jordan', 'Julian', '1994-08-29', 'false', 142, 'Batteur', 1);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (11, 'Van Doorn', 'Sander', '1979-10-09', 'false', 40, 'Poursuiveur', 1);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (12, 'Diablo', 'Don', '1991-03-30', 'false', 51, 'Poursuiveur', 1);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (13, 'Klejn', 'Eelke', '1985-02-04', 'false', 87, 'Batteur', 1);

INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (14, 'Coursevent', 'Sylvanas', '1997-11-04', 'true', 78, 'Attrapeur', 2);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (15, 'Hurlenfer', 'Garrosh', '1987-05-14', 'false', 46, 'Gardien', 2);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (16, 'Wyrmn', 'Anduin', '1997-01-12', 'false', 58, 'Poursuiveur', 2);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (17, 'Fairlina', 'Grande veuve', '1995-09-17', 'false', 67, 'Batteur', 2);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (18, 'Dan', 'Gul', '1957-09-17', 'false', 247, 'Poursuiveur', 2);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (19, 'Sanguinar', 'Valeera ', '1991-03-30', 'false', 87, 'Poursuiveur', 2);
INSERT INTO Joueur (id, nom, prenom, dateNaissance, capitaine, nombreSelection, poste, equipe_id_ref)
VALUES (20, 'Hurlorage', 'Malfurion', '1985-02-04', 'false', 14, 'Batteur', 2);
SET IDENTITY_INSERT Joueur OFF;

SET IDENTITY_INSERT Match ON;
INSERT INTO Match (id, dateMatch, scoreEquipeDomicile, scoreEquipeVisiteur, 
arbitre_id_ref, stade_id_ref, coupe_id_ref, equipeDomicile_id_ref, equipeVisiteur_id_ref)
VALUES (0, '2015-04-04', 460, 160, 1, 0, 0, 0, 1);
INSERT INTO Match (id, dateMatch, scoreEquipeDomicile, scoreEquipeVisiteur, 
arbitre_id_ref, stade_id_ref, coupe_id_ref, equipeDomicile_id_ref, equipeVisiteur_id_ref)
VALUES (1, '2015-04-06', 160, 170, 0, 0, 0, 1, 0);
INSERT INTO Match (id, dateMatch, scoreEquipeDomicile, scoreEquipeVisiteur, 
arbitre_id_ref, stade_id_ref, coupe_id_ref, equipeDomicile_id_ref, equipeVisiteur_id_ref)
VALUES (2, '2015-07-09', 0, 150, 1, 1, 0, 2, 0);
INSERT INTO Match (id, dateMatch, scoreEquipeDomicile, scoreEquipeVisiteur, 
arbitre_id_ref, stade_id_ref, coupe_id_ref, equipeDomicile_id_ref, equipeVisiteur_id_ref)
VALUES (3, '2015-07-12', 490, 840, 0, 3, 0, 1, 2);
SET IDENTITY_INSERT Match OFF;

SET IDENTITY_INSERT Reservation ON;
INSERT INTO Reservation (id, place, prix, match_id_ref, spectateur_id_ref)
VALUES (0, 4, 200.0, 3, 0);
INSERT INTO Reservation (id, place, prix, match_id_ref, spectateur_id_ref)
VALUES (1, 12, 140.0, 3, 1);
INSERT INTO Reservation (id, place, prix, match_id_ref, spectateur_id_ref)
VALUES (2, 3, 40.0, 2, 0);
SET IDENTITY_INSERT Reservation OFF;
