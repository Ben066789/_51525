-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 15, 2025 at 02:45 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `crudprac`
--

-- --------------------------------------------------------

--
-- Table structure for table `crudtest`
--

CREATE TABLE `crudtest` (
  `ID` int(5) NOT NULL,
  `firstName` varchar(30) NOT NULL,
  `lastName` varchar(30) NOT NULL,
  `middleName` varchar(30) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `birthday` date NOT NULL,
  `course` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `crudtest`
--

INSERT INTO `crudtest` (`ID`, `firstName`, `lastName`, `middleName`, `gender`, `birthday`, `course`) VALUES
(2, 'Test2', 'test', 'test', 'Male', '2025-05-15', 'Test1'),
(3, 'Test3', 'test', 'test', 'Male', '2025-05-15', 'Test1'),
(4, 'Test4', 'test', 'test', 'Male', '2025-05-15', 'Test1'),
(5, 'Test5', 'test', 'test', 'Male', '2025-05-15', 'Test1'),
(6, 'Test6', 'test', 'test', 'Male', '2025-05-15', 'Test1'),
(7, 'Test7', 'test', 'test', 'Male', '2025-05-15', 'Test1'),
(8, 'Test8', 'test', 'test', 'Male', '2025-05-15', 'Test1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `crudtest`
--
ALTER TABLE `crudtest`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `crudtest`
--
ALTER TABLE `crudtest`
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
