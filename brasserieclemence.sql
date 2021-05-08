-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  Dim 18 oct. 2020 à 14:29
-- Version du serveur :  10.4.10-MariaDB
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `brasserieclemence`
--

-- --------------------------------------------------------

--
-- Structure de la table `composer`
--

DROP TABLE IF EXISTS `composer`;
CREATE TABLE IF NOT EXISTS `composer` (
  `idIngredient` int(11) NOT NULL,
  `idRecette` int(11) NOT NULL,
  `quantite` double(12,2) NOT NULL DEFAULT 0.00,
  PRIMARY KEY (`idIngredient`,`idRecette`),
  KEY `composer_Recette0_FK` (`idRecette`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `composer`
--

INSERT INTO `composer` (`idIngredient`, `idRecette`, `quantite`) VALUES
(14, 26, 300.00),
(14, 27, 300.00),
(15, 26, 3.00),
(15, 27, 3.00),
(16, 26, 300.00),
(16, 27, 300.00),
(17, 26, 2.00),
(17, 27, 2.00),
(18, 26, 0.20),
(19, 27, 0.20);

-- --------------------------------------------------------

--
-- Structure de la table `ingredient`
--

DROP TABLE IF EXISTS `ingredient`;
CREATE TABLE IF NOT EXISTS `ingredient` (
  `idIngredient` int(11) NOT NULL AUTO_INCREMENT,
  `nomIngredient` varchar(100) NOT NULL,
  `fournisseurIngredient` varchar(100) NOT NULL,
  `numeroBioIngredient` int(11) DEFAULT NULL,
  PRIMARY KEY (`idIngredient`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `ingredient`
--

INSERT INTO `ingredient` (`idIngredient`, `nomIngredient`, `fournisseurIngredient`, `numeroBioIngredient`) VALUES
(13, 'Sucre', 'Daddy', NULL),
(14, 'Sucre roux', 'Ethiquable', 524),
(15, 'Oeuf', 'Loué', 147),
(16, 'Farine', 'Carrefour BIO', 487),
(17, 'Levure', 'PrimCal', 942),
(18, 'Lait', 'Lactel', 784),
(19, 'Lait', 'Carrefour', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `recette`
--

DROP TABLE IF EXISTS `recette`;
CREATE TABLE IF NOT EXISTS `recette` (
  `idRecette` int(11) NOT NULL AUTO_INCREMENT,
  `nomRecette` varchar(100) NOT NULL,
  `dateCreationRecette` date NOT NULL,
  PRIMARY KEY (`idRecette`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `recette`
--

INSERT INTO `recette` (`idRecette`, `nomRecette`, `dateCreationRecette`) VALUES
(26, 'Bon gâteau', '2020-10-18'),
(27, 'Gâteau bof', '2020-10-18');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `userId` int(11) NOT NULL AUTO_INCREMENT,
  `userLogin` varchar(50) NOT NULL,
  `userPassword` varchar(50) NOT NULL,
  `userNom` varchar(50) NOT NULL,
  `userPrenom` varchar(50) NOT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`userId`, `userLogin`, `userPassword`, `userNom`, `userPrenom`) VALUES
(1, 'lchevalot', '0550002D', 'CHEVALOT', 'Lucas');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `composer`
--
ALTER TABLE `composer`
  ADD CONSTRAINT `composer_Ingredient_FK` FOREIGN KEY (`idIngredient`) REFERENCES `ingredient` (`idIngredient`),
  ADD CONSTRAINT `composer_Recette0_FK` FOREIGN KEY (`idRecette`) REFERENCES `recette` (`idRecette`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
