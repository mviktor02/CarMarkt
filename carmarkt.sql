-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 07, 2022 at 01:56 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.3.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `carmarkt`
--
CREATE DATABASE IF NOT EXISTS `carmarkt` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `carmarkt`;

-- --------------------------------------------------------

--
-- Table structure for table `cars`
--

DROP TABLE IF EXISTS `cars`;
CREATE TABLE `cars` (
  `code` int(10) UNSIGNED NOT NULL,
  `make` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `model` varchar(200) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `body` int(10) UNSIGNED NOT NULL COMMENT 'Body Type, enum',
  `fuel` int(10) UNSIGNED NOT NULL COMMENT 'Fuel Type, enum',
  `year` smallint(5) UNSIGNED NOT NULL COMMENT 'Year the car was made in',
  `price` int(10) UNSIGNED NOT NULL COMMENT 'Price in €',
  `description` varchar(500) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `phone` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `owner` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- RELATIONSHIPS FOR TABLE `cars`:
--

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

DROP TABLE IF EXISTS `comments`;
CREATE TABLE `comments` (
  `id` int(10) UNSIGNED NOT NULL,
  `code` int(10) UNSIGNED NOT NULL,
  `message` varchar(250) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `owner` varchar(20) COLLATE utf8mb4_hungarian_ci DEFAULT NULL,
  `time` datetime NOT NULL COMMENT 'DateTime the comment was made'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- RELATIONSHIPS FOR TABLE `comments`:
--   `code`
--       `cars` -> `code`
--   `owner`
--       `users` -> `name`
--

-- --------------------------------------------------------

--
-- Stand-in structure for view `usernames`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `usernames`;
CREATE TABLE `usernames` (
`name` varchar(20)
);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `name` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `password` varchar(64) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- RELATIONSHIPS FOR TABLE `users`:
--

-- --------------------------------------------------------

--
-- Structure for view `usernames`
--
DROP TABLE IF EXISTS `usernames`;

DROP VIEW IF EXISTS `usernames`;
CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `usernames`  AS SELECT `users`.`name` AS `name` FROM `users` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_owner` (`owner`),
  ADD KEY `FK_code` (`code`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cars`
--
ALTER TABLE `cars`
  MODIFY `code` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `comments`
--
ALTER TABLE `comments`
  ADD CONSTRAINT `FK_code` FOREIGN KEY (`code`) REFERENCES `cars` (`code`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_owner` FOREIGN KEY (`owner`) REFERENCES `users` (`name`) ON DELETE SET NULL ON UPDATE CASCADE;


COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
