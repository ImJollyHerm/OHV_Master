-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Erstellungszeit: 12. Feb 2020 um 14:53
-- Server-Version: 10.1.8-MariaDB
-- PHP-Version: 5.6.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `obsthandel`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel`
--

CREATE TABLE `artikel` (
  `ArtikelID` int(99) NOT NULL,
  `Bezeichnung` varchar(100) NOT NULL,
  `Preis` decimal(7,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `artikel`
--

INSERT INTO `artikel` (`ArtikelID`, `Bezeichnung`, `Preis`) VALUES
(1, 'Kiste Kiwi', '9.80'),
(2, 'Kiste Butterbirne', '8.10'),
(3, 'Kürbis', '2.90'),
(4, '1 kg Johannisbeeren', '3.40'),
(5, '1 kg Bananen', '1.30'),
(6, '1 Stk Ananas', '1.95'),
(7, 'Honigmelone', '1.90'),
(8, 'Kiste Äpfel', '7.90');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestellung`
--

CREATE TABLE `bestellung` (
  `BestellungsID` int(99) NOT NULL,
  `KundenID` int(9) NOT NULL,
  `Datum` date NOT NULL,
  `Preis` decimal(12,2) NOT NULL,
  `Bezahlt` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `bestellung`
--

INSERT INTO `bestellung` (`BestellungsID`, `KundenID`, `Datum`, `Preis`, `Bezahlt`) VALUES
(1, 1, '2020-01-08', '68.40', 1),
(2, 2, '2020-01-05', '12.60', 0),
(3, 1, '2019-12-10', '132.60', 0),
(4, 1, '2020-01-20', '36.20', 0);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kunde`
--

CREATE TABLE `kunde` (
  `KundenID` int(99) NOT NULL,
  `Vorname` varchar(100) NOT NULL,
  `Nachname` varchar(100) NOT NULL,
  `Strasse` varchar(100) NOT NULL,
  `PLZ` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `kunde`
--

INSERT INTO `kunde` (`KundenID`, `Vorname`, `Nachname`, `Strasse`, `PLZ`) VALUES
(1, 'Dustin', 'Herm', 'Rennigweg 18', 97944),
(2, 'Heinzer', 'Strunck', 'Hagendorn 4', 91056),
(3, 'Annekret', 'KK', 'Blauweg 13', 91056),
(4, 'Hansel', 'Brugger', 'Überweg 42', 97980);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ort`
--

CREATE TABLE `ort` (
  `PLZ` int(5) NOT NULL,
  `Ort` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `ort`
--

INSERT INTO `ort` (`PLZ`, `Ort`) VALUES
(91056, 'Erlangen'),
(97944, 'Boxberg'),
(97980, 'Bad Mergentheim');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `positionen`
--

CREATE TABLE `positionen` (
  `PositionID` int(99) NOT NULL,
  `BestellungsID` int(99) NOT NULL,
  `ArtikelID` int(99) NOT NULL,
  `Menge` int(99) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `positionen`
--

INSERT INTO `positionen` (`PositionID`, `BestellungsID`, `ArtikelID`, `Menge`) VALUES
(0, 1, 1, 4),
(1, 1, 2, 2),
(2, 1, 3, 5),
(3, 2, 3, 2),
(4, 2, 4, 2),
(5, 3, 5, 12),
(6, 3, 6, 60),
(7, 4, 5, 4),
(8, 4, 7, 8),
(9, 4, 8, 2);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `artikel`
--
ALTER TABLE `artikel`
  ADD PRIMARY KEY (`ArtikelID`);

--
-- Indizes für die Tabelle `bestellung`
--
ALTER TABLE `bestellung`
  ADD PRIMARY KEY (`BestellungsID`);

--
-- Indizes für die Tabelle `kunde`
--
ALTER TABLE `kunde`
  ADD PRIMARY KEY (`KundenID`),
  ADD UNIQUE KEY `KundenID_2` (`KundenID`),
  ADD KEY `KundenID` (`KundenID`),
  ADD KEY `KundenID_3` (`KundenID`);

--
-- Indizes für die Tabelle `ort`
--
ALTER TABLE `ort`
  ADD PRIMARY KEY (`PLZ`),
  ADD KEY `PLZ` (`PLZ`);

--
-- Indizes für die Tabelle `positionen`
--
ALTER TABLE `positionen`
  ADD PRIMARY KEY (`PositionID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `artikel`
--
ALTER TABLE `artikel`
  MODIFY `ArtikelID` int(99) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT für Tabelle `kunde`
--
ALTER TABLE `kunde`
  MODIFY `KundenID` int(99) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
