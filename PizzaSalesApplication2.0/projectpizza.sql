-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 05 Tem 2024, 22:16:48
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `projectpizza`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `pizzabox`
--

CREATE TABLE `pizzabox` (
  `Id` int(11) NOT NULL,
  `Kinds` char(255) DEFAULT NULL,
  `Stock` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `pizzabox`
--

INSERT INTO `pizzabox` (`Id`, `Kinds`, `Stock`) VALUES
(1, 'Mexicano Pizza', 249),
(2, 'Pizza With Cheddar Sauce', 250),
(3, 'Extravaganzza', 250),
(4, 'Callypso', 250),
(5, 'Plenty Of Meat', 250),
(6, 'Pastrami & Sausage', 250),
(7, 'Margarita', 247),
(8, 'Loves Mushrooms', 248),
(9, 'Loves Sausage', 250);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `registerformt`
--

CREATE TABLE `registerformt` (
  `Snamesurname` varchar(50) DEFAULT NULL,
  `Saddress` varchar(256) DEFAULT NULL,
  `Sphonenumber` int(11) DEFAULT NULL,
  `Semail` varchar(100) DEFAULT NULL,
  `Spassword` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `registerformt`
--

INSERT INTO `registerformt` (`Snamesurname`, `Saddress`, `Sphonenumber`, `Semail`, `Spassword`) VALUES
('Baran', 'TEST', 12345, 'TEST', 'TEST');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `pizzabox`
--
ALTER TABLE `pizzabox`
  ADD PRIMARY KEY (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
