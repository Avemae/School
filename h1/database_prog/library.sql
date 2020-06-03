-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2020 at 01:05 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library`
--

-- --------------------------------------------------------

--
-- Stand-in structure for view `allauthors`
-- (See below for the actual view)
--
CREATE TABLE `allauthors` (
`author_ID` int(11)
,`first_name` varchar(255)
,`last_name` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `allbooks`
-- (See below for the actual view)
--
CREATE TABLE `allbooks` (
`book_ID` int(11)
,`author_ID` int(11)
,`title` varchar(255)
,`release_year` int(11)
);

-- --------------------------------------------------------

--
-- Table structure for table `author`
--

CREATE TABLE `author` (
  `author_ID` int(11) NOT NULL,
  `first_name` varchar(255) DEFAULT NULL,
  `last_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `author`
--

INSERT INTO `author` (`author_ID`, `first_name`, `last_name`) VALUES
(1, 'J.K.', 'Rowling'),
(2, 'George R. R.', 'Martin'),
(3, 'Jane', 'Austen'),
(4, 'Roald', 'Dahl'),
(5, 'Mary', 'Shelley'),
(6, 'Leo', 'Tolstoy'),
(7, 'Vladimir', 'Nabokov'),
(8, 'William', 'Shakespeare'),
(9, 'Lewis', 'Carroll'),
(10, 'J. R. R.', 'Tolkien'),
(11, 'Margaret', 'Mitchell'),
(12, 'Agatha', 'Christie'),
(13, 'Antoine', 'de Saint-Exupéry'),
(14, 'C. S.', 'Lewis'),
(15, 'Bram', 'Stocker');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `book_ID` int(11) NOT NULL,
  `author_ID` int(11) NOT NULL,
  `title` varchar(255) DEFAULT NULL,
  `release_year` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`book_ID`, `author_ID`, `title`, `release_year`) VALUES
(1, 14, 'The Lion, the Witch and the Wardrobe', 1950),
(2, 15, 'Dracula', 1897),
(3, 13, 'The Little Prince', 1943),
(4, 11, 'Gone With The Wind', 1936),
(5, 10, 'The Fellowship of the Ring', 1954),
(6, 9, 'Alice\'s Adventures in Wonderland', 1865),
(7, 8, 'Hamlet', 1601),
(8, 7, 'Lolita', 1955),
(9, 6, 'Anna Karenina', 1878),
(10, 5, 'Frankenstein', 1818),
(11, 4, 'Charlie and the Chocolate Factory', 1964),
(12, 3, 'Pride and Prejudice', 1813),
(13, 12, 'And Then There Were None', 1939),
(14, 2, 'A Game of Thrones', 1996),
(15, 2, 'A Storm of Swords', 2000),
(16, 2, 'A Dance with Dragons', 2011),
(17, 1, 'The Philosopher\'s Stone', 1997),
(18, 1, 'The Prisoner of Azkaban', 1999),
(19, 1, 'The Order of the Phoenix', 2003),
(20, 1, 'The Deathly Hallows', 2007);

-- --------------------------------------------------------

--
-- Stand-in structure for view `booksandauthors`
-- (See below for the actual view)
--
CREATE TABLE `booksandauthors` (
`author_ID` int(11)
,`first_name` varchar(255)
,`last_name` varchar(255)
,`title` varchar(255)
,`release_year` int(11)
);

-- --------------------------------------------------------

--
-- Structure for view `allauthors`
--
DROP TABLE IF EXISTS `allauthors`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `allauthors`  AS  select `author`.`author_ID` AS `author_ID`,`author`.`first_name` AS `first_name`,`author`.`last_name` AS `last_name` from `author` ;

-- --------------------------------------------------------

--
-- Structure for view `allbooks`
--
DROP TABLE IF EXISTS `allbooks`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `allbooks`  AS  select `books`.`book_ID` AS `book_ID`,`books`.`author_ID` AS `author_ID`,`books`.`title` AS `title`,`books`.`release_year` AS `release_year` from `books` ;

-- --------------------------------------------------------

--
-- Structure for view `booksandauthors`
--
DROP TABLE IF EXISTS `booksandauthors`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `booksandauthors`  AS  select `author`.`author_ID` AS `author_ID`,`author`.`first_name` AS `first_name`,`author`.`last_name` AS `last_name`,`books`.`title` AS `title`,`books`.`release_year` AS `release_year` from (`author` join `books` on(`author`.`author_ID` = `books`.`author_ID`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `author`
--
ALTER TABLE `author`
  ADD PRIMARY KEY (`author_ID`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`book_ID`),
  ADD KEY `author_ID` (`author_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `author`
--
ALTER TABLE `author`
  MODIFY `author_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `book_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`author_ID`) REFERENCES `author` (`author_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
